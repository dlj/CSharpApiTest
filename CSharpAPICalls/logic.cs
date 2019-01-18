using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAPICalls
{
    public class Logic
    {
        private bool loggedIn = false;
        private CookieContainer autoCookies = null;
        private string serverUrl;
        public string ServerUrl
        {
            get { return serverUrl; }
            set
            { 
                // Server url sanity
                if (value.EndsWith("/"))
                    value = value.Remove(value.Length - 1, 1);

                if (!value.StartsWith("http"))
                    serverUrl = "http://" + value;
                else
                    serverUrl = value;
            }
        }

        private string user;
        public string User
        {
            get { return user; }
            set { user = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public enum Verb
        {
            GET,
            POST
        }

        public Logic()
        {            
        }

        public async Task<bool> TryLogin()
        {
            if (string.IsNullOrEmpty(this.User))
                throw new ArgumentNullException("user");
            if (string.IsNullOrEmpty(this.Password))
                throw new ArgumentNullException("password");
            if (string.IsNullOrEmpty(this.ServerUrl))
                throw new ArgumentNullException("serverUrl");

            await LoginRequest();
            return true;
        }

        private async Task<bool> LoginRequest()
        {
            using (var httpResult = await createHttpClient("/api/auth/handshake", Verb.POST, new KeyValuePair<string, string>[2] { new KeyValuePair<string, string>("UserName", this.user), new KeyValuePair<string, string>("Password", Password)  }))
            {
                loggedIn = true;
                return true;
            }

        }

        /// <summary>
        /// JobsRequest from the API. Only include active jobs.
        /// </summary>
        /// <returns></returns>
        public async Task<string> JobsRequest()
        {
            if (!loggedIn)
                await TryLogin();

            using (var httpResult = await createHttpClient("/api/jobs?Status=[0,1,3]", Verb.GET))
            {
                return httpResult.ReadAsStringAsync().Result;
            }
        }

        /// <summary>
        /// EmployeesRequest from the API. Parm to only take Active emps
        /// </summary>
        /// <returns></returns>
        public async Task<string> EmployeeRequest()
        {
            if (!loggedIn)
                await TryLogin();

            using (var httpResult = await createHttpClient("/api/resource/employees?Active=true", Verb.GET))
            {
                return httpResult.ReadAsStringAsync().Result;
            }
        }

        /// <summary>
        /// CurrentSeesionRequest from the API. Gets the currrent logged in user
        /// </summary>
        /// <returns></returns>
        public async Task<string> CurrentUserRequest()
        {
            if (!loggedIn)
                await TryLogin();

            using (var httpResult = await createHttpClient("/api/auth/currentsession", Verb.GET))
            {
                return httpResult.ReadAsStringAsync().Result;
            }
        }

        private async Task<HttpContent> createHttpClient(string url, Verb verb, KeyValuePair<string,string>[] content = null)
        {
            HttpClientHandler handler = new HttpClientHandler();     
            // Save the cookies so we have our authentication
            if (this.autoCookies == null)       
                this.autoCookies = new CookieContainer();

            using (var client = new HttpClient(handler))
            {
                handler.CookieContainer = autoCookies;

                client.BaseAddress = new Uri(this.serverUrl);

                HttpResponseMessage result = null;

                //Could be made better. Always fallback to Get is not the best way to do this
                if (verb == Verb.POST)
                    result = await client.PostAsync(url, new FormUrlEncodedContent(content));
                else
                    result = await client.GetAsync(url);

                // Error handling... Need more than this.
                result.EnsureSuccessStatusCode();

                return result.Content;
            }
        }

        public string ToHex(byte[] bytes)
        {
            if (bytes == null)
            {
                throw new ArgumentNullException("bytes");
            }

            const string hexChars = "0123456789abcdef";

            int length = bytes.Length * 2;
            char[] hex = new char[length];
            int byteIndex = 0;
            for (int charIndex = 0; charIndex < length;)
            {
                byte byteValue = bytes[byteIndex++];
                hex[charIndex++] = hexChars[byteValue / 16];
                hex[charIndex++] = hexChars[byteValue % 16];
            }
            return new string(hex);
        }

    }
}
