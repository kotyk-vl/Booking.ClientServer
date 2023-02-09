using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Net.Sockets;

namespace lab2
{
    public partial class TicketsSearch : Form
    {
        private const int port = 8888;
        private const string server = "127.0.0.1";
        public static string train { get; set; }
        public TicketsSearch()
        {
            InitializeComponent();
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Today;
            dateTimePicker1.MaxDate = dateTime.AddDays(45);
            dateTimePicker1.MinDate = DateTime.Today;
        }
     
            
        private void button_Search_Click(object sender, EventArgs e)
        {
            if (textBox_From.Text == string.Empty)
            {
                MessageBox.Show("Введіть пункт відправлення");
                this.Update();
            }
            else if (textBox_To.Text == string.Empty)
            {
                MessageBox.Show("Введіть місце призначення");
                this.Update();
            }
            else
            {
                this.dataGridView1.Rows.Clear();
                string date = dateTimePicker1.Value.ToString("yyyy-MM-dd ");
                string message = textBox_From.Text + '|' + textBox_To.Text + '|' + date + '|'  ;
                Connect(server,message);
                this.Update();
            }
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

        private void Form5_Search_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Time.Text = DateTime.Now.ToString(" HH:mm:ss ");
            label_Date.Text = DateTime.Now.ToString(" dd MMMM yyyy ");
        }

        private void textBox_From_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != 'і' && l != 'І' && l != 'Є' && l != 'є' && l != 'Ї' && l != 'ї')
            {
                e.Handled = true;
            }
            
        }

        private void textBox_To_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != 'і' && l != 'І' && l != 'Є' && l != 'є' && l != 'Ї' && l != 'ї')
            {
                e.Handled = true;
            }
        }

        private void textBox_From_Leave(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            textBox_From.Text = ti.ToLower(textBox_From.Text);
            textBox_From.Text = ti.ToTitleCase(textBox_From.Text);
        }

        private void textBox_To_Leave(object sender, EventArgs e)
        {
            TextInfo to = CultureInfo.CurrentCulture.TextInfo;
            textBox_To.Text = to.ToLower(textBox_To.Text);
            textBox_To.Text = to.ToTitleCase(textBox_To.Text);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            { String str = string.Empty;
                for (int i = 0; i < e.ColumnIndex; i++)
                { str += dataGridView1.Rows[e.RowIndex].Cells[i].Value + "|"; }
                 train = str;            
                TicketsBooking bok = new TicketsBooking();
                    bok.ShowDialog();
                dataGridView1.Update();
            }
        }


        public void Connect(String server, String message)
        {
            int index = 5;
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
                    String[] Звідки = new String[Convert.ToInt32(N)];
                    String[] Куди = new String[Convert.ToInt32(N)];
                    String[] Дата_Час = new String[Convert.ToInt32(N)];
                    String[] Номер_поїзда = new String[Convert.ToInt32(N)];
                    String[] Кількість_місць = new String[Convert.ToInt32(N)];
                    String[] Вагонів = new String[Convert.ToInt32(N)];


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
                            if ((respon[i] != '|') && (k == 4)) Вагонів[y] += respon[i];
                            if ((respon[i] != '|') && (k == 5)) Кількість_місць[y] += respon[i];
                            if ((respon[i] != '|') && (k == 6))
                            {
                                if (y == Convert.ToInt32(N) - 1) break;
                                else { y++; k = 0; i--; }
                            }

                        }

                    }
                    dataGridView1.Visible = true;
                    for (int i = 0; i < Convert.ToInt32(N); i++)
                    {
                        dataGridView1.Rows.Add(Звідки[i], Куди[i], Дата_Час[i], Номер_поїзда[i], Вагонів[i], Кількість_місць[i]);
                        
                    }

                }
                
                else
                {
                    //dataGridView1.Rows.Add("У Вас немає дійсних квитків");
                    MessageBox.Show("На жаль, по заданому напрямку квитків не знайдено");
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

      
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
        //    textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //    AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
        //    addItems(DataCollection);
        //    textBox1.AutoCompleteCustomSource = DataCollection;
        //}
        //public void addItems(AutoCompleteStringCollection col)
        //{
        //    col.Add("Abel");
        //    col.Add("Bing");
        //    col.Add("Catherine");
        ////    col.Add("Varghese");
        ////    col.Add("John");
        ////    col.Add("Kerry");
        //}
    }
}

