using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Lab29
{
    public partial class Form1 : Form
    {
        bool alive = false; // �� ���� ��������� ���� ��� ���������
        UdpClient client;
        int LOCALPORT = 8001; // ���� ��� ��������� ����������
        int REMOTEPORT = 8001; // ���� ��� ����������� ����������
        int TTL = 20;
        string HOST = "235.5.5.1"; // ���� ��� ��������� ����������
        IPAddress groupAddress; // ������ ��� ��������� ����������
        string userName; // ��� ����������� � ���
        string logFilePath = "chatlog.txt"; // ���� �� ����� ����

        public Form1()
        {
            InitializeComponent();

            loginButton.Enabled = true; // ������ �����
            logoutButton.Enabled = false; // ������ ������
            sendButton.Enabled = false; // ������ ��������
            chatTextBox.ReadOnly = true; // ���� ��� ����������
            groupAddress = IPAddress.Parse(HOST);
        }


        // ����� ��������� �����������
        private void ReceiveMessages()
        {
            alive = true;
            try
            {
                while (alive)
                {
                    IPEndPoint remoteIp = null;
                    byte[] data = client.Receive(ref remoteIp);
                    string message = Encoding.Unicode.GetString(data);

                    // ������ �������� ����������� � �������� ����
                    this.Invoke(new MethodInvoker(() =>
                    {
                        string time = DateTime.Now.ToShortTimeString();
                        string formattedMessage = time + " " + message + "\r\n" + chatTextBox.Text;
                        chatTextBox.Text = formattedMessage;

                        // �������� ����������� � ����
                        File.AppendAllText(logFilePath, time + " " + message + "\r\n");
                    }));
                }
            }
            catch (ObjectDisposedException)
            {
                if (!alive) return;
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ����� � ����
        private void ExitChat()
        {
            string message = userName + " ������ ���";
            byte[] data = Encoding.Unicode.GetBytes(message);
            client.Send(data, data.Length, HOST, REMOTEPORT);
            client.DropMulticastGroup(groupAddress);
            alive = false;
            client.Close();
            loginButton.Enabled = true;
            logoutButton.Enabled = false;
            sendButton.Enabled = false;
            userNameTextBox.ReadOnly = false;
            userNameTextBox.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (alive) ExitChat();
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            userName = userNameTextBox.Text;
            userNameTextBox.ReadOnly = true;
            try
            {
                client = new UdpClient(LOCALPORT);
                //��'������� �� ��������� ����������
                client.JoinMulticastGroup(groupAddress, TTL);

                // ������ �� ��������� ����������
                Task receiveTask = new Task(ReceiveMessages);
                receiveTask.Start();

                // ����� ����������� ��� ���� ������ �����������
                string message = userName + " ������ �� ����";
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                loginButton.Enabled = false;
                logoutButton.Enabled = true;
                sendButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            ExitChat();
        }

        private void sendButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string message = String.Format("{0}: {1}", userName, messageTextBox.Text);
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                messageTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.Show();
        }

        public void UpdateSettings(string host, int localPort, int remotePort, int ttl, Font font)
        {
            HOST = host;
            LOCALPORT = localPort;
            REMOTEPORT = remotePort;
            TTL = ttl;
            groupAddress = IPAddress.Parse(HOST);
            chatTextBox.Font = font;
        }
    }

}

