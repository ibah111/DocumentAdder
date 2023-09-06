using DocumentAdder.Forms;
using System;

namespace DocumentAdder.Utils;

public class ActionsForms
{
    private MainForm startForm;
    private LoginForm loginForm;
    private SocketForm socketForm;
    public ActionsForms(MainForm startForm, LoginForm loginForm, SocketForm socketForm)
    {
        this.startForm = startForm;
        this.loginForm = loginForm;
        this.socketForm = socketForm;
    }
    public void hideStartForm()
    {
        Action hideStartForm = () =>
        {
            startForm.Hide();
        };
        startForm.Invoke(hideStartForm);
    }
    public void hideSocketForm()
    {
        Action hideSocketForm = () =>
        {
            this.socketForm.Hide();
        };
        socketForm.Invoke(hideSocketForm);
    }
    public void showSocketForm(string data = null)
    {
        Action showSocketForm = () =>
        {
            if (data != null)
            {
                this.socketForm.textError.Text = data;
            }
            else
            {
                this.socketForm.Reset();
            }
            this.socketForm.Show();
        };
        socketForm.Invoke(showSocketForm);
    }
    public void showStartForm()
    {
        Action showStartForm = () =>
        {
            this.startForm.Show();
            this.startForm.Loader();
        };
        startForm.Invoke(showStartForm);
    }
    public void showLoginForm()
    {
        Action showStartForm = () =>
        {
            this.startForm.Show();
            this.startForm.Loader();
        };
        Action hideStartForm = () =>
        {
            this.startForm.Hide();
        };
        Action showLoginForm = () =>
        {
            this.loginForm.OnLoged += this.showStartForm;
            this.loginForm.OnNotLoged += this.hideStartForm;
            this.loginForm.CheckLogin();
        };
        loginForm.Invoke(showLoginForm);
    }
}
