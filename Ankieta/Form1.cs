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

namespace Ankieta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string curFile = "wyniki.txt";
            bool file = File.Exists(curFile);
            if (file)
            {
                string pobrane = "";
                using (StreamReader sr = new StreamReader(curFile))
                {
                    pobrane = sr.ReadToEnd();
                }
                var perPytanie = pobrane.Split('$');
                for (int i = 1; i < 8; i++)
                    {
                    var aktualnePytanie = perPytanie[i-1];
                        for (int a = 1; a < 4; a++)
                        {
                           
                        }

                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 8; i++)
            {
                for (int a = 0; a < 4; a++)
                {

                }

            }
        }
    }
}
