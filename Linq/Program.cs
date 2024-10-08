// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
int[] arr = { 4, 5, 10, 3, 2, 1, 14};
IEnumerable<int> n = arr.Where(x => x % 2 == 0);
foreach (var item in n)
{
    Console.WriteLine(item);
}
int count = arr.Count(x=>x>5);
int avg = (int)arr.Average(x=>x);  
int max = arr.Max(x=>x);
Console.WriteLine("avg is : " + avg);
Console.WriteLine("max is : " + max);
Console.WriteLine("count is : " + count);

IEnumerable<int> maxim = (from a in arr select max).Take(1);
foreach (var item in maxim)
{
    Console.WriteLine("maxim is: " + item);    
}


XDocument pd = XDocument.Load("C:\\Users\\LOBO\\source\\repos\\Linq\\Product.xml");
var products = pd.Elements();

Console.WriteLine("display product price >40000 using lamdba function");
var results = products.Elements("Product").Where(x => (int)x.Element("price") > 40000).Select(x => new {name = x.Element("pname").Value,
    
    price = x.Element("price").Value,
    dom = x.Element("dom").Value
    
    });

Console.WriteLine("Display product price > 40000 using for loop");

foreach (var item in results) {
    Console.WriteLine(item);
}
Console.WriteLine();

Console.WriteLine("display all products using lambda function");

var result2 = products.Elements("Product").Select(x=> new 
{ 
    name = x.Element("pname").Value,
    price = x.Element("price").Value,
    dom = x.Element("dom").Value
});
foreach (var item in result2)
{
    Console.WriteLine(item);
}
Console.WriteLine();

Console.WriteLine("Display products using lambda function manufactured after 10-7-14");

var result3 = 
    products
        .Elements("Product")
        .Where(
            x => (
             DateTime
                .ParseExact((string) x.Element("dom").Value, "dd-mm-yy", null)
            ) > (DateTime.ParseExact("10-07-14" , "dd-mm-yy" , null))).Select
    (x => new {
        name = x.Element("pname").Value,
        price = x.Element("price").Value,
        dom = x.Element("dom").Value
    });


foreach (var item in result3)
{
    Console.WriteLine(item);
}
Console.WriteLine();



Console.ReadKey();