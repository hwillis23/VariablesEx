using System;


namespace VariablesEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Duke";
            int dogAge = 7;
            bool lovesSleep = true;
            char nickName = 'D';
            double toys = 43;
            decimal weight = 25.4m; 
                
              Console.WriteLine($"My dog's name is {dogName} aka {nickName}, He is {dogAge} years old and weighs {weight} pounds.He likes his {toys} suffed toys and sleeps a lot {lovesSleep} ");
        }
    }
}
