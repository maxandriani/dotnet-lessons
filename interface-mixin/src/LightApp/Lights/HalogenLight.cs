using System;
using System.Threading.Tasks;

namespace LightApp.Lights
{
  public class HalogenLight : ITimerLight
  {
    private enum HalogenLightState
    {
      Off,
      On,
      TimerMode
    };

    private HalogenLightState state = HalogenLightState.Off;

    public override string ToString() => $"The light is {state}";

    public void SwitchOn() => state = HalogenLightState.On;

    public void SwitchOff() => state = HalogenLightState.Off;

    public bool IsOn() => state != HalogenLightState.Off;
    
    public async Task TurnOnFor(int duration)
    {
        Console.WriteLine("Halogen light starting timer function.");
        state = HalogenLightState.TimerMode;
        await Task.Delay(duration);
        state = HalogenLightState.Off;
        Console.WriteLine("Halogen light finished custom timer function");
    }
  }
}