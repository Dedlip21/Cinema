using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace MinuVorm_RolanMasleniikov
{
    public partial class Film : Form
    {
        private int f1;
        private int f2;
        private int f3;

        Label label = new Label();


        PictureBox film = new PictureBox();


        Button[] btn = new Button[4];
        string[] texts = new string[4];

        public Film(int f1, int f2, int f3)
        {

            Image startImg = new Bitmap(@"..\..\img\movie-theatre.jpg");
            this.BackgroundImage = startImg;



            this.f1 = f1;
            this.f2 = f2;
            this.f3 = f3;

            Button film1_btn = new Button
            {
                Text = "Матрица 4",
                Location = new Point(10, 10),
                Size = new Size(100, 50)

        };
            film1_btn.Click += Film1_btn_Click;
            this.Controls.Add(film1_btn);


            Button film2_btn = new Button
            {
                Text = "Один дома",
                Location = new Point(150, 10),
                Size = new Size(100, 50)
            };
            film2_btn.Click += Film2_btn_Click;
            this.Controls.Add(film2_btn);


            Button film3_btn = new Button
            {
                Text = "Человек - Паук",
                Location = new Point(290, 10),
                Size = new Size(100, 50)
            };
            film3_btn.Click += Film3_btn_Click;
            this.Controls.Add(film3_btn);

            Button next_btn = new Button
            {
                Text = "Osta pilet",
                Location = new Point(150, 90),
                Size = new Size(70, 40)
            };
            next_btn.Click += Next_btn_Click;
            this.Controls.Add(next_btn);
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            MyForm uus_aken = new MyForm(8, 5);

            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }

        private void Film3_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ты выбрал фильм 'Человек - Паук'");
        }

        private void Film2_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ты выбрал фильм 'Один Дома'");
        }

        private void Film1_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ты выбрал фильм 'Матрица 4'");

            PictureBox picture = new PictureBox();
            picture.Location = new Point(450, 50);
            picture.Size = new Size(200, 300);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Image = Image.FromFile(@"..\..\img\matrix.jpg");
            this.Controls.Add(picture);
        }
    }
}
