using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_2.Classes
{
    internal class Menu
    {
        private static bool flag = true;

        private static string MainHeader = "Turn 1 - check all products\n" +
                                           "Turn 2 - sort by price\n" +
                                           "Turn 3 - sort by category\n" +
                                           "Turn 4 - clear menu\n" +
                                           "Turn 0 - by close\n"; 

        private static string SortPriceHeader = "Turn 1 - Sort by price descending\n" +
                                                "Turn 2 - Sort by price ascending\n" +
                                                "Turn 3 - sort by after price\n" +
                                                "Turn 4 - sort by before price\n" +
                                                "Turn 5 - sort by range price\n" +
                                                "Turn 6 - back\n" +
                                                "Turn 7 - clear menu";

        private static string SortCatecoryHeader = "Turn 1 - by sort\n" +
                                                   "Turn 2 - by back\n" +
                                                   "Turn 3 - by clear console";

        public static void MainMenu()
        {
            Finder finder = new Finder();
            List<Product> all = finder.getProducts();

            Console.WriteLine(MainHeader);
            while (flag)
            { 
                Console.Write("Your input: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            for (int i = 0; i < all.Count; i++)
                            {
                                Console.WriteLine("{0} - {1} {2} {3} rubles",
                                    i,
                                    all[i].Name,
                                    all[i].Category,
                                    all[i].Price);
                            }

                            Console.WriteLine();
                            break;
                        }

                    case "2":
                        { 
                            Console.Clear();
                            PriceSortMenu(all);
                            Console.WriteLine(MainHeader);
                            break;
                        }

                    case "3":
                        {
                            Console.Clear();
                            CatecorySortMenu(all);
                            Console.WriteLine(MainHeader);
                            break;
                        }

                    case "4":
                        {
                            Console.Clear();
                            Console.WriteLine(MainHeader);
                            Console.Write("Your input: ");
                            break;
                        }

                    case "0":
                        {
                           flag = false;
                            break;
                        }
                } 
            }
        }

        private static void PriceSortMenu(List<Product> all)
        {
            Console.WriteLine(SortPriceHeader);
            bool sortFlag = true;

            while(sortFlag)
            {
                Console.Write("Your input: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            IEnumerable<Product> array = Sort.Price_descending(all);

                            int count = 0;

                            foreach (Product product in array)
                            {
                                Console.WriteLine("{0} - {1} {2} {3} rubles",
                                        count,
                                        product.Name,
                                        product.Category,
                                        product.Price);

                                count++;
                            }
                            
                            break;
                        }

                    case "2":
                        {
                            IEnumerable<Product> array = Sort.Price_ascending(all);

                            int count = 0;

                            foreach (Product product in array)
                            {
                                Console.WriteLine("{0} - {1} {2} {3} rubles",
                                        count,
                                        product.Name,
                                        product.Category,
                                        product.Price);

                                count++;
                            }

                            break;
                        }

                    case "3":
                        {
                            Console.Write("Input price: ");

                            try
                            {
                                int price = Convert.ToInt32(Console.ReadLine());
                                IEnumerable<Product> array = Sort.Price_AfterPrice(all, price);

                                int count = 0;

                                foreach (Product product in array)
                                {
                                    Console.WriteLine("{0} - {1} {2} {3} rubles",
                                            count,
                                            product.Name,
                                            product.Category,
                                            product.Price);

                                    count++;
                                }
                            }
                            catch (Exception _)
                            { }

                            break;
                        }

                    case "4":
                        {
                            Console.Write("Input price: ");

                            try
                            {
                                int price = Convert.ToInt32(Console.ReadLine());
                                IEnumerable<Product> array = Sort.Price_BeforePrice(all, price);

                                int count = 0;

                                foreach (Product product in array)
                                {
                                    Console.WriteLine("{0} - {1} {2} {3} rubles",
                                            count,
                                            product.Name,
                                            product.Category,
                                            product.Price);

                                    count++;
                                }
                            }
                            catch (Exception _)
                            { }

                            break;
                        }

                    case "5":
                        {
                            try
                            {
                                Console.Write("Input start price: ");
                                int startPrice = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine();

                                Console.Write("Input end price: ");
                                int endPrice = Convert.ToInt32(Console.ReadLine());

                                IEnumerable<Product> array = Sort.Price_RangePrice(all, startPrice, endPrice);

                                int count = 0;

                                foreach (Product product in array)
                                {
                                    Console.WriteLine("{0} - {1} {2} {3} rubles",
                                            count,
                                            product.Name,
                                            product.Category,
                                            product.Price);

                                    count++;
                                }
                            }
                            catch (Exception _)
                            { }

                            break;
                        }

                    case "6":
                        {
                            sortFlag = false;
                            break;
                        }

                    case "7":
                        {
                            Console.Clear();
                            Console.WriteLine(SortPriceHeader);
                            Console.Write("Your input: ");
                            break;
                        }
                }
            }
        }

        private static void CatecorySortMenu(List<Product> all)
        {
            bool catecoryFlag = true;
            Console.Clear();
            Console.WriteLine(SortCatecoryHeader);

            while (catecoryFlag)
            {
                Console.Write("Your input: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            try
                            {
                                Console.Write("Input category: ");
                                string category = Console.ReadLine();
                                IEnumerable<Product> array = Sort.Category(all, category);

                                int count = 0;

                                foreach (Product product in array)
                                {
                                    Console.WriteLine("{0} - {1} {2} {3} rubles",
                                            count,
                                            product.Name,
                                            product.Category,
                                            product.Price);

                                    count++;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        }

                    case "2":
                        {
                            Console.Clear();
                            catecoryFlag = false;
                            break;
                        }

                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine(SortCatecoryHeader);
                            break;
                        }
                }
            }
        }
    }
}