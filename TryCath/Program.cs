using System;

namespace std;

public class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a number.");
        var input = Console.ReadLine();

        try
        {
            int converted = Convert.ToInt32(input);
            Console.WriteLine(converted * 10);
        }
        catch (FormatException)
        {
            Console.WriteLine("The input is not a number.");
        }
        catch(OverflowException)
        {
            Console.WriteLine("Max or min.");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("The program is finished.");
        }
    }
}