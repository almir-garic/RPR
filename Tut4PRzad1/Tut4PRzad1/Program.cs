using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

//autor : Almir Garic (almir.garic.1992@ieee.org)

/*Kreirati konzolnu aplikaciju koja prilikom pokretanja prikazuje formu Bankovnog racuna*/

namespace Tut4PRzad1
{
    class Program
    {
        static void Main(string[] args)
        {
            //kreiranje forme
            Form form = new Form();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Size = new Size(240, 520);
            form.MaximumSize = form.Size;
            form.MaximizeBox = false;
            //form.Icon=Properties.Resourses.Banka;
            form.Text = "Bankovni racun";
            form.BackColor = Color.White;
            form.ForeColor = Color.Black;
            form.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
            form.Padding = new Padding(5, 5, 5, 5);

            //kreiranje group-boxa;
            GroupBox groupBox = new GroupBox();
            groupBox.Dock = DockStyle.Fill;
            groupBox.Text = "Podaci bankovnog racuna";
            form.Controls.Add(groupBox); //dodajem form-i
            
            //kreiranje labele
            Label L1 = new Label();
            L1.Size = new Size(195, 25);
            L1.Text = "Broj Bankovnog racuna :";
            L1.Location = new Point(5, 25);
            groupBox.Controls.Add(L1); //dodajem groubox-u

            //Kreiranje Numericcupdowna
            NumericUpDown numericUpDown1 = new NumericUpDown();
            numericUpDown1.Size = new Size(195, 25);
            numericUpDown1.Size = new Size(10, 50);
            groupBox.Controls.Add(numericUpDown1); //dodajemo groupbox-u

            //kreiranje textbox-a
            TextBox textbox1 = new TextBox();
            textbox1.Size = new Size(195, 25);
            textbox1.Location = new Point(10, 100);
            groupBox.Controls.Add(textbox1);//dodajem groupbox-u

            //kreiranje combobox-a
            ComboBox combobox1 = new ComboBox();
            combobox1.Size = new Size(195, 25);
            combobox1.Location = new Point(10, 400);
            combobox1.Items.AddRange(new string[] { "Sarajevo", "BanjaLuka", "Tuzla", "Zenica","Mostar" });
            groupBox.Controls.Add(combobox1);//dodajem groupbox-u

            //kreiranje button-a
            Button button1 = new Button();
            button1.Size = new Size(195, 25);
            button1.Location = new Point(10, 435);
            button1.Text = "dodaj";
            button1.BackColor = Color.LightGray;
            groupBox.Controls.Add(button1);


            Application.Run(form);



            

        }
    }
}
