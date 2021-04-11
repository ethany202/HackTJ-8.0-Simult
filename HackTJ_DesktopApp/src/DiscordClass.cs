using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace HackTJ_DesktopApp
{
    public class DiscordClass
    {
        public string alias = "Guest";
        public string message = "";
        public string title = "New Message From Simult";

        public string token = "";




        public void SendMessage() {
            WebRequest wr = (HttpWebRequest)WebRequest.Create(token);

            wr.ContentType = "application/json";

            wr.Method = "POST";

            using (var sw = new StreamWriter(wr.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(new
                {
                    username = alias,
                    embeds = new[]
                    {
                        new
                        {
                            description = message,
                            title = title,
                            color = "8460000"
                        }
                    }
                });

                sw.Write(json);
            }

            var response = (HttpWebResponse)wr.GetResponse();
        }

    }

    
}
