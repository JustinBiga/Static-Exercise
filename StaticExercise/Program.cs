namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            double fahrenheit = 50;
            double celsius = TempConverter.FahrenheitToCelsius(fahrenheit);

            Console.WriteLine($"{fahrenheit}°F is equal to {celsius}°C");

            celsius = 10;
            fahrenheit = TempConverter.CelsiusToFahrenheit(celsius);
            Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");
        }
    }
}
