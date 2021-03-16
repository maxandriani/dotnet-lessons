using System;
using System.Collections.Generic;
using System.Text;

namespace DailyTemperatureApp.Temperatures
{

  public abstract record DegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> Temperatures)
  {

  protected virtual bool PrintMembers(StringBuilder stringBuilder)
  {
    stringBuilder.Append($"BaseTemperature = {BaseTemperature}");
    return true;
  }

  }

}



