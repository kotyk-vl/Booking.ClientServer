using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    
    public partial class UserAuthorization : Form
    {
        public static string slogin { get; set; }
        public UserAuthorization()
        {
            InitializeComponent();
        }
        private const int port = 8888;
        private const string server = "127.0.0.1";
        public void Connect(String server, String message, string log_in)
        {
            int index = 1;
            TcpClient client = new TcpClient();
            try
            {
                client.Connect(server, port);
                Byte[] data = Encoding.UTF8.GetBytes(index.ToString() + message);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                data = new Byte[512];
                int bytes;
                bytes = stream.Read(data, 0, data.Length);

                String respon = null;
                respon = Encoding.UTF8.GetString(data, 0, bytes);
                String N = null;
                N += respon[0];

                if (Convert.ToInt32(N) != 7)
                {
                    MessageBox.Show("Вітаємо");
                    this.Close();
                    slogin = log_in;
                    Main_Form main = new Main_Form();
                    main.visible();
                }
                else
                {
                    MessageBox.Show(" Невірні вхідні дані  ");
                }

                // Закриття потоків
                stream.Close();
                client.Close();
            }

            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
                MessageBox.Show("Сервер не відповідає");
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
                MessageBox.Show("Сервер не відповідає");
            }

            Console.WriteLine("Запит виконано...");
            Console.Read();
        }
        private void button_exit_Click(object sender, EventArgs e)
        {
            Main_Form main = new Main_Form();
            this.Close();
            //main.Activate();
            main.Show();

        }
        private void button_Log_Click(object sender, EventArgs e)
        {
            if (textBox_Log.Text == string.Empty)
            {
                MessageBox.Show("Введіть логін");
            }
            else if (textBox_Pass.Text == string.Empty)
            {
                MessageBox.Show("Не введено пароль");
            }
            else 
            {
                string message = textBox_Log.Text + "|" + textBox_Pass.Text + "|";
                string log_in = textBox_Log.Text + "|";
                Connect(server,message, log_in);
            }
        }
        private void button_Reg_Click(object sender, EventArgs e)
        {
            UserRegistration log = new UserRegistration();
            log.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
