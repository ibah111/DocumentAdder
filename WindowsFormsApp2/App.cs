using SocketIOClient;
using SocketIOClient.Transport;
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
        private SocketDisabled socketForm;
        private SocketIO client = new SocketIO($"https://{Settings.domain}:3001/");

        public App()
        {
            startForm = new Form1();
            startForm.Show();
            startForm.FormClosed += close;
            socketForm = new SocketDisabled();
            socketForm.Show();
            socketForm.FormClosed += close;
            handler();
            start();
        }
        private void close(object sender, EventArgs e) {
            this.ExitThread();
        }
        private void handler() {
#if DEBUG
#endif
            client.OnConnected += (sender, e) =>
            {
                Action hide = () => {
                    socketForm.Hide();
                };

                socketForm.Invoke(hide);
                Action show = () =>
                {
                    startForm.Show();
                    startForm.Loader();
                };
                startForm.Invoke(show);
            };
            client.OnDisconnected += (sender, e) =>
            {
                Action hide = () =>
                {
                    startForm.Hide();
                };
                startForm.Invoke(hide);
                Action show = () =>
                {
                    socketForm.Show();
                };
                socketForm.Invoke(show);
            };
        }
        private void start() {
            startForm.Hide();
            client.ConnectAsync();
        }
    }
}
