using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMApp.Resources
{
    public partial class MyMp3Player : Form
    {

        public MyMp3Player()
        {
            InitializeComponent();
        }

        String[] paths, files;

        private void MyMp3Player_Load(object sender, EventArgs e)
        {

        }  


        private void open_Click(object sender, EventArgs e)
        {
           OpenFileDialog ofd=  new OpenFileDialog();

            ofd.Multiselect= true;

            if(ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for (int i=0; i<files.Length;i++)
                {
                    listBox1.Items.Add(files[i]);
                }

            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void hidebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
