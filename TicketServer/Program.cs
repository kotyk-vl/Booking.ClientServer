using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Ticket_Server
{
    class Program : ProgramBase
    {
        const int port = 8888; // порт для прослушивания подключений
        static void Main(string[] args)
        {
            TcpListener server = null;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            try
            {
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                server = new TcpListener(localAddr, port);

                // запуск слушателя
                server.Start();
                Console.WriteLine("----------Очікування підключення... ----------");

                while (true)
                {
                    // При появі клієнта добавляемо в чергу потоків його обробку.
                    ThreadPool.QueueUserWorkItem(GetRequestResponce, server.AcceptTcpClient());
                    Console.WriteLine("Клієнт підключено. Виконання запиту...\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (server !=  null)
                    server.Stop();
            }
        }

        static void GetRequestResponce(object client_obj)
        {
            Byte[] bytes = new Byte[256];
            String str = string.Empty;

            TcpClient client = client_obj as TcpClient;
          
            NetworkStream stream = client.GetStream();
            stream.Read(bytes, 0, 256);
            str = Encoding.UTF8.GetString(bytes);

            if (str[0] == '1')
            {
                byte[] vs = AuthorizationUser(str);
                stream.Write(vs, 0, vs.Length);
                
            }
            else if (str[0] == '2')
            {
                byte[] vs = RegistrationUsers(str);
                stream.Write(vs, 0, vs.Length);
            }
            else if (str[0] == '3')
            {
                byte[] vs = GetActualTickets(str);
                stream.Write(vs, 0, vs.Length);
            }
            else if (str[0] == '4')
            {
                byte[] vs = GetUserHistory(str);
                stream.Write(vs, 0, vs.Length);
            }
            else if (str[0] == '5')
            {
                byte[] vs = SearchTickets(str);
                stream.Write(vs, 0, vs.Length);
            }
            else if (str[0] == '6')
            {
                byte[] vs = SelectPlaceInTrain(str);
                stream.Write(vs, 0, vs.Length);
            }
            else if (str[0] == '7')
            {
                byte[] vs = BookingTickets(str);
                stream.Write(vs, 0, vs.Length);
            }

            Console.WriteLine(" ");
            stream.Close();
            client.Close();
        }

        static byte[] AuthorizationUser(String str)
        {
            //Авторизація
            String[] data = new String[40];
            String log =  String.Empty;
            String pass =  String.Empty;

            String LastName = String.Empty;
            String FirstName = String.Empty;
            String Login = String.Empty;
            String Email = String.Empty;
            String PassWord = String.Empty;
            String N = String.Empty;
            bool Error = false;
            int count = 0;


            try
            {
                int num = 0;
                for (int i=1; i<str.Length; i++)
                {
                    if (str[i] == '|')
                    {
                        num++;
                        if (num == 2) break;
                    }
                    else
                        if ((str[i] != '|') && (num == 0))
                        log += str[i];
                    else pass += str[i];
                }
                Console.WriteLine($"Пошук користувача |{log} | {pass} ");
                if ((log ==  String.Empty) || (pass ==  String.Empty))
                    Error = true;

                Console.WriteLine("Відкриття бази даних");

                string database = ConfigurationManager.AppSettings["DB"];
                SqlConnection connect = new SqlConnection(database);
                connect.Open();

                string query = $"SELECT * FROM Users WHERE Логін = '{log}' AND Пароль = '{pass}'";
                SqlCommand sql = new SqlCommand(query, connect);

                SqlDataReader reader = sql.ExecuteReader();
               
                bool cont = false;
                while (reader.Read())
                {
                    cont = true;
                    LastName = reader["Прізвище"].ToString() + '|';
                    FirstName = reader["Ім'я"].ToString() + '|';
                    Login = reader["Логін"].ToString() + '|';
                    Email = reader["E-mail"].ToString() + '|';
                    PassWord = reader["Пароль"].ToString() + '|';
                    data[count] = LastName + FirstName + Login + Email + PassWord;
                    count++;
                }
                reader.Close();
                N = count.ToString() + '|';

                if (!cont)
                {
                    Console.WriteLine("Користувача не знайдено");
                    Console.WriteLine("Відправлено повідомлення: Невірні вхідні дані ");
                    Error = true;
                }
                else
                {
                    Console.WriteLine("Користувача знайдено");
                    Console.WriteLine($"{count}.{LastName}{FirstName}{Login}{Email}{PassWord}");
                    Console.WriteLine("Відправлено повідомлення: Вітаємо");
                }
                Console.WriteLine("Закриття бази даних");
                connect.Close();
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }

            byte[] res;
            string str1 =  String.Empty;
            if (Error == true)
            {
                res = Encoding.UTF8.GetBytes("7");
                Console.Write("Помилка :");
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Авторизація пройшла успішно");
                str1 += N;
                for (int i = 0; i < count; i++)
                    str1 += data[i];
                res = Encoding.UTF8.GetBytes(str1);
            }
            return res;
        }
        static byte[] RegistrationUsers(String str)
        {
            //РЕєстрація
            String[] data = new String[40];
            String LastName = String.Empty;
            String FirstName = String.Empty;
            String Login = String.Empty;
            String Email = String.Empty;
            String PassWord = String.Empty;
            String N = "1";
            bool Error = false;
            int count = 0;

            try
            {
                int num = 0;
                for (int i = 1; i < str.Length; i++)
                {
                    if (str[i] == '|')
                    {
                        num++;
                        if (num == 5) break;
                    }
                    else
                        if ((str[i] != '|') && (num == 0))
                        LastName += str[i];
                    else
                        if ((str[i] != '|') && (num == 1))
                        FirstName += str[i];
                    else
                        if ((str[i] != '|') && (num == 2))
                        Login += str[i];
                    else
                        if ((str[i] != '|') && (num == 3))
                        Email += str[i];
                    else
                        if ((str[i] != '|') && (num == 4))
                        PassWord += str[i];
                }
               
                Console.WriteLine("Відкриття бази даних");

                string database = ConfigurationManager.AppSettings["DB"];
                SqlConnection connect = new SqlConnection(database);
                connect.Open();

                string query = $"SELECT * FROM Users WHERE Логін = '{Login}' ";
                SqlCommand sql = new SqlCommand(query, connect);

                SqlDataReader reader = sql.ExecuteReader();
                bool cont = false;
                while (reader.Read())
                {
                    cont = true;
                }

                if (!cont)
                {
                    reader.Close();
                    N = count.ToString() + '|';
                    string reg = $"INSERT INTO Users([Прізвище],[Ім'я],[Логін],[E-mail],[Пароль]) VALUES('{LastName}','{FirstName}','{Login}','{Email}','{PassWord}')";
                    SqlCommand sql1 = new SqlCommand(reg, connect);
                    sql1.ExecuteNonQuery();
                    Console.WriteLine("\nВхідні дані: ");
                    Console.WriteLine($"{LastName} | {FirstName} | {Login} | {Email} | {PassWord}\n");

                    //Console.WriteLine("Надіслано повідомлення про успішну реєстрацію");

                }
                else
                {
                    Console.WriteLine("Надсилання повідомлення: Користувач з таким іменем вже існує");
                    Error = true;

                }
                Console.WriteLine("Закриття бази даних");
                connect.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            byte[] res;
            if (Error == true)
            {
                res = Encoding.UTF8.GetBytes("8");
                Console.Write("Помилка :");
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Реєстрація пройшла успішно ");
                res = Encoding.UTF8.GetBytes("1");
            }
            return res;
        }
        static byte[] GetActualTickets(String str)
        {
            //Отримання актуальних квитків
            String[] data = new String[40];
            String login = String.Empty;
            String N = "1";
            string str1 = string.Empty;
            bool Error = false;
            int count = 0;

            try
            {
                int num = 0;
                for (int i = 1; i < str.Length; i++)
                {
                   if (str[i] == '|')
                    {
                       num++;
                        if (num == 1) break;
                    }
                    else
                    if ((str[i] != '|') && (num == 0))
                       login += str[i];
                }
                Console.WriteLine($"Пошук актуальних квитків за логіном: {login}  ");
                if (login ==  String.Empty )
                   Error = true;
                Console.WriteLine("Відкриття бази даних");

                //string database = @"Data Source = DESKTOP-GB6LTE1;Initial Catalog=Booking;Integrated Security=True";
                string database = ConfigurationManager.AppSettings["DB"];
                SqlConnection connect = new SqlConnection(database);
                connect.Open();

                string tick = "exec sp_UpdateTicketsTime";
                SqlCommand syncho = new SqlCommand(tick, connect);
                SqlDataReader read = syncho.ExecuteReader();
                read.Close();

                string query = $"SELECT * FROM ActualTicket WHERE Логін = '{login}' ";
                SqlCommand sql = new SqlCommand(query, connect);

                SqlDataReader reader = sql.ExecuteReader();
                bool cont = false;
                while (reader.Read())
                {
                    cont = true;
                    Звідки = reader["Звідки"].ToString() + "|";
                    Куди = reader["Куди"].ToString() + "|";
                    Дата_Час = reader["Дата_Час"].ToString() + "|";
                    Номер_поїзда = reader["Номер_поїзда"].ToString() + '|';
                    Місце = reader["Місце"].ToString() + '|';
                    Вагон = reader["Вагон"].ToString() + '|';
                    Прізвище = reader["Прізвище"].ToString() + '|';
                    Імя = reader["Ім'я"].ToString() + '|';

                    data[count] = Звідки + Куди + Дата_Час + Номер_поїзда + Місце + Вагон + Прізвище + Імя;
                    count++;
                }
                reader.Close();
                N = count.ToString() + '|';

                if (!cont)
                {
                    Console.WriteLine("Актуальні квитки відсутні");
                    Error = true;
                }
                else
                {
                    Console.WriteLine("Дійсні квитки");
                    
                    for (int i = 0; i < count; i++)
                    {
                        string str2 =  String.Empty;
                        str2 += data[i];
                       Console.WriteLine($"{i+1}. {str2}");

                    }
                }

                Console.WriteLine("Закриття бази даних");
                connect.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            byte[] res;
            
            if (Error == true)
            {
                res = Encoding.UTF8.GetBytes("10");
                Console.Write("Помилка :");
                Console.WriteLine(res);
            }
            else
            {
                Console.Write("\nНадсилання вiдповiдi про наявні квитки\n");
               str1 += N;
               for (int i = 0; i < count; i++)
                    str1 += data[i];
                res = Encoding.UTF8.GetBytes(str1);
            }
            return res;
        }
        static byte[] GetUserHistory(String str)
        {
            //отримання історії замовлень
            String[] data = new String[100];
            String login = String.Empty;
            String N = String.Empty;
            string str1 = string.Empty;
            bool Error = false;
            int count = 0;

            try
            {
                int num = 0;
                for (int i = 1; i < str.Length; i++)
                {
                    if (str[i] == '|')
                    {
                        num++;
                        if (num == 1) break;
                    }
                    else
                     if ((str[i] != '|') && (num == 0))
                        login += str[i];
                }
                Console.WriteLine($"Отримання історії квитків за логіном: {login}  ");
                if (login == String.Empty)
                    Error = true;
                Console.WriteLine("Відкриття бази даних");

                string database = ConfigurationManager.AppSettings["DB"];
                SqlConnection connect = new SqlConnection(database);
                connect.Open();

                string tick = "exec sp_UpdateTicketsTime";
                SqlCommand syncho = new SqlCommand(tick, connect);
                SqlDataReader read = syncho.ExecuteReader();
                read.Close();

                string query = $"SELECT * FROM History WHERE Логін = '{login}' ";
                SqlCommand sql = new SqlCommand(query, connect);

                SqlDataReader reader = sql.ExecuteReader();
                bool cont = false;
                while (reader.Read())
                {
                    cont = true;
                    Звідки = reader["Звідки"].ToString() + "|";
                    Куди = reader["Куди"].ToString() + "|";
                    Дата_Час = reader["Дата_Час"].ToString() + "|";
                    Номер_поїзда = reader["Номер_поїзда"].ToString() + '|';
                    Місце = reader["Місце"].ToString() + '|';
                    Вагон = reader["Вагон"].ToString() + '|';
                    Прізвище = reader["Прізвище"].ToString() + '|';
                    Імя = reader["Ім'я"].ToString() + '|';

                    data[count] = Звідки + Куди + Дата_Час + Номер_поїзда + Місце + Вагон + Прізвище + Імя;
                    count++;
                }
                reader.Close();
                N = count.ToString() + '|';

                if (!cont)
                {
                    Console.WriteLine("Історія поїздок відсутня");
                    Error = true;
                }
                else
                {
                    Console.WriteLine("Історія поїздок:");

                    for (int i = 0; i < count; i++)
                    {
                        string str2 = String.Empty;
                        str2 += data[i];
                        Console.WriteLine($"{i + 1}. {str2}");

                    }
                }

                Console.WriteLine("Закриття бази даних");
                connect.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            byte[] res;

            if (Error == true)
            {
                res = Encoding.UTF8.GetBytes("9");
                Console.Write("Помилка :");
                Console.WriteLine(res);
            }
            else
            {
                Console.Write("\nНадсилання вiдповiдi про історію квитків\n");
                str1 += N;
                for (int i = 0; i < count; i++)
                    str1 += data[i];
                res = Encoding.UTF8.GetBytes(str1);
            }
            return res;
        }
        static byte[] SearchTickets(String str)
        {
            //Пошук квитків
            String[] data = new String[40];
            String Login = String.Empty;
            String N = String.Empty;
            String Вагонів = String.Empty;
            String Кількість_місць = String.Empty;
            Звідки = String.Empty;
            Куди = String.Empty;
            Дата_Час = String.Empty;
            bool Error = false;
            int count = 0;


            try
            {
                int num = 0;

                for (int i = 1; i < str.Length; i++)
                {
                    if (str[i] == '|')
                    {
                        num++;
                        if (num == 3) break;
                    }
                    else
                        if ((str[i] != '|') && (num == 0))
                        Звідки += str[i];
                    else if ((str[i] != '|') && (num == 1))
                        Куди += str[i];
                    else Дата_Час += str[i];
                }
                Console.WriteLine($"Пошук квитків із {Звідки} до {Куди} ");
                Console.WriteLine($"Дата відправлення: {Дата_Час}");
                if ((Звідки ==  String.Empty) || (Куди ==  String.Empty))
                    Error = true;

                Console.WriteLine("Відкриття бази даних");

                string database = ConfigurationManager.AppSettings["DB"];
                SqlConnection connect = new SqlConnection(database);
                connect.Open();
                string del = $"Delete from Train where Дата_Час < GETDATE()";
                SqlCommand dele = new SqlCommand(del, connect);
                dele.ExecuteNonQuery();


                string query = $"SELECT * FROM Train WHERE Звідки = '{Звідки}' AND Куди = '{Куди}' AND (SELECT DATEDIFF(day, Дата_Час, '{Дата_Час}')) = 0";
                SqlCommand sql = new SqlCommand(query, connect);

                SqlDataReader reader = sql.ExecuteReader();

                bool cont = false;
                while (reader.Read())
                {
                    cont = true;
                    Звідки = reader["Звідки"].ToString() + '|';
                    Куди = reader["Куди"].ToString() + '|';
                    Дата_Час = reader["Дата_Час"].ToString() +'|';
                    Номер_поїзда = reader["Номер_поїзда"].ToString() + '|';
                    Вагонів = reader["Вагонів"].ToString() + '|';
                    Кількість_місць = reader["Кількість_місць"].ToString() + '|';
                    data[count] = Звідки + Куди + Дата_Час + Номер_поїзда  + Вагонів + Кількість_місць ;
                    count++;
                }
                reader.Close();
                N = count.ToString() + '|';

                if (!cont)
                {
                    Console.WriteLine("За даними параметрами поїздів не знайдено");
                    Console.WriteLine("Відправлено повідомлення: На жаль, по заданому напрямку квитків не знайдено  ");
                    Error = true;
                }
                else
                {
                    Console.WriteLine("Доступні потяги");
                    for (int i = 0; i < count; i++)
                    {
                        string str2 = String.Empty;
                        str2 += data[i];
                        Console.WriteLine($"{i + 1}. {str2}");

                    }
                    //Console.WriteLine($"{count}.{Звідки}{Куди}{Дата_Час}{Номер_поїзда}{Вагонів}{Кількість_місць}");
                    //Console.WriteLine("Відправлено повідомлення про наявні потяги");
                }
                Console.WriteLine("Закриття бази даних");
                connect.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            byte[] res;
            string str1 = String.Empty;
            if (Error == true)
            {
                res = Encoding.UTF8.GetBytes("7");
                Console.Write("Помилка :");
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Пошук виконано");
                str1 += N;
                for (int i = 0; i < count; i++)
                    str1 += data[i];
                res = Encoding.UTF8.GetBytes(str1);
            }
            return res;
        }
        static byte[] SelectPlaceInTrain(String str)
        {
            //Вибір місця
            String[] data = new String[40];
            String N = String.Empty;
            String Вагонів = String.Empty;
            String Кількість_місць = String.Empty;
            Номер_поїзда = String.Empty;
            Звідки = String.Empty;
            Куди = String.Empty;
            Дата_Час = String.Empty;
            Місце = String.Empty;
            bool Error = false;
            int count = 0;

            try
            {
                int num = 0;
                for (int i = 1; i < str.Length; i++)
                {
                    if (str[i] == '|')
                    {
                        num++;
                        if (num == 6) break;
                    }
                    else
                        if ((str[i] != '|') && (num == 0))
                        Звідки += str[i];
                    else
                        if ((str[i] != '|') && (num == 1))
                        Куди += str[i];
                    else
                        if ((str[i] != '|') && (num == 2))
                        Дата_Час += str[i];
                    else
                        if ((str[i] != '|') && (num == 3))
                        Номер_поїзда += str[i];
                    else
                        if ((str[i] != '|') && (num == 4))
                        Вагонів += str[i];
                    else
                        if ((str[i] != '|') && (num == 5))
                    Кількість_місць += str[i];
                }
                Console.WriteLine($"Вибір місць поїзда № {Номер_поїзда} ");
                Console.WriteLine($"Сполучення: {Звідки} - {Куди}");
                Console.WriteLine($"Дата відправлення: {Дата_Час}");
                Console.WriteLine($"Кількість місць: {Кількість_місць}");
                Console.WriteLine($"Кількість вагонів: {Вагонів}");
                if ((Звідки == String.Empty) || (Куди == String.Empty) || (Дата_Час == String.Empty))
                    Error = true;

                Console.WriteLine("Відкриття бази даних");

                string database = ConfigurationManager.AppSettings["DB"];
                SqlConnection connect = new SqlConnection(database);
                connect.Open();

                string query = $"EXEC dbo.sp_GetPlaceInTrain @from = '{Звідки}', @to = '{Куди}', @date = '{Дата_Час}', @numTrain = '{Номер_поїзда}'";
                SqlCommand sql = new SqlCommand(query, connect);

                SqlDataReader reader = sql.ExecuteReader();

                while (reader.Read())
                {
                    Місце = reader["Місце"].ToString() + '|';
                    data[count] = Місце;
                    count++;
                }
                reader.Close();
                N = count.ToString() + '|';

                if (count == 40)
                {
                    Console.WriteLine("Доступних місць немає");
                    Console.WriteLine("Відправлено повідомлення: На жаль, всі місця зайняті");
                    Error = true;
                }
                else
                {
                    Console.WriteLine($"Вільних місць: {40-count} ");
                }
                Console.WriteLine("Закриття бази даних");
                connect.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            byte[] res;
            string str1 = String.Empty;
            if (Error == true)
            {
                res = Encoding.UTF8.GetBytes("41");
                Console.Write("Помилка :");
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Пошук виконано");
                str1 += N;
                for (int i = 0; i < count; i++)
                    str1 += data[i];
                res = Encoding.UTF8.GetBytes(str1);
            }
            return res;
        }
        static byte[] BookingTickets(String str)
        {
            //Бронювання квитків
            String[] data = new String[40];
            String N = String.Empty;
            String Логін = string.Empty;
            String Кількість_місць = String.Empty;
            String Вагонів = String.Empty;
            Номер_поїзда = String.Empty;
            Звідки = String.Empty;
            Куди = String.Empty;
            Дата_Час = String.Empty;
            Місце = String.Empty;
            bool Error = false;
            int count = 0;

            try
            {
                int num = 0;
                for (int i = 1; i < str.Length; i++)
                {
                    if (str[i] == '|')
                    {
                        num++;
                        if (num == 8) break;
                    }
                    else
                        if ((str[i] != '|') && (num == 0))
                        Логін += str[i];
                    else
                        if ((str[i] != '|') && (num == 1))
                        Звідки += str[i];
                    else
                        if ((str[i] != '|') && (num == 2))
                        Куди += str[i];
                    else
                        if ((str[i] != '|') && (num == 3))
                        Дата_Час += str[i];
                    else
                        if ((str[i] != '|') && (num == 4))
                        Номер_поїзда += str[i];
                    else
                        if ((str[i] != '|') && (num == 5))
                        Вагонів += str[i];
                    else
                        if ((str[i] != '|') && (num == 6))
                        Кількість_місць += str[i];
                    else
                        if ((str[i] != '|') && (num == 7))
                        Місце += str[i];


                }
                Console.WriteLine($"Купівля квитка на поїзд № {Номер_поїзда}  ");
                Console.WriteLine($"Сполучення: {Звідки} - {Куди}");
                Console.WriteLine($"Дата відправлення: {Дата_Час}");
                Console.WriteLine($"Вагон: {Вагонів}");
                Console.WriteLine($"Місце: {Місце}");
                Console.WriteLine($"Користувач: {Логін}");
                if ((Звідки == String.Empty) || (Куди == String.Empty) || (Дата_Час == String.Empty))
                    Error = true;

                Console.WriteLine("Відкриття бази даних");

                string database = ConfigurationManager.AppSettings["DB"];
                SqlConnection connect = new SqlConnection(database);
                connect.Open();

                string sel_name = $"select Прізвище, [Ім'я] from Users Where Логін = '{Логін}'";
                SqlCommand sel_n = new SqlCommand(sel_name, connect);
                SqlDataReader reade = sel_n.ExecuteReader();

                while (reade.Read())
                {
                    Прізвище = reade["Прізвище"].ToString();
                    Імя = reade["Ім'я"].ToString();

                }
                reade.Close();

                if (count == 40)
                {
                    Console.WriteLine("Доступних місць немає");
                    Console.WriteLine("Відправлено повідомлення: На жаль, всі місця зайняті");
                    Error = true;
                }
                else
                {
                    string query = $"exec sp_BookingTickets @from = '{Звідки}', @to = '{Куди}', @date = '{Дата_Час}', @numTrain = '{Номер_поїзда}',@Place = '{Місце}', @Vagon = '{1}', @Priz = '{Прізвище}', @Name = '{Імя}', @Log = '{Логін}'";
                    SqlCommand sql = new SqlCommand(query, connect);
                    sql.ExecuteNonQuery();
                    Console.WriteLine("\nІнформація про білет: ");
                    Console.WriteLine($"{Звідки} | {Куди} | {Дата_Час} | {Номер_поїзда} | {Місце} | {1} | {Прізвище} | {Імя} | {Логін}\n");
                    count++;
                    Console.WriteLine($"Вільних місць: {int.Parse(Кількість_місць) - count} ");
                }
                Console.WriteLine("Закриття бази даних");
                connect.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                Error = true;
            }

            byte[] res;
            string str1 = String.Empty;
            if (Error == true)
            {
                res = Encoding.UTF8.GetBytes("41");
                Console.Write("Помилка :");
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Реєстрація пройшла успішно ");
                res = Encoding.UTF8.GetBytes("1");
            }
            return res;
        }
    }
    
}
