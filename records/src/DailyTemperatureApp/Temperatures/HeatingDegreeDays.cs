using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyTemperatureApp.Temperatures
{

public record HeatingDegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> Temperatures)
    : DegreeDays(BaseTemperature, Temperatures)
  {
    public double DegreeDays => Temperatures
      .Where(s => s.Mean < BaseTemperature).Sum(s => BaseTemperature - s.Mean);
  }

}