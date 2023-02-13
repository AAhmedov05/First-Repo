// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static void Main(string[] args)
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int seconds = int.Parse(Console.ReadLine());
        
        double meters = double.Parse(Console.ReadLine());
       
        try
        {
            int timeToSecondsConverter = TimeToSecondCoverter(hours, minutes, seconds);
            Console.WriteLine($"Time in seconds:{timeToSecondsConverter}");
            double metersToMillsConverter = MetersToMillsCoverter(meters);
            Console.WriteLine($"Length in mills:{metersToMillsConverter}");           
            double resultOfSolve = metersToMillsConverter / timeToSecondsConverter;
            Console.WriteLine($"Velocity in mills/second:{resultOfSolve}");
            Console.WriteLine("The Program end successfuly!!!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Something is WRONG!!!");
            Console.WriteLine($"Type of error:{e.GetType().Name}");
            Console.WriteLine($"Description of code:{e.Message}");
            Console.WriteLine($"Program:{e.Source}");
            Console.WriteLine($"Method:{e.TargetSite.Name}");
            Console.WriteLine($"Place of error:{e.StackTrace}");
            
        }
    }
    private static int TimeToSecondCoverter(int hours, int minutes, int seconds) 
    {
        hours = hours * 60 * 60;
        minutes = minutes * 60;
        int covertedSeconds=hours+minutes+seconds;
        return covertedSeconds;
    }
    private static double MetersToMillsCoverter(double meters)
    {
        return meters * 39730;
    }
}