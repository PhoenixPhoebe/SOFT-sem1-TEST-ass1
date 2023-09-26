using System;
namespace Temperture_Converter;

public class TempertureConverter
{
	public TempertureConverter()
	{
	}

	public double ConvertToCelcius(double fahrenheit)
	{
        return Math.Round((fahrenheit - 32) * 5 / 9, 1);
    }

	public double ConvertToFahrenheit(double celcius)
	{
        return Math.Round((celcius * 9 / 5) + 32, 1);
    }
}
