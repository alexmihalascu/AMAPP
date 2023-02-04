using AMApp.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void notepadButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClassyNTPD classyNTPD = new ClassyNTPD();
            classyNTPD.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TREXGAME trexgame = new TREXGAME();
            trexgame.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyMp3Player myMp3Player = new MyMp3Player();
            myMp3Player.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
