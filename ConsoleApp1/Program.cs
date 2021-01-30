using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = DateTime.Now;
            double k = date1.Second;
            double allmin = date1.Hour * 60 + date1.Minute + k / 60;
int fff;
            int ch = (int)(allmin / 78);

            double r = allmin - ch * 78;
            int d = (int)(r / 7.8);

            double r1 = r - d * 7.8;
            int dol = (int)(r1 / 0.78);
            double r2 = r1 - dol * 0.78;
            int vzdox = (int)(r2 / 0.078);

            Time(ch, d, dol, vzdox);

        }

        static double Time(int ch, int d, int dol, int vzdox)
        {
            while (ch < 20)
            {
                while (d < 10)
                {
                    while (dol < 10)
                    {
                        while (vzdox < 10)
                        {
                            i
                            System.Threading.Thread.Sleep(4700);
                            Console.Clear();
                            Console.WriteLine($"{ch}ч {d}д {dol}дл {vzdox}вз");
                            
                            vzdox++;
                        }
                        dol++;
                        vzdox = 0;
                    }
                    d++;
                    dol = 0;

                }
                ch++;
                d = 0;

            }

            return Time(0, 0, 0, 0);
        }
    }
}
