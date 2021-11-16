using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Movie
    {
        public static Random rnd = new Random();
        public int time;
        public virtual String GetInfo()
        {
            return "Кино";
        }
    }
    
    
    public enum Ganre { Action, Comedy, Romance, Documentary };
    public class Film : Movie
    {
        static String[] type = new String[] { "Боевик", "Исторический", "Драма", "Кинокомикс", "Документальный", "Фантастика" };
        static String[] films = new String[] { "Железный человек","Оно","Капитан америка","Мстители","Время","Вечные" };
        int awards = 0;
        String g = type[0];
        String name = films[0];
        public override String GetInfo()
        {
            String str = "Фильм";
            str = str + "\nНазвание: "+name;
            str = str + "\nХронометраж: "+time+" минут";
            str = str + "\nНаград: " + awards;
            str = str + "\nТип(Жанр): " + g;
            return str;
        }
        public static Film Generate()
        {
            return new Film
            {
                time = rnd.Next(90, 150),
                awards = rnd.Next(0,5),
                g = type[rnd.Next(0, 6)],
                name = films[rnd.Next(0, 6)]
            };
        }
    }

    public class Serial : Movie 
    {
        static String[] serials = new String[] { "Острые козырьки", "Пацаны", "Игра пристолов", "Во все тяжкие", "Бумажный дом", "Ведьмак" };
        public int series = 0;
        public int seasons = 0;
        String name = serials[0];
        public override String GetInfo()
        {
            String str = "Сериал";
            str = str + "\nНазвание: " + name;
            str = str + "\nХронометраж: " + time + " минут";
            str = str + "\nСерий: " + series;
            str = str + "\nСезонов: "+seasons;
            return str;
        }
        public static Serial Generate()
        {
            return new Serial
            {
                series = rnd.Next(2, 24),
                seasons = rnd.Next(1, 10),
                time = rnd.Next(24, 60),
                name = serials[rnd.Next(0, 6)]
            };
        }
    }

    public class TV : Movie
    {
        static String[] tvs = new String[] { "Ревизорро", "На ножах", "Жди меня", "Пацанки", "Давай поженимся", "Кондитер" };
        public int timeH = 0;
        public int timeM = 0;
        String name = tvs[0];
        public override String GetInfo()
        {
            String str = "Телепередача";
            str = str + "\nНазвание: " + name;
            str = str + "\nХронометраж: " + time + " минут";
            str = str + "\nЭфирное время: "+timeH+":"+timeM;
            return str;
        }
        public static TV Generate()
        {
            return new TV
            {
                timeH = rnd.Next(0, 23),
                timeM = rnd.Next(0, 59),
                time = rnd.Next(30, 50),
                name = tvs[rnd.Next(0, 6)]
            };
        }
    }
}
