using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyTemperatureApp.Temperatures
{

  public sealed record CoolingDegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> Temperatures)
    : DegreeDays(BaseTemperature, Temperatures)
  {
    public double DegreeDays => Temperatures
      .Where(s => s.Mean > BaseTemperature).Sum(s => s.Mean - BaseTemperature);
  }

}