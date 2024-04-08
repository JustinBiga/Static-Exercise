using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		public static double FahrenheitToCelsius(double Farenheit)
		{
			return (Farenheit - 32) * 5 / 9;
		}
		public static double CelsiusToFahrenheit(double Celisius)
		{
			return (Celisius * 9 / 5) + 32;
		}

    }
}

