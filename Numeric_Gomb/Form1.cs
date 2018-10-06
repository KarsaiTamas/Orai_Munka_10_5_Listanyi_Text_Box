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

namespace Numeric_Gomb
{
    public partial class Form1 : Form
    {
          List<TextBox> szvegdoboz_lista = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Hozzaadas(object sender, EventArgs e)
        {
            int darab=(int)Sor_Szam.Value;
            for (int i = 0; i < darab; i++)
            {
                TextBox tb = new TextBox();
                tb.SetBounds(10, 50+i*25, 200, tb.Height);
                this.Controls.Add(tb);
                this.szvegdoboz_lista.Add(tb);
                Button b = new Button();
                b.SetBounds(230, 50 + i * 25, 75, tb.Height);
                b.Text = "Push me";
                this.Controls.Add(b);

                b.MouseUp += (sender1,args)=> {
                    if (args.Button == MouseButtons.Right) { 
                    MessageBox.Show("Tartalom:" + tb.Text);}
                    else if(args.Button == MouseButtons.Left)
                    {
                        MessageBox.Show("Balre");
                    }else if(args.Button == MouseButtons.Middle)
                    {
                        MessageBox.Show("Közepes");
                    }else if(args.Button == MouseButtons.XButton1)
                    {
                        MessageBox.Show("Alúvan");
                    }else if(args.Button == MouseButtons.XButton2)
                    {
                        MessageBox.Show("ALJÁBB VaN");
                    }
                };
                Button btorol = new Button();
                btorol.SetBounds(330, 50 + i * 25, 75, btorol.Height);
                btorol.Text = "Torles";
                btorol.Click += (sender1, args) =>
                {
                    szvegdoboz_lista.Remove(tb);
                    this.Controls.Remove(tb);
                    this.Controls.Remove(b);
                    this.Controls.Remove(btorol);
                };
                this.Controls.Add(btorol);
            }


        }

        private void Ha_Ez_Mindent_Kiir_Click(object sender, EventArgs e)
        {
            string szoveg = "";
            foreach (var item in this.szvegdoboz_lista)
            {
                szoveg += item.Text+"\n";
            }
            MessageBox.Show(szoveg);
            File.WriteAllText("kimenet.txt",szoveg);
        }
    }
}
