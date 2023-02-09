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
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
           
        }
        private const int port = 8888;
        private const string server = "127.0.0.1";

        public void Connect(String server, String message)
        {
            int index = 2;
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

                if (Convert.ToInt32(N) != 8)
                {
                    MessageBox.Show("Реєстрація пройшла успішно");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Користувач з таким логіном вже існує. Спробуйте ще ");
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
        bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button_Reg_Click(object sender, EventArgs e)
        {         
            if (!IsValidEmail(textBox_mail.Text))
            {
                MessageBox.Show("Некоректний E-mail");
                this.Update();
            }
            else if (String.IsNullOrWhiteSpace(textBox_pass.Text) || String.IsNullOrEmpty(textBox_pass.Text))
            {
                MessageBox.Show("Поле паролю не може бути пустим");
                this.Update();
            }
            else
            {
               
                string message = maskedTextBox_Fname.Text + "|" + maskedTextBox_Lname.Text + "|" + textBox_Log.Text + "|" + textBox_mail.Text + "|" + textBox_pass.Text + "|";
                Connect(server, message);
                
            }
            
        }

        private void maskedTextBox_Lname_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox_Lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != 'і' && l != 'І' && l != 'Є' && l != 'є' && l != 'Ї' && l != 'ї')
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox_Fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != 'і' && l != 'І' && l != 'Є' && l != 'є' && l != 'Ї' && l != 'ї')
            {
                e.Handled = true;
            }
        }
    }
}
