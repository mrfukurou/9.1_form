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

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void rec_Click(object sender, EventArgs e)
        {
            try
            {
                string abc = "";
                string fileName = way.Text;
                string s = stroka.Text;
                FileStream f = new FileStream(fileName, FileMode.Create);
                BinaryWriter fOut = new BinaryWriter(f);
                fOut.Write(s);
                fOut.Close();

                f = new FileStream(fileName, FileMode.Open);
                BinaryReader fIn = new BinaryReader(f);
                while (fIn.PeekChar() > 0)
                {
                    abc = fIn.ReadString();
                    alltxt.Items.Add(abc);
                }
                fIn.Close();
            }
            catch { rez.Items.Add("Данные не были записаны. Введите путь к файлу!"); }
        
        }

    

        private void find_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "";
                int a = 0;
                string abc = "";
                string fileName = way.Text;

                FileStream f = new FileStream(fileName, FileMode.Open);
                BinaryReader fIn = new BinaryReader(f);
                char b = Convert.ToChar(bkv.Text);

                while (fIn.PeekChar() > 0)
                {
                    abc = Convert.ToString(fIn.ReadString());
                }
                var text = abc.ToLower().Split(new[] { ' ', '.', ',', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < text.Length; ++i)
                        {
                            if (text[i][0] == b)
                            {
                                str += (text[i] + " ");
                                a = 1;
                            }
                        }

                    if (a == 1)
                        rez.Items.Add(str);
                    else rez.Items.Add("Такие слова отсутствуют!");
                fIn.Close();
            }
            catch
            {
                rez.Items.Add("Некорректный ввод!");
                rez.Items.Add("\nВведите букву для осуществления поиска.");
            }
            
        }

        private void clr_Click(object sender, EventArgs e)
        {
            rez.Items.Clear();
            alltxt.Items.Clear();
            way.Clear();
            bkv.Clear();
            stroka.Clear();
        }
    }
}
