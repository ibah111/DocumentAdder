using DocumentAdder.Forms;
using DocumentAdder.Utils;
using SocketIOClient;
using SocketIOClient.Transport;
using SocketIOClient.Windows7;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentAdder.Main
{
    public class App : ApplicationContext
    {
        private MainForm startForm;
        private LoginForm loginForm;
        private SocketForm socketForm;
        private SocketIO client = new SocketIO($"{Settings.server_ws}/");
        private ActionsForms actions;

        public App()
        {
            startForm = new MainForm();
            loginForm = new LoginForm();
            startForm.Show();
            startForm.Hide();
            startForm.FormClosed += close;
            loginForm.Show();
            loginForm.Hide();
            loginForm.FormClosed += close;
            socketForm = new SocketForm();
            socketForm.Show();
            //socketForm.Hide();
            socketForm.FormClosed += close;
            actions = new ActionsForms(startForm, loginForm, socketForm);
            handler();
            start();
        }
        private void close(object sender, EventArgs e)
        {
            this.ExitThread();
        }
        private void handler()
        {
            client.ClientWebSocketProvider = () => new ClientWebSocketManaged();
            client.OnConnected += (sender, e) =>
            {
                actions.hideSocketForm();
                actions.showLoginForm();
                client.EmitAsync("version-windows", Assembly.GetExecutingAssembly().GetName().Version.ToString());
            };
            client.On("new_version", response=>{
                actions.hideStartForm();
                actions.showSocketForm("Требуется обновление");
            });
            client.OnDisconnected += (sender, e) =>
            {
                actions.hideStartForm();
                actions.showSocketForm();
            };
        }
        private void start()
        {
            client.ConnectAsync();
        }
    }
}
