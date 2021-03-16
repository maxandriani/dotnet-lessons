using System;

namespace DailyTemperatureApp.Temperatures
{

  public record DailyTemperature(double HighTemp, double LowTemp)
  {
    public double Mean => (HighTemp + LowTemp) / 2.0;
  }

}