using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace c_sharp3
{
    class Program
    {
        private static int y;
        private static int h;
        private static int m;
        private static int w;

        public static string line { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Lab3 c# done by David SHylyuk,IS-73\nProject was successfully created");
            //***************Using overloaded operators*****************//

            Console.WriteLine("\nDemonstration of using overloaded operators:\n");
            int test_qual; string test_line;
            Console.WriteLine("Creating 3 workers: ");
              List<hand_worker> testing_workers = new List<hand_worker>();
            for (int i = 0; i < 3;i++ )
            {
                Console.WriteLine("\nEnter value of qualification for worker#{0} - ", i+1);  test_line = Console.ReadLine();   test_qual = int.Parse(test_line);
               testing_workers.Add(new hand_worker(i,test_qual));
            }
            Console.WriteLine("\nUpdating(increasing by 1) qualification for worker 1 and 3 - "); testing_workers[0]++; testing_workers[2]++;
            Console.WriteLine("Now qualification of workers#1 = {0}, worker#2 = {1}, worker#3 = {2}.", testing_workers[0].Qualification, testing_workers[1].Qualification, testing_workers[2].Qualification);

            Console.WriteLine("\nNext example:\nCreating 3 tecnicians, first has work experience - 3years , second: 2years , third: 3years. ");
            List<tecnique> testing_tecs = new List<tecnique>(); testing_tecs.Add(new tecnique(3)); testing_tecs.Add(new tecnique(2)); testing_tecs.Add(new tecnique(3)); 
            if (testing_tecs[0] == testing_tecs[2])             
                Console.WriteLine("\nTecnician#1 has the same experience as tecnician#3");
            if (testing_tecs[0] != testing_tecs[1])             //перевантаження оператора порівняння(заперечення)
                Console.WriteLine("\nTecnician#1 has different work experience from tecnician#2");
            if (testing_tecs[0] > testing_tecs[1])
            {
                Console.WriteLine("\nTecnician#1 has bigger work experience than tecnician#2");

            }
            Console.WriteLine("\nNext example:\nCreating conveyer_line: "); conveyer_line cv = new conveyer_line();
            Console.WriteLine("Enter equipment condition of line(0<c<10) - "); line = Console.ReadLine(); cv.Eqiupment_stat = int.Parse(line);
            cv--;
            Console.WriteLine("There was some break down on this line and its state became horrible(equipment_state now = {0})",cv.Eqiupment_stat);
            Console.WriteLine("\nFinish....\nPress something to start main program...");
                Console.ReadLine(); Console.Clear();
                //********************Starting main program************************//
                Console.WriteLine("Starting program...\nEnter general info about your enterprise:\n");
            float a; int b, c;

             
                Console.WriteLine("Enter number of deparments(for example 2) - ");
                line = Console.ReadLine();
                b = int.Parse(line);

                Console.WriteLine("Enter number of products(for example 3) - ");
                line = Console.ReadLine();
                c = int.Parse(line);

                Console.WriteLine("Enter power productivity of enteprise(for example 320.2) - ");
                line = Console.ReadLine();
                a = float.Parse(line);

            enterprise d = new enterprise(a, b, c, true);
                Console.WriteLine("\nYour created enterprise: name-{0}, num_departs-{1}, num_products-{2},power_produc-{3}.\nFinished creating enterprise....\nPress something....",d.Name,d.Num_depart,d.Number_product,d.Productivity_pow);
            Console.ReadLine(); Console.Clear();

            Console.WriteLine("Now u should describe your enterprise: \nNotice:DONT enter big value for 'conveyer_lines' and 'departments', because u need to describe every department and its lines(so it will take too much time to test program). ");

           

            for (int i = 0;i<d.Num_depart;i++)
            {
                Console.WriteLine("Department{0}:\nEnter name of department #{1} - ",i,i); d.departs[0].Name = Console.ReadLine();
                Console.WriteLine("Enter number_lines of department #{0} - ", i); line = Console.ReadLine(); d.departs[0].Number_lines = int.Parse(line);
               // Console.WriteLine(int.Parse(line));
                Console.WriteLine("Enter number of workers of department #{0} - ", i); line = Console.ReadLine(); d.departs[0].Number_workers = int.Parse(line);
                //Console.WriteLine( int.Parse(line));
        Console.WriteLine("Enter number_tecnics of department #{0} - ", i);line = Console.ReadLine(); d.departs[0].Number_tecnic = int.Parse(line);
        //Console.WriteLine(int.Parse(line));
                d.departs[i].Pos_in_prod = i;

                Console.WriteLine("\nYou described department#{0}: name - {1}, number_lines - {2}, workers - {3}, tecs - {4}", i, d.departs[0].Name, d.departs[0].Number_lines,
                    d.departs[0].Number_workers, d.departs[0].Number_tecnic);


                int t = d.departs[i].Number_workers / d.departs[i].Number_lines, ost = d.departs[i].Number_workers % d.departs[i].Number_lines;
                //Console.WriteLine(ost);
                for (int u = 0;u< d.departs[i].Number_tecnic;u++)
                {
                    d.departs[i].tecniques.Add(new tecnique());

                }
                for (int j =0; j<d.departs[i].Number_lines;j++)
                {
                    int l, k;

                    Console.WriteLine("Conveyer_line#{0}:\nEnter equipment condition(0<x<10) - ",j); line = Console.ReadLine();    l = int.Parse(line);         //d.departs[i].conveyer_lines[j].Eqiupment_stat = int.Parse(line);
                    Console.WriteLine("Enter time per making 1 item - "); line = Console.ReadLine();       k = int.Parse(line);         //d.departs[i].conveyer_lines[j].Time_per_item = int.Parse(line);
                    d.departs[i].conveyer_lines.Add(new conveyer_line(t, j, l, k, false, "green"));

                  if (j == d.departs[i].Number_lines-1)  t += ost;
                    for (int r = 0 ;r < t;r++)
                    {    
                        d.departs[i].conveyer_lines[j].hand_workers.Add(new hand_worker(r,5));
                    }
                    Console.WriteLine("\nYou described conveyer_line#{0}: equipment condition - {1}, time per making 1 item in minutes - {2}\n", j, l, k);
                }
                if (i != d.departs[i].Number_lines - 1) { Console.WriteLine("Press something to describe next department..."); Console.ReadLine(); Console.Clear(); }                      //be careful
            }
            Console.WriteLine("\nYou described departments and its lines");
            Console.ReadLine();  Console.Clear();

            Console.WriteLine("Now u should describe your products - ");

            for (int i = 0;i<d.Number_product;i++)
            {
                Console.WriteLine("Product#{0}:");
                Console.WriteLine("Enter name of product - "); line = Console.ReadLine(); d.products[i].Name_product = line;
                Console.WriteLine("Enter list of details by space- "); 
               // string[] words = line.Split(' ');

                int pos = 0;
                line = Console.ReadLine();
                string[] words = line.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int length = words.Length;
                foreach (string word in words)
                {
                   //Console.WriteLine(word);
                    d.products[i].List_details.Add(word); pos++;
                }

                Console.WriteLine("Enter number of details by space- ");
                line = Console.ReadLine();
                words = line.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                for (pos =0; pos<length;pos++ )
                {
                    d.products[i].Number_details.Add(words[pos]);
                }

                Console.WriteLine("Enter list of departments, involved in process of making this product, by space - ");
                line = Console.ReadLine();
                words = line.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                for (pos = 0; pos < d.departs.Count; pos++)
                {
                    d.products[i].List_departments.Add(words[pos]);
                }
                Console.WriteLine("Enter current quality of this product - "); line = Console.ReadLine(); d.products[i].Quality = int.Parse(line); Console.WriteLine("");
                Console.WriteLine("****************\nYou described product: name - {0}, details(in pairs) - ", d.products[i].Name_product);
                for (pos = 1; pos < d.products[i].List_details.Count;pos++)
                {
                    Console.WriteLine("{0}: {1}", d.products[i].List_details[pos], d.products[i].Number_details[pos]);
                }
                Console.WriteLine("\nlist departments:");
                for (pos = 1; pos < d.products[i].List_departments.Count; pos++)
                {
                    Console.WriteLine(d.products[i].List_departments[pos]);
                }
                Console.WriteLine("\nquality - {0}\n****************\n", d.products[i].Quality); Console.WriteLine("");
            }

            Console.WriteLine("You finally described everything....."); Console.ReadLine(); Console.Clear();

            do
            {
                Console.WriteLine("1.Check equipment     2.Qualify workers       3.Take order             4.Do prototype               5.Exit");
                line = Console.ReadLine();
                switch (line)
                {
                    case "1":
                        for (int i = 0; i < d.departs.Count; i++)
                        {

                            d.departs[i].check_equipment();
                        }
                        break;

                    case "2":
                        do
                        {
                            // int y, h,m,w;
                            Console.WriteLine("Enter number of department to qualify its workers - "); line = Console.ReadLine(); m = int.Parse(line);
                            Console.WriteLine("Enter number of conveyer line - "); line = Console.ReadLine(); w = int.Parse(line);
                            Console.WriteLine("Enter first wortker to qualify - "); line = Console.ReadLine(); y = int.Parse(line);
                            Console.WriteLine("Enter last worker to qualify - "); line = Console.ReadLine(); h = int.Parse(line);
                            for (int i = y; i < h; i++) { d.departs[m].conveyer_lines[w].hand_workers[i]++; }
                        } while (y < h || y < d.departs[m].conveyer_lines[w].Workers || y >= d.departs[m].conveyer_lines[w].Workers
                        || h < d.departs[m].conveyer_lines[w].Workers || h >= d.departs[m].conveyer_lines[w].Workers); Console.WriteLine("Qualified!"); break;
                    case "3":
                        Console.WriteLine("Enter name of orderer - "); line = Console.ReadLine(); d.ord.Name_orderer = line;
                        Console.WriteLine("Enter name of product to order - "); line = Console.ReadLine(); d.ord.Kind_prod = line;
                        Console.WriteLine("Enter number of product - "); line = Console.ReadLine(); d.ord.Numb_prod = int.Parse(line);
                        Console.WriteLine("Enter deadline - "); line = Console.ReadLine(); d.ord.Dead_line = int.Parse(line);
                        Console.WriteLine("U took order: name_orderer:{0}, producr:{1}, number:{2},deadline:{3}", d.ord.Name_orderer, d.ord.Kind_prod, d.ord.Numb_prod, d.ord.Dead_line);
                        line = DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss"); Console.WriteLine("Order was taken {0}", line);

                        break;


                    case "4": Console.WriteLine("Not done yet"); break;
                    case "5": break;
                }
                Console.WriteLine("Press something....."); line = Console.ReadLine(); Console.Clear();

            } while (line != "5");
            //line = Console.ReadLine(); Console.Clear();


        }
    }
}
