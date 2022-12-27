using System;
using System.IO;
using System.Collections.Generic;


public class CodingChallenge
{
    static void Main(string[] args)
    {
        String line;
        int sum;
        List<int> sumslist = new List<int>();


        StreamReader reader = new StreamReader("Sums.txt");
        StreamWriter writer = new StreamWriter("SumsOutput.txt");


        while ((line = reader.ReadLine()) != null)
        {
            sum = 0;

            string[] numbers = new string[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = line.Substring(i * 3, 3);
            }

            foreach (string number in numbers)
            {
                sum += int.Parse(number);
            }

            writer.WriteLine(line + sum.ToString().PadLeft(3, '0'));

            sumslist.Add(sum);
        }

        int grandTotal = 0;
        foreach (int i in sumslist)
        {
            grandTotal += i;
        }
       
        writer.WriteLine("Grand Total = " + grandTotal);
    }

}