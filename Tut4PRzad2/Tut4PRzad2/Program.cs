using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tut4PRzad1
{
    class Program
    {

        public class BankovniRačun
        {
            private int brojBankovnogRačuna;
            private string imeKlijenta;
            private string prezimeKlijenta;
            private string jMBGKlijenta;
            private string brojLičneKarteKlijenta;
            private string adresaKlijenta;
            private int poštanskiBrojKlijenta;
            private string mjestoKlijenta;

            public BankovniRačun(int brojBankovnogRačuna, string imeKlijenta, string prezimeKlijenta, string jMBGKlijenta, string brojLičneKarteKlijenta, string adresaKlijenta, int poštanskiBrojKlijenta, string mjestoKlijenta)
            {
                this.brojBankovnogRačuna = brojBankovnogRačuna;
                this.imeKlijenta = imeKlijenta;
                this.prezimeKlijenta = prezimeKlijenta;
                this.jMBGKlijenta = jMBGKlijenta;
                this.brojLičneKarteKlijenta = brojLičneKarteKlijenta;
                this.adresaKlijenta = adresaKlijenta;
                this.poštanskiBrojKlijenta = poštanskiBrojKlijenta;
                this.mjestoKlijenta = mjestoKlijenta;
            }

            public void ispiši()
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", brojBankovnogRačuna, imeKlijenta, prezimeKlijenta, jMBGKlijenta, brojLičneKarteKlijenta, adresaKlijenta, poštanskiBrojKlijenta, mjestoKlijenta);
            }
        }
    



    private static List<BankovniRačun> bankovniRačuni = new List<BankovniRačun>();
        private static Form form;
        private static NumericUpDown numericUpDown1;
        private static TextBox textBox1;
        private static TextBox textBox2;
        private static TextBox textBox3;
        private static TextBox textBox4;
        private static TextBox textBox5;
        private static NumericUpDown numericUpDown2;
        private static ComboBox comboBox1;

        static void Main(string[] args)
        {

            form = new Form();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Size = new Size(240, 520);
            form.MaximumSize = form.Size;
            form.MinimumSize = form.Size;
            form.MaximizeBox = false;
          //  form.Icon = Properties.Resources.Banka;
            form.Text = "Bankovni račun";
            form.BackColor = Color.White;
            form.ForeColor = Color.Black;
            form.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
            form.Padding = new Padding(5, 5, 5, 5);

            GroupBox groupBox = new GroupBox();
            groupBox.Dock = DockStyle.Fill;
            groupBox.Text = "Podaci bankovnog računa";
            form.Controls.Add(groupBox);

            Label label1 = new Label();
            label1.Size = new Size(195, 25);
            label1.Text = "Broj bankovnog računa:";
            label1.Location = new Point(5, 25);
            groupBox.Controls.Add(label1);

            numericUpDown1 = new NumericUpDown();
            numericUpDown1.Size = new Size(195, 25);
            numericUpDown1.Location = new Point(10, 50);
            groupBox.Controls.Add(numericUpDown1);

            Label label2 = new Label();
            label2.Size = new Size(195, 25);
            label2.Text = "Ime klijenta:";
            label2.Location = new Point(5, 75);
            groupBox.Controls.Add(label2);

            textBox1 = new TextBox();
            textBox1.Size = new Size(195, 25);
            textBox1.Location = new Point(10, 100);
            groupBox.Controls.Add(textBox1);

            Label label3 = new Label();
            label3.Size = new Size(195, 25);
            label3.Text = "Prezime klijenta:";
            label3.Location = new Point(5, 125);
            groupBox.Controls.Add(label3);

            textBox2 = new TextBox();
            textBox2.Size = new Size(195, 25);
            textBox2.Location = new Point(10, 150);
            groupBox.Controls.Add(textBox2);

            Label label4 = new Label();
            label4.Size = new Size(195, 25);
            label4.Text = "JMBG klijenta:";
            label4.Location = new Point(5, 175);
            groupBox.Controls.Add(label4);

            textBox3 = new TextBox();
            textBox3.Size = new Size(195, 25);
            textBox3.Location = new Point(10, 200);
            groupBox.Controls.Add(textBox3);

            Label label5 = new Label();
            label5.Size = new Size(195, 25);
            label5.Text = "Broj lične karte klijenta:";
            label5.Location = new Point(5, 225);
            groupBox.Controls.Add(label5);

            textBox4 = new TextBox();
            textBox4.Size = new Size(195, 25);
            textBox4.Location = new Point(10, 250);
            groupBox.Controls.Add(textBox4);

            Label label6 = new Label();
            label6.Size = new Size(195, 25);
            label6.Text = "Adresa klijenta:";
            label6.Location = new Point(5, 275);
            groupBox.Controls.Add(label6);

            textBox5 = new TextBox();
            textBox5.Size = new Size(195, 25);
            textBox5.Location = new Point(10, 300);
            groupBox.Controls.Add(textBox5);

            Label label7 = new Label();
            label7.Size = new Size(195, 25);
            label7.Text = "Poštanski broj klijenta:";
            label7.Location = new Point(5, 325);
            groupBox.Controls.Add(label7);

            numericUpDown2 = new NumericUpDown();
            numericUpDown2.Size = new Size(195, 25);
            numericUpDown2.Location = new Point(10, 350);
            groupBox.Controls.Add(numericUpDown2);

            Label label8 = new Label();
            label8.Size = new Size(195, 25);
            label8.Text = "Mjesto klijenta:";
            label8.Location = new Point(5, 375);
            groupBox.Controls.Add(label8);

            comboBox1 = new ComboBox();
            comboBox1.Size = new Size(195, 25);
            comboBox1.Location = new Point(10, 400);
            comboBox1.Items.AddRange(new string[] { "Sarajevo", "Banja Luka", "Tuzla", "Mostar", "Zenica" });
            groupBox.Controls.Add(comboBox1);

            Button button1 = new Button();
            button1.Size = new Size(95, 25);
            button1.Location = new Point(10, 435);
            button1.Text = "Dodaj";
            button1.BackColor = Color.LightGray;
            button1.Click += new EventHandler(klikNaDugmeDodaj);
            groupBox.Controls.Add(button1);

            Button button2 = new Button();
            button2.Size = new Size(95, 25);
            button2.Location = new Point(110, 435);
            button2.BackColor = Color.LightGray;
            button2.Text = "Zatvori";
            button2.Click += new EventHandler(klikNaDugmeZatvori);
            groupBox.Controls.Add(button2);

            Application.Run(form);

            Console.ReadLine();
        }

        static void klikNaDugmeDodaj(object sender, EventArgs e)
        {
            bankovniRačuni.Add(new BankovniRačun(Convert.ToInt32(numericUpDown1.Value), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, Convert.ToInt32(numericUpDown2.Value), comboBox1.Text));
            MessageBox.Show("Bankovni račun je uspješno dodan.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        static void klikNaDugmeZatvori(object sender, EventArgs e)
        {
            form.Close();
            Console.WriteLine("Broj bankovnog računa Ime klijenta Prezime klijenta JMBG klijenta Broj lične karte klijenta Adresa klijenta Poštanski broj klijenta Mjesto klijenta");
            foreach (BankovniRačun bankovniRačun in bankovniRačuni)
            {
                bankovniRačun.ispiši();
            }
        }
    }
}