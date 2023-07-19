using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDailyExercise01
{
    public delegate void CalDel();
    internal class Program
    {
        static int energyL = 1;
        static int winP = 100;
        public static void Fs()
        {
            energyL += 1;
            winP += 100;
        }
        public static void Ss()
        {
            energyL += 2;
            winP += 20;
        }
        public static void Ts()
        {
            energyL -= 3;
            winP -= 30;
        }

        public static void Fos()
        {
            energyL += 4;
            winP += 40;
        }

        public static void Fis()
        {
            energyL -= 5;
            winP -= 50;
        }

        public static void Sis()
        {
            energyL -= 1;
            winP += 40;
        }

        public static void Ses()
        {
            energyL += 1;
            winP += 70;
        }

        public static void Es()
        {
            energyL -= 2;
            winP -= 20;
        }

        public static void Ns()
        {
            energyL -= 3;
            winP -= 30;
        }

        public static void Tes()
        {
            energyL += 10;
            winP += 100;
        }
        static void Main(string[] args)
        {
            int ln;

            CalDel cl;
            for(int i = 0; i<5; i++)
            {
                Console.WriteLine("Enter your lucky no. from 1 to 10...");
                ln = int.Parse(Console.ReadLine());
                if(ln<=0 && ln > 10)
                {
                    Console.WriteLine("Invalid no. pls try again!");
                    return;
                }
                else
                {
                    switch (ln)
                    {
                        case 1:
                            {
                                cl = new CalDel(Fs);
                                break;
                            }
                        case 2:
                            {
                                cl = new CalDel(Ss);
                                break;
                            }
                        case 3:
                            {
                                cl = new CalDel(Ts);
                                break;
                            }
                        case 4:
                            {
                                cl = new CalDel(Fos);
                                break;
                            }
                        case 5:
                            {
                                cl = new CalDel(Fis);
                                break;
                            }
                        case 6:
                            {
                                cl = new CalDel(Sis);
                                break;
                            }
                        case 7:
                            {
                                cl = new CalDel(Ses);
                                break;
                            }
                        case 8:
                            {
                                cl = new CalDel(Es);
                                break;
                            }
                        case 9:
                            {
                                cl = new CalDel(Ns);
                                break;
                            }
                        case 10:
                            {
                                cl = new CalDel(Tes);
                                break;
                            }
                    }  
                    
                }
            }
            if(energyL>=4 && winP > 60)
            {
                Console.WriteLine("You win!");
            }
            else if(energyL>=1 && winP > 50) 
            {
                Console.WriteLine("Your are runner up!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
            Console.ReadKey();
        }
    }
}
