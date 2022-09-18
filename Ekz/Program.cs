using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ekz
{
    class Program
    {
        static void Main(string[] args)
        {
          
            double min_lengh = 3960;
            double max_lengh = 4040;
            Console.WriteLine("Выбери тип трубы\n" +
                "1 pn10\n" +
                "2 pn16\n" +
                "3 pn20\n" +
                "4 pn25 ");
            int Trubes = int.Parse(Console.ReadLine());
            int outer_diametr=int.Parse(Console.ReadLine());

            double mass_NonArmor;
            double mass_Armor;


            double ready_detail;
            double thick_wall;
            
            double crav1;
            double crav2;
            Outer_diametr outer = new Outer_diametr();
            switch (Trubes)
            {
                case 1 :
                    Console.WriteLine("PN10");
                    if(outer_diametr==20)
                    {
                        thick_wall = Double.Parse(Console.ReadLine());
                        crav1 = outer_diametr / 100 * outer.min_proc[0];
                        crav2 = outer_diametr / 100 * outer.max_proc[0];
                        if(thick_wall>=crav1 && thick_wall <= crav2)
                        {
                            Console.WriteLine("ВСЁ КРУТА");
                        }
                        else
                        {
                            Console.WriteLine("не крута");
                        }
                    }
                    else if(outer_diametr == 25)
                    {
                        thick_wall = Double.Parse(Console.ReadLine());
                        crav1 = outer_diametr / 100 * outer.min_proc[0];
                        crav2 = outer_diametr / 100 * outer.max_proc[0];
                        if (thick_wall >= crav1 && thick_wall <= crav2)
                        {
                            Console.WriteLine("ВСЁ КРУТА");
                        }
                        else
                        {
                            Console.WriteLine("не крута");
                        }
                    }
                    else if (outer_diametr == 32)
                    {
                        thick_wall = Double.Parse(Console.ReadLine());
                        crav1 = outer_diametr / 100 * outer.min_proc[0];
                        crav2 = outer_diametr / 100 * outer.max_proc[0];
                        if (thick_wall >= crav1 && thick_wall <= crav2)
                        {
                            Console.WriteLine("ВСЁ КРУТА");
                        }
                        else
                        {
                            Console.WriteLine("не крута");
                        }
                    }
                    else if (outer_diametr == 40)
                    {
                        thick_wall = Double.Parse(Console.ReadLine());
                        crav1 = outer_diametr / 100 * outer.min_proc[0];
                        crav2 = outer_diametr / 100 * outer.max_proc[0];
                        if (thick_wall >= crav1 && thick_wall <= crav2)
                        {
                            Console.WriteLine("ВСЁ КРУТА");
                        }
                        else
                        {
                            Console.WriteLine("не крута");
                        }
                    }
                    else if (outer_diametr == 50)
                    {
                        thick_wall = Double.Parse(Console.ReadLine());
                        crav1 = outer_diametr / 100 * outer.min_proc[0];
                        crav2 = outer_diametr / 100 * outer.max_proc[0];
                        if (thick_wall >= crav1 && thick_wall <= crav2)
                        {
                            Console.WriteLine("ВСЁ КРУТА");
                        }
                        else
                        {
                            Console.WriteLine("не крута");
                        }
                    }
                    else if (outer_diametr == 63)
                    {
                        thick_wall = Double.Parse(Console.ReadLine());
                        crav1 = outer_diametr / 100 * outer.min_proc[0];
                        crav2 = outer_diametr / 100 * outer.max_proc[0];
                        if (thick_wall >= crav1 && thick_wall <= crav2)
                        {
                            Console.WriteLine("ВСЁ КРУТА");
                        }
                        else
                        {
                            Console.WriteLine("не крута");
                        }
                    } 
                    break;
                    
                case 2:
              
                      Console.WriteLine("PN16 (Аромированная) ");
                    
                    break;
                   
                case 3:
                    Console.WriteLine("PN20");
                    break;
                   
                case 4:
                    Console.WriteLine("PN25");
                    break;
            
            }
            double lengh = Double.Parse(Console.ReadLine());


        
           

            TextWriterTraceListener[] listeners = new TextWriterTraceListener[] {
            new TextWriterTraceListener(@"D:\1.txt"),  // указать путь
            new TextWriterTraceListener(Console.Out)};
            Debug.Listeners.AddRange(listeners);
            Debug.WriteLine("Ошибка"); // то что пишет в файл и в консоль
            Debug.Flush();
            Console.Read();
        }

        public class Outer_diametr
            {
        public double[] min_proc = new double[] {10,13.5,16.5};
        public double[] max_proc = new double[] {11, 14, 17};
            }
        public class Trubes
        {

        }

    }
}
