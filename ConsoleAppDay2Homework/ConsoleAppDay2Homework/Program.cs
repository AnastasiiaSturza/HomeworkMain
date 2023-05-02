using System.Security.Cryptography.X509Certificates;

int numb = -6;
int numb2 = 5;
int numb3 = 10;
int numb4 = 15;
int x = 2;

Console.WriteLine("stepen : " + (numb*Math.Pow(x, 3) + numb2*Math.Pow(x, 2) - numb3*x + numb4));


double y = 2;
double x1 = 60;

Console.WriteLine("abs + sin : " + Math.Abs(y)*Math.Sin(x1));


int numb5 = 2;
int x2 = 4;

Console.WriteLine("PI  : " + numb5*Math.PI*x2);


int numb6 = 3;
int numb7 = 5;

Console.WriteLine("max  : " + Math.Max(numb6, numb7));


DateTime NewYear = new DateTime(2023, 12, 31 );
DateTime today = DateTime.Now;
TimeSpan toNewYear = NewYear - today;
double tsTo = toNewYear.TotalDays;
DateTime LastNewYear = new DateTime(2022,12, 31);
TimeSpan afterNewYear = today - LastNewYear;
double tsAfter = afterNewYear.TotalDays;

Console.WriteLine($" to new year : {Math.Round(tsTo)} and after {Math.Round(tsAfter)}");


