using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {

            Angle angle1 = new Angle(360, 70, 78);           
            angle1.ToRadians();
            Console.ReadKey();

        }


        class Angle
        {

            public int gradus;
            public int min { get; set; } = 0;
            public int sec { get; set; } = 0;


            public int Gradus
            {
                set
                {
                    if(value < 0 || value > 360)
                    {
                        Console.WriteLine("Введите градусы в диапазоне от 0 до 360");                                                
                    }
                    else { gradus = value; }
                }
                get
                { return gradus; }
            }
            public int Min
            {
                set 
                { if(value < 0 || value > 60)
                    {
                        Console.WriteLine("Введите минуты в диапазоне от 0 до 60");
                    }
                    else { min = value; }
                }
                get
                { return min; }
            }
            public int Sec
            {
                set
                {
                    if (value < 0 || value > 60)
                    {
                        Console.WriteLine("Введите секунды в диапазоне от 0 до 60");
                    }
                    else { sec = value; }
                }
                get
                { return sec; }
            }

            public Angle(int gradus,int min,int sec)
            {
                Gradus = gradus;
                Min = min;
                Sec = sec;

            }

            public void ToRadians()
            {
                double gradDecimal;
                gradDecimal=Convert.ToDouble(gradus + ((Min + Sec / 60) / 60));
                Console.WriteLine("{0:0.00} рад",gradDecimal * (Math.PI / 180)); 
            }



        }









    }





}
