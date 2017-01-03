Imports System.Net
Imports System.Net.Http
Imports System.Security.Cryptography

Public Class Logic

    Const hexChars As String = "0123456789abcdef"

    Dim loggedIn As Boolean = False
    Dim autoCookies As CookieContainer

    Dim serverUrlProp As String
    Public Property ServerUrl() As String
        Get
            Return serverUrlProp
        End Get
        Set(ByVal value As String)
            If (value.EndsWith("/")) Then
                value = value.Remove(value.Length - 1, 1)
            End If

            If (Not value.StartsWith("http")) Then
                serverUrlProp = "http://" + value
            Else
                serverUrlProp = value
            End If

        End Set
    End Property

    Dim userProp As String
    Public Property User() As String
        Get
            Return userProp
        End Get
        Set(ByVal value As String)
            userProp = value
        End Set
    End Property


    Dim passwordProp As String
    Public Property Password() As String
        Get
            Return passwordProp
        End Get
        Set(ByVal value As String)
            passwordProp = value
        End Set
    End Property

    Public Enum Verb
        [GET]
        POST
    End Enum

    Public Sub Logic()
    End Sub


    Public Async Function TryLogin() As Task(Of Boolean)

        If (String.IsNullOrEmpty(User)) Then
            Throw New ArgumentNullException("user")
        End If
        If (String.IsNullOrEmpty(Password)) Then
            Throw New ArgumentNullException("password")
        End If
        If (String.IsNullOrEmpty(ServerUrl)) Then
            Throw New ArgumentNullException("serverUrl")
        End If

        Dim helloReturn = Await HelloRequest()
        Await LoginRequest(helloReturn)
        Return True
    End Function

    Private Async Function HelloRequest() As Task(Of Integer)
        Using httpResult = Await createHttpClient("/api/auth/hello", Verb.POST, New KeyValuePair(Of String, String)("UserName", User))
            Dim result As Integer = 0
            Integer.TryParse(httpResult.ReadAsStringAsync().Result, result)
            Return result
        End Using
    End Function

    Private Async Function LoginRequest(helloValue As Integer) As Task(Of Boolean)

        Using sha256 = New SHA256Managed()
            Dim encoding As Text.Encoding = System.Text.Encoding.UTF8
            Dim passhash As String = ToHex(sha256.ComputeHash(encoding.GetBytes(ToHex(sha256.ComputeHash(encoding.GetBytes(Password))) + helloValue.ToString())))

            Using httpResult = Await createHttpClient("/api/auth/handshake", Verb.POST, New KeyValuePair(Of String, String)("UserName", User), New KeyValuePair(Of String, String)("Password", passhash))
                loggedIn = True
                Return True
            End Using
        End Using
    End Function

    '' <summary>
    '' JobsRequest from the API. Only include active jobs.
    '' </summary>
    '' <returns></returns>
    Public Async Function JobsRequest() As Task(Of String)

        If (Not loggedIn) Then
            Await TryLogin()
        End If

        Using httpResult = Await createHttpClient("/api/jobs?Status=[0,1,3]", Verb.GET)
            Return httpResult.ReadAsStringAsync().Result
        End Using
    End Function

    '' <summary>
    '' EmployeesRequest from the API. Parm to only take Active emps
    '' </summary>
    '' <returns></returns>
    Public Async Function EmployeeRequest() As Task(Of String)
        If (Not loggedIn) Then
            Await TryLogin()
        End If
        Using httpResult = Await createHttpClient("/api/resource/employees?Active=true", Verb.GET)
            Return httpResult.ReadAsStringAsync().Result
        End Using
    End Function

    '' <summary>
    '' CurrentSeesionRequest from the API. Gets the currrent logged in user
    '' </summary>
    '' <returns></returns>
    Public Async Function CurrentUserRequest() As Task(Of String)
        If (Not loggedIn) Then
            Await TryLogin()
        End If
        Using httpResult = Await createHttpClient("/api/auth/currentsession", Verb.GET)
            Return httpResult.ReadAsStringAsync().Result
        End Using
    End Function

    Private Async Function createHttpClient(url As String, verb As Verb, ParamArray content() As KeyValuePair(Of String, String)) As Task(Of HttpContent)
        Dim handler As HttpClientHandler = New HttpClientHandler()

        '' Save the cookies so we have our authentication
        If (autoCookies Is Nothing) Then
            autoCookies = New CookieContainer()
        End If

        Using client = New HttpClient(handler)

            handler.CookieContainer = autoCookies

            client.BaseAddress = New Uri(ServerUrl)

            Dim result As HttpResponseMessage = Nothing

            ''Could be made better. Always fallback to Get Is Not the best way to do this
            If (verb = Verb.POST) Then
                result = Await client.PostAsync(url, New FormUrlEncodedContent(content))
            Else
                result = Await client.GetAsync(url)
            End If

            ''Error handling... Need more than this.
            result.EnsureSuccessStatusCode()

            Return result.Content
        End Using
    End Function

    Function ToHex(b() As Byte) As String
        Dim xxx = BitConverter.ToString(b)
        Return xxx.Replace("-", "").ToLowerInvariant()
    End Function
End Class
