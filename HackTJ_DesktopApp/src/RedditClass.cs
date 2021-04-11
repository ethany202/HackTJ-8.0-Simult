using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Reddit;
using Reddit.Controllers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HackTJ_DesktopApp
{
    public class RedditClass
    {
        private const string appId = "XO3xfE49_pitEw";
        private const string appSecret = "owUoj2GSXkhQOcLYXxy-9ef-vDl3FQ";
        private string accessToken = "";

        public string username = "";
        public string password = "";

        private string baseUrl = "https://www.reddit.com/api/v1/access_token";
        private RedditClient redditClient;
        private User self;

        public string subreddit = "";
        public object media;
        public string title = "";
        public string text = "";
        public string url = "";

        public bool subredditExists;

        public async Task SendPost()
        {
            await PostRequest().ConfigureAwait(false);
        }

        public async Task PostRequest()
        {
            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
            });

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add($"Authorization", $"Basic {Base64Encode($"{appId}:{appSecret}")}");

            var response = await client.PostAsync(baseUrl.ToString(), formContent);
            var stringContent = await response.Content.ReadAsStringAsync();

            JObject obj = (JObject)JsonConvert.DeserializeObject(stringContent);
            //Console.WriteLine(obj["access_token"]);

            accessToken = (string)obj["access_token"];

            //Console.WriteLine(stringContent);
            //close out the client
            client.Dispose();
        }

        public string Base64Encode(string textToEncode)
        {
            byte[] textAsBytes = Encoding.UTF8.GetBytes(textToEncode);
            return Convert.ToBase64String(textAsBytes);
        }

        public void InstantiateUser()
        {
            redditClient = new RedditClient(appId: appId, appSecret: appSecret, accessToken: accessToken);
            self = redditClient.Account.Me;
        }

        public void RedditPost()
        {
            Subreddit sub;
            try
            {
                sub = redditClient.Subreddit(subreddit).About();
                subredditExists = true;
                try
                {
                    var textPost = sub.SelfPost(title, text).Submit();
                }
                catch
                {

                }

                try
                {
                    var linkPost = sub.LinkPost(title, url).Submit();
                }
                catch
                {

                }

            }
            catch (Exception)
            {
                subredditExists = false;
            }

            
        }

        public void ResetValues()
        {
            username = "";
            password = "";
            redditClient = null;
            self = null;
            subreddit = "";
            title = "";
            text = "";
            url = "";
        }
    }
}
