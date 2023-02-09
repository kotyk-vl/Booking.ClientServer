using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace lab2

{
    public partial class Main_Form : Form

    {
        public Main_Form()
        {
            InitializeComponent();
        }
        
        public void visible()
        {
            
            button_tick.Visible = true;
            button_history.Visible = true;
            this.Show();

         }
      
        private void button_Search_Click(object sender, EventArgs e)
        {
            TicketsSearch sear = new TicketsSearch();
            sear.ShowDialog();
         

        }

        private void button_Log_Click(object sender, EventArgs e)
        {
            UserAuthorization frm = new UserAuthorization();
            frm.Show();
            this.Hide();
            
                       
        }

        private void button_tick_Click(object sender, EventArgs e)
        {
            TicketsActual tic = new TicketsActual();
           
            tic.ShowDialog();
            
        }

        private void button_history_Click(object sender, EventArgs e)
        {
            TicketsHistory his = new TicketsHistory();
            his.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TicketsBooking bok = new TicketsBooking();
            bok.Show();
        }
    }

}
