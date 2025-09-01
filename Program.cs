using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using static ConsoleApp1.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ConsoleApp1


{
    internal class Program
    {
        class CaseInsensitiveComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
            }
        }
        class lengthComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return x.Length.CompareTo(y.Length);
            }
        }
        static void Main(string[] args)
        {
            #region LINQ - Element Operators
            ////1. Get first Product out of Stock 
            //var result = ProductList.Where((p) =>  p.UnitsInStock == 0)
            //                        .FirstOrDefault();

            //Console.WriteLine(result);





            ////2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var result =ProductList.Where((p)=>p.UnitPrice>1000)
            //                       .FirstOrDefault();
            //Console.WriteLine(result);






            ////3.Retrieve the second number greater than 5
            //var result =ProductList.Where((p)=>p.UnitPrice>5)
            //                       .Skip(1)
            //                       .FirstOrDefault();
            //Console.WriteLine(result);



            #endregion


            #region LINQ - Aggregate Operators

            ////1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Where((a) => a%2==1)
            //                .Count();
            //Console.WriteLine(result);






            ////2. Return a list of customers and how many orders each has.
            //var result = CustomerList.Select((c) => new
            //{
            //    c.CustomerName,
            //    OrdersCount = c.Orders.Count()

            //});



            //foreach (var item in result)
            //    Console.WriteLine(item);

















            ////3. Return a list of categories and how many products each has

            //var result = ProductList.Select((p)=>new
            //{
            //    p.Category
            //    ,ProductsCount=p.ProductName.Count()

            //}

            //);

            //foreach (var item in result)
            //    Console.WriteLine(item);













            ////  4.Get the total of the numbers in an array.
            //   int [] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //  var result =Arr.Sum(x => x);
            //  Console.WriteLine(result);





           








            //9.Get the total units in stock for each product category.

            //var result = ProductList.Where((p)=>p.UnitsInStock>0).Select((p) => new
            //{
            //    p.Category
            //    ,
            //    TotalUnitsInStock = p.ProductName.Count()

            //}

            //);

            //foreach (var item in result)
            //    Console.WriteLine(item);









            ////10. Get the cheapest price among each category's products

            //var result = ProductList.GroupBy((p)=>p.Category).Select((c) => new
            //{
            //    Category= c.Key
            //    ,UnitsInStock=c.Min((p)=>p.UnitPrice)



            //});

            //foreach (var item in result)
            //    Console.WriteLine(item);






            ////11. Get the products with the cheapest price in each category (Use Let)


            //var result = from p in ProductList
            //             where p.UnitsInStock > 0
            //             group p by p.Category into u
            //            let groupin = u.Min(p=>p.UnitPrice)
            //            from g in u

            //             select new
            //             {


            //                u.Key,
            //                g.ProductName,

            //               g.UnitPrice,



            //                 };


            //foreach (var item in result)
            //    Console.WriteLine(item);








            //12. Get the most expensive price among each category's products.

            //var result = ProductList.GroupBy((p) => p.Category).Select((c) => new
            //{
            //    Category = c.Key
            //    ,
            //    UnitPrice = c.Max((p) => p.UnitPrice)



            //});

            //foreach (var item in result)
            //    Console.WriteLine(item);







            //13. Get the products with the most expensive price in each category.




            //var result = ProductList.GroupBy((p) => p.Category)
            //                        .SelectMany((c) =>

            //                          c.Select(g=> new
            //                            {
            //                                Category = c.Key

            //                              ,g.ProductName,
            //                                UnitPrice= c.Max((p) => p.UnitPrice)
            //                            })

            //                        );

            //foreach (var item in result)
            //    Console.WriteLine(item);





            ////14.Get the average price of each category's products.


            //var result = ProductList.GroupBy((p) => p.Category)


            //                          .Select(c => new
            //                          {
            //                              Category = c.Key

            //                              ,

            //                              Average = c.Average((p) => p.UnitPrice)
            //                          })

            //                        ;

            //foreach (var item in result)
            //    Console.WriteLine(item);




            #endregion

            #region LINQ - Ordering Operators

            //1.Sort a list of products by name

            //var result = ProductList.OrderBy(p => p.ProductName)
            //                        .Select(p=>new
            //                        {
            //                            p.ProductID,
            //                             p.ProductName,


            //                        }
            //                        );
            //foreach (var item in result) 
            //Console.WriteLine(item);





            ////2.Uses a custom comparer to do a case -insensitive sort of the words in an array.
            //    string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result=Arr.OrderBy(p=>p,new CaseInsensitiveComparer());

            //foreach (var str in result)
            //    Console.WriteLine(str);







            ////3.Sort a list of products by units in stock from highest to lowest.

            //var result =ProductList.OrderByDescending(x => x.UnitsInStock)
            //                       .Select(x=>new
            //                       {
            //                           x.ProductID,
            //                           x.ProductName,
            //                           x.UnitsInStock
            //                       });
            //foreach (var item in result)           
            //Console.WriteLine(item);






            ////4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //         string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr.OrderBy(p=>p).OrderBy(x => x, new lengthComparer() );
            //foreach (var item in result)
            //    Console.WriteLine(item);




            ////5.Sort first by-word length and then by a case -insensitive sort of the words in an array.
            //  string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result =Arr.OrderBy(x => x,new lengthComparer()).
            //                ThenBy(x => x, new CaseInsensitiveComparer());
            //foreach(var s in result) 
            //    Console.WriteLine(s);







            ////6.Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var result = ProductList.OrderByDescending(p => p.Category)
            //                         .ThenByDescending(p => p.UnitPrice)
            //                          .Select(p=>new
            //                          {
            //                              p.Category,
            //                              p.ProductName,
            //                              p.UnitPrice
            //                          });

            //foreach (var item in result) 
            //    Console.WriteLine(item);









            ////7.Sort first by-word length and then by a case -insensitive descending sort of the words in an array.
            //        string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };


            //var result = Arr.OrderBy(x => x, new lengthComparer()).
            //                ThenByDescending(x => x, new CaseInsensitiveComparer());
            //foreach (var s in result)
            //    Console.WriteLine(s);







            ////8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};


            //var result = Arr.Where(x => x[1] == 'i')
            //                .Reverse();

            //foreach (var x in result) 
            //    Console.WriteLine(x);

            #endregion

            #region LINQ – Transformation Operators

            ////1. Return a sequence of just the names of a list of products.

            //var result = ProductList.Select((x,i) => $" {i+1} : product name : { x.ProductName} ");
            //foreach (var item in result) 
            //    Console.WriteLine(item);





            ////2.Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words.Select(x => new
            //{
            //    Upper = x.ToUpper(),
            //    Lower = x.ToLower(),
            //});

            //foreach (var word in result) 
            //    Console.WriteLine(word);









            ////3.Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.


            //var resultn = ProductList.Select(x => new
            //{
            //    x.Category,
            //    x.ProductName,
            //    price = x.UnitPrice

            //});

            //foreach (var item in resultn) 
            //    Console.WriteLine(item);







            ////4.Determine if the value of int in an array matches their position in the array.
            //     int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Select((x, i) =>  $"{x}:{x == i}");



            //foreach ( var x in result )
            //    Console.WriteLine(x);














            ////5.Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };

            //int[] numbersB = { 1, 3, 5, 7, 8 };


            //var result = numbersA.SelectMany(a =>
            //numbersB.Where(b=>b>a).Select(b =>$"{a} less than {b}" )

            //);

            //foreach ( var i in result ) 
            //    Console.WriteLine(i);





            ////6.Select all orders where the order total is less than 500.00.

            //var result = CustomerList
            //    .SelectMany(x =>
            //    x.Orders.Where(o => o.Total < 500).
            //    Select(o=> new
            //    {
            //        o.OrderID,
            //        o.Total,
            //    })



            //    );

            //foreach (var item in result)
            //    Console.WriteLine(item);













            ///*7.Select all orders where the order was made in 1998 or later*/


            //var result = CustomerList
            //    .SelectMany(x =>
            //    x.Orders.Where(o => o.OrderDate.Year >=1998).
            //    Select(o => new
            //    {
                    
            //        o.OrderID,
            //        o.OrderDate.Year,
            //    })



            //    );

            //foreach (var item in result)
            //    Console.WriteLine(item);


            #endregion


        }

    }
}
