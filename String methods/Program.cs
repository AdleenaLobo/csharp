// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the string");
string s1 = Console.ReadLine();
bool b1 = s1.Contains("text");
Console.WriteLine(" The string contains the word text: " + b1);
bool b2 = s1.StartsWith("t");
Console.WriteLine("The string starts with 't': " + b2);
Console.WriteLine("The length of text string is: "+s1.Length);
Console.WriteLine("The given string is in uppercase: "+s1.ToUpper());
Console.WriteLine("Enter another text");
 string s2= Console.ReadLine();
Console.WriteLine(string.Concat(s1 , s2));
bool b3 = s2.EndsWith("t");
Console.WriteLine("this string ends with 't': "+b3);
Console.WriteLine(s1.Equals(s2));
string s3 = string.Intern(s1);
Console.WriteLine("the answer for this is : " + s3);
Console.WriteLine("enter a number ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n);
int num = n, reverse = 0, sum = 0, rem = 0;
while (num > 0) {
    rem = num % 10;
    sum = sum + rem;
    reverse = reverse * 10 + (rem);
    num = num / 10;

}

Console.WriteLine("the reverse of the given number is "+ reverse);
Console.WriteLine("the sum of  a given number is "+sum);    
