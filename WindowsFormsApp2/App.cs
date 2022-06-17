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

namespace WindowsFormsApp2
{
    public class App : ApplicationContext
    {
        private Form1 startForm;
        private LoginForm loginForm;
        private SocketDisabled socketForm;
        private SocketIO client = new SocketIO($"{Settings.server_ws}/");

        public App()
        {
            startForm = new Form1();
            loginForm = new LoginForm();
            startForm.Show();
            startForm.Hide();
            startForm.FormClosed += close;
            loginForm.Show();
            loginForm.Hide();
            loginForm.FormClosed += close;
            socketForm = new SocketDisabled();
            socketForm.Show();
            //socketForm.Hide();
            socketForm.FormClosed += close;
            handler();
            start();
        }
        private void close(object sender, EventArgs e) {
            this.ExitThread();
        }
        private void handler() {
            client.ClientWebSocketProvider = () => new ClientWebSocketManaged();
            client.OnConnected += (sender, e) =>
            {
                Action hideStartForm = () =>
                {
                    startForm.Hide();
                };
                Action hideSocketForm = () => {
                    socketForm.Hide();
                };

                socketForm.Invoke(hideSocketForm);
                Action showStartForm = () =>
                {
                    startForm.Show();
                    startForm.WindowState = FormWindowState.Normal;
                    startForm.Activate();
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
        private void start() {

            client.ConnectAsync();
        }
    }
}
