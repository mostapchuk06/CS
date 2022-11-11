using System;

namespace Timer_11_11
{
    class Time
    {
        public int hh;
        public int mm;
        public int ss;

        public Time()
        {
            hh = 0; mm = 0; ss = 0;
        }
        public Time(int hours, int minutes, int seconds)
        {
            this.hh = hours;
            this.mm = minutes;
            this.ss = seconds;
        }

        public void Show()
        {
            Console.WriteLine($"Time::  {hh}:{mm}:{ss}");
        }

        public void ExactTime()
        {
            this.hh = DateTime.Now.Hour;
            this.mm = DateTime.Now.Minute;
            this.ss = DateTime.Now.Second;
        }

        public static Time operator ++(Time t)
        {
            t.ss += 1;
            return t;
        }
        public static Time operator --(Time t)
        {
            t.ss -= 1;
            return t;
        }

        public static bool operator >(Time l, Time r)
        {
            return l.hh > r.hh;
        }
        public static bool operator <(Time l, Time r)
        {
            return !(l > r);
        }
        public static bool operator >=(Time l, Time r)
        {
            return l.hh >= r.hh;
        }
        public static bool operator <=(Time l, Time r)
        {
            return !(l >= r);
        }
        public static bool operator ==(Time l, Time r)
        {
            return l.hh == r.hh;
        }
        public static bool operator !=(Time l, Time r)
        {
            return !(l == r);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time();
            t1.Show();
            t1.ExactTime();
            t1.Show();
        }
    }
}