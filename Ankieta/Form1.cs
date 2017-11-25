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
using System.Text;

namespace Ankieta
{
    public partial class Form1 : Form
    {
        string curFile = "wyniki.txt";
        public Form1()
        {
            InitializeComponent();
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
            using (FileStream fs = File.Create(curFile))
            {
                AddText(fs, "This is some text");
                AddText(fs, "This is some more text,");
                AddText(fs, "\r\nand this is on a new line");
                AddText(fs, "\r\n\r\nThe following is a subset of characters:\r\n");

                for (int i = 1; i < 120; i++)
                {
                    AddText(fs, Convert.ToChar(i).ToString());

                }
            }
            for (int i = 1; i < 8; i++)
            {
                for (int a = 0; a < 4; a++)
                {

                }

            }
        }
        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }
}
