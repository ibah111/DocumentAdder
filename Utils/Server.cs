using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace DocumentAdder.Utils;

public class Server
{
    HttpListener listener;
    public delegate void CallGetToken(string token);
    public event CallGetToken OnGetToken;
    private bool started;
    public Server()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        listener = new HttpListener();
        listener.Prefixes.Add("http://localhost:11711/");
    }
    public async void Start()
    {
        started = true;
        listener.Start();
        while (started)
            await handlerAsync();
    }
    public async Task handlerAsync()
    {
        var context = await listener.GetContextAsync();
        var request = context.Request;
        var response = context.Response;
        if (request.HttpMethod == "GET" && request.Url.AbsolutePath == "/login")
        {
            var token = request.QueryString.Get("token");
            if (token != null)
            {
                OnGetToken(token);
                string responseString = $"<HTML><BODY>Вы авторизованы. Вы можете закрыть эту страницу</BODY></HTML>";
                byte[] buffer = Encoding.GetEncoding("windows-1251").GetBytes(responseString);
                response.ContentLength64 = buffer.Length;
                System.IO.Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                // You must close the output stream.
                output.Close();
                listener.Stop();
                started = false;
                OnGetToken(token);
            }
        }
        else
        {
            response.AppendHeader("Access-Control-Allow-Origin", "*");
            response.Close();
        }
    }
}
