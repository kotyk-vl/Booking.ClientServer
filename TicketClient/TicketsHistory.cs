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
    public partial class TicketsHistory : Form
    {
        public TicketsHistory()
        {
            InitializeComponent();
        }

        private void Form6_Hist_Load(object sender, EventArgs e)
        {
            UserAuthorization main = new UserAuthorization();
            string logi = UserAuthorization.slogin;
            Connect(server, logi);
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
        private const int port = 8888;
        private const string server = "127.0.0.1";

        public void Connect(String server, String message)
        {
            int index = 4;
            TcpClient client = new TcpClient();

            try
            {
                client.Connect(server, port);
                Byte[] data = Encoding.UTF8.GetBytes(index.ToString() + message);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                data = new Byte[1024];
                int bytes;
                bytes = stream.Read(data, 0, data.Length);

                String respon = null;
                respon = Encoding.UTF8.GetString(data, 0, bytes);
                String N = null;
                N += respon[0];

                if (Convert.ToInt32(N) != 10)
                {
                    String[] Звідки = new String[Convert.ToInt32(N)];
                    String[] Куди = new String[Convert.ToInt32(N)];
                    String[] Дата_Час = new String[Convert.ToInt32(N)];
                    String[] Номер_поїзда = new String[Convert.ToInt32(N)];
                    String[] Місце = new String[Convert.ToInt32(N)];
                    String[] Вагон = new String[Convert.ToInt32(N)];
                    String[] Прізвище = new String[Convert.ToInt32(N)];
                    String[] Імя = new String[Convert.ToInt32(N)];


                    //розбір вхідного пакета даних на окремі змінні 
                    for (int i = 2, k = 0, y = 0; i < respon.Length; i++)
                    {
                        if (respon[i] == '|') k++;
                        else
                        {
                            if ((respon[i] != '|') && (k == 0)) Звідки[y] += respon[i];
                            if ((respon[i] != '|') && (k == 1)) Куди[y] += respon[i];
                            if ((respon[i] != '|') && (k == 2)) Дата_Час[y] += respon[i];
                            if ((respon[i] != '|') && (k == 3)) Номер_поїзда[y] += respon[i];
                            if ((respon[i] != '|') && (k == 4)) Місце[y] += respon[i];
                            if ((respon[i] != '|') && (k == 5)) Вагон[y] += respon[i];
                            if ((respon[i] != '|') && (k == 6)) Прізвище[y] += respon[i];
                            if ((respon[i] != '|') && (k == 7)) Імя[y] += respon[i];
                            if ((respon[i] != '|') && (k == 8))
                            {
                                if (y == Convert.ToInt32(N) - 1) break;
                                else { y++; k = 0; i--; }
                            }

                        }

                    }

                    for (int i = 0; i < Convert.ToInt32(N); i++)
                    {
                        dataGridView1.Rows.Add(Звідки[i], Куди[i], Дата_Час[i], Номер_поїзда[i], Місце[i], Вагон[i], Імя[i], Прізвище[i]);

                    }

                }

                else
                {
                   // dataGridView1.Rows.Add("У Вас немає дійсних квитків");
                    // MessageBox.Show("");
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
    }
}
