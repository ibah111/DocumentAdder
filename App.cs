using DocumentAdder.Forms;
using SocketIOClient;
using SocketIOClient.Transport;
using SocketIOClient.Windows7;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
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
                Action hideStartForm = () =>
                {
                    startForm.Hide();
                };
                Action hideSocketForm = () =>
                {
                    socketForm.Hide();
                };

                socketForm.Invoke(hideSocketForm);
                Action showStartForm = () =>
                {
                    startForm.Show();
                    startForm.Loader();
                };
                Action showLoginForm = () =>
                {
                    loginForm.OnLoged += () => startForm.Invoke(showStartForm);
                    loginForm.OnNotLoged += () => startForm.Invoke(hideStartForm);
                    loginForm.CheckLogin();
                };
                loginForm.Invoke(showLoginForm);
            };
            client.OnDisconnected += (sender, e) =>
            {
                Action hideStartForm = () =>
                {
                    startForm.Hide();
                };
                startForm.Invoke(hideStartForm);
                Action showSocketForm = () =>
                {
                    socketForm.Show();
                };
                socketForm.Invoke(hideStartForm);
            };
        }
        private void start()
        {

            client.ConnectAsync();
        }
    }
}
