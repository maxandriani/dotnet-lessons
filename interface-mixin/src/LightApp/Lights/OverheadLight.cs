using System;

namespace LightApp.Lights
{
  public class OverheadLight : ITimerLight, IBlinkingLight
  {
    private bool isOn = false;
    public bool IsOn() => isOn;
    public void SwitchOff() => isOn = false;
    public void SwitchOn() => isOn = true;
    
    public override string ToString() => $"The light is {(isOn ? "on" : "off")}";
  }
}