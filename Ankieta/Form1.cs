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
                // File.Delete(curFile);

                string pobrane = "";
                using (StreamReader sr = new StreamReader(curFile))
                {
                    pobrane = sr.ReadToEnd();
                }
                var perPytanie = pobrane.Split('$');
                for (int i = 1; i < 8; i++)
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
                //File.Delete(curFile);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FileStream fs = File.Create(curFile))
            {
                for (int i = 1; i < 8; i++)
                {
                    for (int a = 0; a < 3; a++)
                    {
                        bool zaznacz = getChecked(i.ToString(), a);
                        if (zaznacz)
                            if (a != 2) AddText(fs, "X.");
                            else AddText(fs, "X");
                        else
                            if (a != 2)AddText(fs, ".");
                    }
                    AddText(fs, "$");
                }
            }
            this.Close();
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
                checkedListBox2.SetItemChecked(value, check);
            }
            if (control == "3")
            {
                checkedListBox3.SetItemChecked(value, check);
            }
            if (control == "4")
            {
                checkedListBox4.SetItemChecked(value, check);
            }
            if (control == "5")
            {
                checkedListBox5.SetItemChecked(value, check);
            }
            if (control == "6")
            {
                checkedListBox6.SetItemChecked(value, check);
            }
            if (control == "7")
            {
                checkedListBox7.SetItemChecked(value, check);
            }
        }

        private bool getChecked(string pyt, int odp)
        {
            bool value = false;

            if (pyt == "1")
            {
               value = checkedListBox1.GetItemChecked(odp);
            }
            if (pyt == "2")
            {
                value = checkedListBox2.GetItemChecked(odp);
            }
            if (pyt == "3")
            {
                value = checkedListBox3.GetItemChecked(odp);
            }
            if (pyt == "4")
            {
                value = checkedListBox4.GetItemChecked(odp);
            }
            if (pyt == "5")
            {
                value = checkedListBox5.GetItemChecked(odp);
            }
            if (pyt == "6")
            {
                value = checkedListBox6.GetItemChecked(odp);
            }
            if (pyt == "7")
            {
                value = checkedListBox7.GetItemChecked(odp);
            }
            return value;
        }

        private void clearALL()
        {
            for (int i = 1; i < 2; i++)
            {
                for (int a = 1; a < 4; a++)
                {
                        changeControl(i.ToString(), a - 1, false);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearALL();
        }
    }
}
