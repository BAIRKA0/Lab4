using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }
        List<Movie> movieList = new List<Movie>();
        private void refill_button_Click(object sender, EventArgs e)
        {
            this.movieList.Clear();
            Random rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.movieList.Add(Film.Generate());
                        break;
                    case 1:
                        this.movieList.Add(Serial.Generate());
                        break;
                    case 2:
                        this.movieList.Add(TV.Generate());
                        break;
                }
            }
            ShowInfo();
        }

        private void get_button_Click(object sender, EventArgs e)
        {
            if (this.movieList.Count == 0)
            {
                richTextBox1.Text = "Пусто";
                return;
            }
            var movie = this.movieList[0];
            this.movieList.RemoveAt(0);
            richTextBox1.Text = movie.GetInfo();
            ShowInfo();
        }

        private void ShowInfo()
        {
            int film = 0;
            int serial = 0;
            int tv = 0;
            foreach (var movie in this.movieList)
            {
                if (movie is Film) 
                {
                    film += 1;
                }
                else if (movie is Serial)
                {
                    serial += 1;
                }
                else if (movie is TV)
                {
                    tv += 1;
                }
            }
            richTextBox2.Text = "Фильмы\tСериалы\tТВ";
            richTextBox2.Text += "\n";
            richTextBox2.Text += String.Format("{0}\t{1}\t{2}", film, serial, tv);
        }

        private void task_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для раздачи кино (рейтинг)\n" +
                "- Фильм (хронометраж, количество наград, тип (художественный, документальный и т.п.)) \n" +
                "- Сериал (общее количество серий, количество сезонов) \n" +
                "- Телепередача (продолжительность, эфирное время)");

        }
    }
}
