using System.Windows.Forms;

namespace DocumentAdder.Forms;

public partial class SocketForm : Form
{
    public SocketForm()
    {
        TopMost = true;
        InitializeComponent();
        Reset();
    }
    public void Reset()
    {
        textError.Text = "Соединение с сервером отсутствует\r\nСкорее всего сервер находится на обслужвании\r\n" +
    "Как только сервер будет запущен, программа сама\r\nпродолжит работу\r\n";
    }
}
