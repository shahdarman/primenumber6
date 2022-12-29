// See https://aka.ms/new-console-template for more informatio

using System.Globalization;

Console.WriteLine("HELLO SWEETY");

Console.WriteLine("PLEASE ENTER THE FRIST NUMBER..");

int FN = int.Parse(Console.ReadLine());

Console.WriteLine("PLEASE ENTER THE SCOND NUMBER..");

int SN = int.Parse(Console.ReadLine());

for( int i = FN; i <= SN; i++)
{
    int prime = 0;
    for (int j =2; j <= i/2; j++)
    {
        if(i % j ==0)
        {
            prime++;
            break;
        }

    }
    if (prime == 0 && i != 1)
        
        Console.WriteLine("THE NUMBER {0} IS PRIME", i);
}
Console.WriteLine(" THANK YOU , HAVE A NICE DAY");

