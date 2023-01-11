using System;

class Program
{
    public static void Main(string[] args)
    {
        // Console.Write("Please enter the a number :");
        // int counter = int.Parse(Console.ReadLine());
       

        // for (int i = 0; i < counter; i++)
        // {
        //     if(i % 2 != 0)
        //         Console.Write(i+ " ");
        // }


        // int sumOdd = 0;
        // int sumEven = 0;

        // for (int i = 1; i <= 1000; i++)
        // {
        //     if(i % 2 == 0)
        //        sumEven +=i;
        //     else
        //         sumOdd +=i; 
        // }

        // Console.WriteLine("Sum of the odd numbers :" + sumOdd);     
        // Console.WriteLine("Sum of even numbers : " + sumEven);


        for(int i = 0 ; i < 10 ; i++)
        {
            if(i == 4)
                break;
            System.Console.WriteLine(i);
        }

        for (int i = 0; i <10 ; i++)
        {
            if(i == 4)
                continue;
            System.Console.WriteLine(i);
        }

    }


}
