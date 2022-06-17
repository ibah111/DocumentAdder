using System.Net;
using System.Windows;

namespace WindowsFormsApp2
{
    public class Server
    {
        HttpListener listener;
        public delegate void CallGetToken(string token);
        public event CallGetToken OnGetToken;
        public Server()
        {
            listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:11711/");
        }
        public void Start()
        {
            listener.Start();
            handler();
        }
        public void handler()
        {
            var context = listener.GetContext();
            var request = context.Request;
            if ((request.HttpMethod == "GET") && (request.Url.AbsolutePath == "/login"))
            {
                var token = request.QueryString.Get("token");
                if (token != null)
                {
                    OnGetToken(token);
                    var response = context.Response;
                    string responseString = $"<HTML><BODY>Вы авторизованы. Вы можете закрыть эту страницу</BODY></HTML>";
                    byte[] buffer = System.Text.Encoding.GetEncoding("windows-1251").GetBytes(responseString);
                    response.ContentLength64 = buffer.Length;
                    System.IO.Stream output = response.OutputStream;
                    output.Write(buffer, 0, buffer.Length);
                    // You must close the output stream.
                    output.Close();
                    listener.Stop();
                    OnGetToken(token);
                }
                else
                {
                    listener.Stop();
                }
            }
        }
    }
}
