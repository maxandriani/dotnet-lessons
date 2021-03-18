using System;

namespace LightApp.Lights
{
  public interface ILight
  {
    void SwitchOn();
    void SwitchOff();
    bool IsOn();

    public PowerStatus Power() => PowerStatus.NoPower;
  }
}