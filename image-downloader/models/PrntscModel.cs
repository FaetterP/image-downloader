using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace image_downloader.models
{
    class PrntscModel : Model
    {
        public override string url
        {
            get => "https://prntscr.com/";
        }
        public override int[] blacklistSizes
        {
            get => new int[] { 7 };
        }
        public override int length
        {
            get => 12;
        }
        public override string imgType
        {
            get => ".png";
        }

        public override string GenerateURL()
        {
            Random rnd = new Random();
            string str = "";

            for (int i = 0; i < rnd.Next(5, 7); i++)
            {
                if (rnd.Next(0, 38) > 9)
                {
                    str += (char)rnd.Next(97, 123);
                }
                else
                {
                    str += rnd.Next(0, 10);
                }
            }

            string code = getResponse("https://prntscr.com/" + str);

            Regex regex = new Regex(@"<.+image.+>");
            MatchCollection matches = regex.Matches(code);
            string[] strmas = matches[0].ToString().Split('=', '"');
            foreach (string t in strmas)
            {
                if (t.Contains("image") && t.Contains("https")) { return t; }
            }

            return "";
        }

        private static string getResponse(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.UserAgent = "My applicartion name";
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default, true, 8192))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
