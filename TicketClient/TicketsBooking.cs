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
    public partial class TicketsBooking : Form
    {
        private const int port = 8888;
        private const string server = "127.0.0.1";
        public TicketsBooking()
        {
            InitializeComponent();
        }

        Dictionary<string, string> selected = new Dictionary<string, string>();
        Button[] _buttons = new Button[40];
        List<string> lst = new List<string>() { };
        String Place = string.Empty;
        int i = 0;
        string logi = UserAuthorization.slogin;
        string train = TicketsSearch.train;
        private void Form7_bok_Load(object sender, EventArgs e)
        {
            Connect(server, train);
            
            for (i = 0; i < _buttons.Length; i++)
            {
                var btn = new Button();
                btn.Width = 81;
                btn.Height = 65;
                int x = i / 4;
                int y = i % 4;
                btn.Location = new Point(btn.Width * x, btn.Height * y);
                btn.Text = (i + 1).ToString();
                btn.Name = $"button{i}";
                btn.Click += new EventHandler(button_Click);
                btn.Enabled = !lst.Any(l => btn.Text == l); 
                btn.Tag = i;
                _buttons[i] = btn;
                tabPage1.Controls.Add(_buttons[i]);
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                if (btn.BackColor == Color.Transparent)
                {
                    btn.BackColor = Color.FromArgb(99, 128, 214);
                    selected.Add(btn.Text, tabPage1.Text + ", місце " + btn.Text);
                    label2.Text = string.Join("\r\n", selected.Select(s => s.Value));
                    label2.Visible = true;
                    Place += btn.Text + "|";
                }
                else
                {
                    selected.Remove(btn.Text);
                    btn.BackColor = Color.Transparent;
                    label2.Text = string.Join("\r\n", selected.Select(s => s.Value));
                }
            }
        }
        private void button_Sel_Click(object sender, EventArgs e)
        {
            if (!label2.Visible)
            {
                MessageBox.Show("Виберіть місце");
            }
            else
            {
                string logi = UserAuthorization.slogin;
                if (logi == null)
                {
                    DialogResult result = MessageBox.Show(
                         "Ви не пройшли авторизацію! Авторизуватись?",
                           "Повідомлення",
                            MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        UserAuthorization lo = new UserAuthorization();
                        lo.ShowDialog();
                        //this.TopMost = true;
                    }
                                            
                }
                else
                {
                    Connect_buy(server, logi, train);
                }
            }
        }
        public void Connect(String server, String train)
        {
            int index = 6;
            TcpClient client = new TcpClient();
            try
            {
                client.Connect(server, port);
                Byte[] data = Encoding.UTF8.GetBytes(index.ToString() + train);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                data = new Byte[512];
                int bytes;
                bytes = stream.Read(data, 0, data.Length);

                String respon = null;
                respon = Encoding.UTF8.GetString(data, 0, bytes);
                String N = null;
                N += respon[0];

                if (Convert.ToInt32(N) != 41)
                {
                    String[] Місць = new String[Convert.ToInt32(N)];

                    //розбір вхідного пакета даних на окремі змінні 
                    for (int i = 2, k = 0, y = 0; i < respon.Length; i++)
                    {
                        if (respon[i] == '|') k++;
                        else
                        {
                            if ((respon[i] != '|') && (k == 0)) Місць[y] += respon[i];
                            if ((respon[i] != '|') && (k == 1))
                            {
                                if (y == Convert.ToInt32(N) - 1) break;
                                else { y++; k = 0; i--; }
                            }

                        }

                    }
                    foreach (String i in Місць)
                        lst.Add(i);
                }
                else
                {
                    MessageBox.Show("На жаль, всі місця зайняті");
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
        public void Connect_buy(String server, String logi, String train)
        {
            int index = 7;
            TcpClient client = new TcpClient();

            try
            {
                client.Connect(server, port);
                Byte[] data = Encoding.UTF8.GetBytes(index.ToString() + logi + train + Place);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                data = new Byte[512];
                int bytes;
                bytes = stream.Read(data, 0, data.Length);

                String respon = null;
                respon = Encoding.UTF8.GetString(data, 0, bytes);
                String N = null;
                N += respon[0];

                if (Convert.ToInt32(N) != 41)
                {
                    MessageBox.Show("Квиток успішно заброньовано");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("На жаль, всі місця зайняті");
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_exit_MouseEnter(object sender, EventArgs e)
        {
            label_back.Visible = true;
        }

        private void button_exit_MouseLeave(object sender, EventArgs e)
        {
            label_back.Visible = false;
        }
    }
}

