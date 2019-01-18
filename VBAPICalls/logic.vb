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
    ''' <summary>
    ''' Verbs supported by WorkBook
    ''' GET is for getting data
    ''' POST is for updating and getting filters (Updating has been changed to Patch)
    ''' PATCH is for updating. format in Json is { "Patch" : { "Id" : xxx, "SomeProperty" : yyy}
    ''' DELETe is Deleting
    ''' PUT inserts
    ''' HEAD Is used internal
    ''' </summary>
    Public Enum Verb
        [GET]
        POST
        PATCH
        DELETE
        PUT
        HEAD
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

        ''Dim helloReturn = Await Hello()
        Await Login()
        Return True
    End Function

    Private Class HelloRequest
        Private _userName As String
        Public Property UserName() As String
            Get
                Return _userName
            End Get
            Set(ByVal value As String)
                _userName = value
            End Set
        End Property
    End Class

    Private Async Function Hello() As Task(Of Integer)
        Using httpResult = Await createHttpClient("/api/auth/hello", Verb.POST, New HelloRequest With {.UserName = User})
            Dim result As Integer = 0
            Integer.TryParse(httpResult.ReadAsStringAsync().Result, result)
            Return result
        End Using
    End Function

    Private Class LoginRequest
        Private _userName As String
        Public Property UserName() As String
            Get
                Return _userName
            End Get
            Set(ByVal value As String)
                _userName = value
            End Set
        End Property
        Private _password As String
        Public Property Password() As String
            Get
                Return _password
            End Get
            Set(ByVal value As String)
                _password = value
            End Set
        End Property
    End Class

    Private Async Function Login() As Task(Of Boolean)
        Using httpResult = Await createHttpClient("/api/auth/handshake", Verb.POST, New LoginRequest With {.UserName = User, .Password = Password})
            loggedIn = True
            Return True
        End Using
    End Function

    '' <summary>
    '' JobsRequest from the API. Only include active jobs.
    '' </summary>
    '' <returns></returns>
    Public Async Function Jobs() As Task(Of String)

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
    Public Async Function Employee() As Task(Of String)
        If (Not loggedIn) Then
            Await TryLogin()
        End If
        Using httpResult = Await createHttpClient("/api/resource/employees?Active=true", Verb.GET)
            Return httpResult.ReadAsStringAsync().Result
        End Using
    End Function
    Public Class CurrentSession
        Private _Id As Integer
        Public Property Id() As Integer
            Get
                Return _Id
            End Get
            Set(ByVal value As Integer)
                _Id = value
            End Set
        End Property
    End Class

    '' <summary>
    '' CurrentSeesionRequest from the API. Gets the currrent logged in user
    '' </summary>
    '' <returns></returns>
    Public Async Function CurrentUser() As Task(Of Resource)
            If (Not loggedIn) Then
                Await TryLogin()
            End If
        '' currentsession contains the current logged in user. Here we only need the Id
        Using currentSessionResult = Await createHttpClient("/api/auth/currentsession", Verb.GET)
            Dim sess = Newtonsoft.Json.JsonConvert.DeserializeObject(Of CurrentSession)(currentSessionResult.ReadAsStringAsync().Result)

            Using httpResult = Await createHttpClient("/api/resource/" + sess.Id.ToString(), Verb.GET)
                Dim res = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Resource)(httpResult.ReadAsStringAsync().Result)
                Return res
            End Using
        End Using
    End Function

        Private Class ResourcePatchRequest
            Private _patch As Dictionary(Of String, String)
            Public Property Patch() As Dictionary(Of String, String)
                Get
                    Return _patch
                End Get
                Set(ByVal value As Dictionary(Of String, String))
                    _patch = value
                End Set
            End Property
        End Class

        '' <summary>
        '' CurrentSeesionRequest from the API. Gets the currrent logged in user
        '' </summary>
        '' <returns></returns>
        Public Async Function SaveUser(resource As Resource) As Task(Of Resource)
            If (Not loggedIn) Then
                Await TryLogin()
            End If
            '' PATCH takes a dictionary, so we create one.
            '' This can be done with a Generic function
            '' !!! Id should always be supplied for a Patch !!
            Dim patchTmp = createDictionary(Of Resource)(resource)

            Using httpResult = Await createHttpClient("/api/resource", Verb.PATCH, New ResourcePatchRequest With {.Patch = patchTmp})

                Dim res = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Resource)(httpResult.ReadAsStringAsync().Result)
                Return res
            End Using
        End Function

        '' This should have been placed in a shared class, but for the sake of this example, keep it pure VB and pure C#
        Public Class Resource
            Private _Id As Integer
            Public Property Id() As Integer
                Get
                    Return _Id
                End Get
                Set(ByVal value As Integer)
                    _Id = value
                End Set
            End Property

            Private _Name As String
            Public Property Name() As String
                Get
                    Return _Name
                End Get
                Set(ByVal value As String)
                    _Name = value
                End Set
            End Property
            Private _Initials As String
            Public Property Initials() As String
                Get
                    Return _Initials
                End Get
                Set(ByVal value As String)
                    _Initials = value
                End Set
            End Property
            Private _Phone As String
            Public Property Phone1() As String
                Get
                    Return _Phone
                End Get
                Set(ByVal value As String)
                    _Phone = value
                End Set
            End Property
        End Class
        ''' <summary>
        ''' Simple function, converts an object to a dictionary
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        Private Function createDictionary(Of T)(obj As T) As Dictionary(Of String, String)
            Dim PatchDic As Dictionary(Of String, String) = New Dictionary(Of String, String)

            Dim props = obj.GetType.GetProperties(Reflection.BindingFlags.Instance Or Reflection.BindingFlags.Public)

            For Each p In props
                PatchDic.Add(p.Name, p.GetValue(obj))
            Next
            Return PatchDic
        End Function

        Private Async Function createHttpClient(url As String, verb As Verb, Optional content As Object = Nothing) As Task(Of HttpContent)
            Dim handler As HttpClientHandler = New HttpClientHandler()

            '' Save the cookies so we have our authentication
            If (autoCookies Is Nothing) Then
                autoCookies = New CookieContainer()
            End If

            Using client = New HttpClient(handler)

                handler.CookieContainer = autoCookies

                client.BaseAddress = New Uri(ServerUrl)

                Dim result As HttpResponseMessage = Nothing

                Dim reqMsg As HttpRequestMessage = New HttpRequestMessage(New HttpMethod(verb.ToString()), url)

                '' Get does not support body content... Nothing in the specification about it
                If (verb <> Verb.GET And content IsNot Nothing) Then
                    reqMsg.Content = New StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(content), Text.Encoding.UTF8, "application/json")

                End If

                result = Await client.SendAsync(reqMsg)

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
