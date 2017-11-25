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

            using (FileStream fs = File.Create(curFile))
            {
                AddText(fs, "X.X.X$X..X$");
            }
            bool file = File.Exists(curFile);
            if (file)
            {
                // File.Delete(curFile);

                string pobrane = "";
                using (StreamReader sr = new StreamReader(curFile))
                {
                    pobrane = sr.ReadToEnd();
                }
                var perPytanie = pobrane.Split('$');
                for (int i = 1; i < 2; i++)
                {
                    var aktualnePytanie = perPytanie[i - 1].Split('.');
                    for (int a = 1; a < 4; a++)
                    {
                        var odp = aktualnePytanie[a - 1];
                        if (odp == "X")
                        {
                            changeControl(i.ToString(), a - 1,true);
                        }
                    }
                }
                File.Delete(curFile);
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
        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
        private void changeControl(string control, int value,bool check)
        {
            if (control == "1")
            {
                checkedListBox1.SetItemChecked(value,check);
            }
            if (control == "2")
            {
                checkedListBox1.SetItemChecked(value, check);
            }
            if (control == "3")
            {
                checkedListBox1.SetItemChecked(value, check);
            }
            if (control == "4")
            {
                checkedListBox1.SetItemChecked(value, check);
            }
            if (control == "5")
            {
                checkedListBox1.SetItemChecked(value, check);
            }
            if (control == "6")
            {
                checkedListBox1.SetItemChecked(value, check);
            }
            if (control == "7")
            {
                checkedListBox1.SetItemChecked(value, check);
            }
        }

        private void clearALL()
        {
            for (int i = 0; i < 8; i++)
            {

            }
        }
    }
}
