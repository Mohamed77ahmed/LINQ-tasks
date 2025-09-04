
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Xml.Linq;
using static assignment2.ListGenerators;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Element Operators


            //    //1.Get first Product out of Stock

            //var result= ProductList.FirstOrDefault(x=>x.UnitsInStock == 0);
            //Console.WriteLine(result);














            ////2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var result = ProductList.FirstOrDefault(x => x.UnitPrice > 1000);
            //Console.WriteLine(result);










            ////3.Retrieve the second number greater than 5
            //    int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


            //var result = Arr.Where(x=>x>5).Skip(1).FirstOrDefault();
            //Console.WriteLine(result);








            #endregion




            
            #region LINQ - Aggregate Operators

            //// 1.Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Count(x=>x%2==1);
            //Console.WriteLine(result);











            //// 2.Return a list of customers and how many orders each has.
            //var result = CustomerList.GroupBy(c => c.CustomerName)
            //                         .SelectMany(c =>
            //                            c.Select(o => new
            //                            {
            //                                c.Key,
            //                                NumberOfOrder = o.Orders.Count()

            //                            }));

            //foreach (var item in result)
            //    Console.WriteLine(item);










            ////3.Return a list of categories and how many products each has

            //var result = ProductList.GroupBy(c => c.Category)
            //                       .SelectMany
            //                       (p =>
            //                          p.Select(o => new
            //                          {
            //                           p.Key,
            //                           NumberfProduct = o.ProductName.Count()


            //                          })


            //                       );

            //foreach (var item in result)
            //    Console.WriteLine(item);









            ////4.Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result=Arr.Sum(x => x);
            //Console.WriteLine(result);







            ////5. Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            string[] words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Sum(x => x.Length);
            //Console.WriteLine(result);







            ////6.Get the length of the shortest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //var result = words.Min(x => x.Length);
            //Console.WriteLine(result);












            ////7.Get the length of the longest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //var result = words.Max(x => x.Length);
            //Console.WriteLine(result);











            ////8.Get the average length of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //var result = words.Average(x => x.Length);
            //Console.WriteLine(result);





            ////9.Get the total units in stock for each product category.

            //var result = ProductList.GroupBy(x => x.Category)
            //                        .SelectMany(p =>
            //                          p.Where(x => x.UnitsInStock > 0)
            //                           .Select(o => new
            //                           {
            //                               p.Key,
            //                               NumOfProductInCat = o.ProductName.Count()

            //                           })


            //                        );
            //foreach ( var item in result )
            //    Console.WriteLine(item);








            ////10.Get the cheapest price among each category's products

            //var res = ProductList.GroupBy(x => x.Category)
            //                     .Select(x =>
            //                       x.Where(p=>p.UnitPrice==x.Min(g=>g.UnitPrice)).Select(p => new
            //                       {
            //                           x.Key,
            //                           p.ProductName
            //                       ,
            //                           CheapestPrice = x.Min(x => x.UnitPrice)
            //                       }).FirstOrDefault()

            //                     );
            //foreach ( var item in res )
            //    Console.WriteLine(item);


            ////11. Get the products with the cheapest price in each category (Use Let)
            //var result = ProductList.GroupBy(x => x.Category)
            //                       .Select(g =>
            //                           g.Where(p => p.UnitPrice == g.Min(p => p.UnitPrice))
            //                            .Select(p => new
            //                            {
            //                                g.Key,
            //                                p.ProductName,
            //                                CheapestPrice = g.Min(p => p.UnitPrice)
            //                            }).FirstOrDefault()
            //                       );

            //foreach (var item in result)
            //    Console.WriteLine(item);














            ////12. Get the most expensive price among each category's products.
            //var result = ProductList.GroupBy(x => x.Category)
            //                        .Select(g => new
            //                        {
            //                            g.Key,
            //                            MostExpensivePrice = g.Max(p => p.UnitPrice)
            //                        });

            // foreach (var item in result)
            //     Console.WriteLine(item);




            ////13. Get the products with the most expensive price in each category.
            //var result = ProductList.GroupBy(x => x.Category)
            //                        .Select(g =>
            //                            g.Where(p => p.UnitPrice == g.Max(p => p.UnitPrice))
            //                             .Select(p => new
            //                             {
            //                                 g.Key,
            //                                 p.ProductName,
            //                                 MostExpensivePrice = g.Max(p => p.UnitPrice)
            //                             }).FirstOrDefault()
            //                        );

            // foreach (var item in result)
            //     Console.WriteLine(item);












            ////14. Get the average price of each category's products.
            //var result = ProductList.GroupBy(x => x.Category)
            //                       .Select(g => new
            //                       {
            //                           g.Key,
            //                           AvgPrice = g.Average(p => p.UnitPrice)
            //                       });

            //foreach (var item in result)
            //    Console.WriteLine(item);


            #endregion




            #region LINQ - Set Operators

            ////1. Find the unique Category names from Product List
            //var result = ProductList.Select(p => p.Category)
            //                          .Distinct();

            // foreach (var item in result)
            //     Console.WriteLine(item);








            ////2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var result = ProductList.Select(p => p.ProductName[0])
            //                          .Union(CustomerList.Select(c => c.CustomerName[0]));

            // foreach (var item in result)
            //     Console.WriteLine(item);




            ////3. Create one sequence that contains the common first letter from both product and customer names.
            //var result = ProductList.Select(p => p.ProductName[0])
            //                         .Intersect(CustomerList.Select(c => c.CustomerName[0]));

            //foreach (var item in result)
            //    Console.WriteLine(item);




            ////4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var result = ProductList.Select(p => p.ProductName[0])
            //                          .Except(CustomerList.Select(c => c.CustomerName[0]));

            // foreach (var item in result)
            //     Console.WriteLine(item);




            ////5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var result = ProductList.Select(p => p.ProductName.Substring(Math.Max(0, p.ProductName.Length - 3)))
            //                         .Concat(CustomerList.Select(c => c.CustomerName.Substring(Math.Max(0, c.CustomerName.Length - 3))));

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion



            #region LINQ - Quantifiers

            ////1. Determine if any of the words in dictionary_english.txt contain the substring 'ei'.
            //var result = words.Any(w => w.Contains("ei"));
            //Console.WriteLine(resultBool);




            ////2. Return a grouped list of products only for categories that have at least one product that is out of stock.
            //var result = ProductList.GroupBy(p => p.Category)
            //                       .Where(g => g.Any(p => p.UnitsInStock == 0))
            //                       .SelectMany(g => g.Select(p => new
            //                       {
            //                           g.Key,
            //                           p.ProductName,
            //                           p.UnitsInStock
            //                       }));

            //foreach (var item in result)
            //    Console.WriteLine(item);




            ////3. Return a grouped list of products only for categories that have all of their products in stock.
            //var result = ProductList.GroupBy(p => p.Category)
            //                       .Where(g => g.All(p => p.UnitsInStock > 0))
            //                       .SelectMany(g => g.Select(p => new
            //                       {
            //                           g.Key,
            //                           p.ProductName,
            //                           p.UnitsInStock
            //                       }));

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion


            #region LINQ – Grouping Operators

            ////1. Use group by to partition a list of numbers by their remainder when divided by 5
            List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result = numbers.GroupBy(n => n % 5)
            //                   .Select(g => new
            //                   {
            //                       Remainder = g.Key,
            //                       Numbers = g.ToList()
            //                   });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Remainder {item.Remainder}");
            //}




            ////2. Use group by to partition a list of words by their first letter. (dictionary_english.txt)
           //var result = words.GroupBy(w => w[0])
           //                  .Select(g => new
           //                  {
           //                      FirstLetter = g.Key,
           //                      Words = g.ToList()
           //                  });

           // foreach (var item in result)
           // {
           //     Console.WriteLine($"Letter {item.FirstLetter}: Count={item.Words.Count}");
           // }




            ////3. Group By with a custom comparer that matches words that are consists of the same Characters Together
            //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };

            //var result = Arr.GroupBy(w => String.Concat(w.OrderBy(c => c)));

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Group {group.Key}");
            //}

            #endregion










        }
    }
}
