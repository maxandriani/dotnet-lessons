using System;

namespace CanalLockApp.Canals
{
  public enum WaterLevel {
    Low,
    High
  }

  public class CanalLock
  {
    // Query canal lock state:
    public WaterLevel CanalLockWaterLevel { get; private set; } = WaterLevel.Low;
    public bool HighWaterGateOpen { get; private set; } = false;
    public bool LowWaterGateOpen { get; private set; } = false;

    public void OpenHighGate() => SetHighGate(true);
    public void CloseHighGate() => SetHighGate(false);

    private void SetHighGate(bool state)
      => HighWaterGateOpen = (state, HighWaterGateOpen, CanalLockWaterLevel) switch
        {
          (false, _,     _)               => false,
          (true,  _,     WaterLevel.High) => true,
          (true,  false, WaterLevel.Low)  => throw new InvalidOperationException("Cannot open high gate when the water is low"),
          _                               => throw new InvalidOperationException("Cannot open high gate when the water is low"),
        };

    public void OpenLowGate() => SetLowGate(true);
    public void CloseLowGate() => SetLowGate(false);

    private void SetLowGate(bool state)
      => LowWaterGateOpen = (state, LowWaterGateOpen, CanalLockWaterLevel) switch
      {
        (false, _,     _)               => false,
        (true,  _,     WaterLevel.Low)  => true,
        (true,  false, WaterLevel.High) => throw new InvalidOperationException("Cannot open low gate when the water is high"),
        _                               => throw new InvalidOperationException("Cannot open low gate when the water is high"),
      };

    public void FillWaterLevel() => SetWaterLevel(WaterLevel.High);
    public void EmptyWaterLevel() => SetWaterLevel(WaterLevel.Low);

    private void SetWaterLevel(WaterLevel level)
     => CanalLockWaterLevel = (level, LowWaterGateOpen, HighWaterGateOpen) switch
     {
       (WaterLevel.High, false, false) => WaterLevel.High,
       (WaterLevel.Low,  false, false) => WaterLevel.Low,
       (_)                             => throw new InvalidOperationException("Cannot hise wate level w/ open locks")
     };

    public override string ToString() =>
        $"The lower gate is {(LowWaterGateOpen ? "Open" : "Closed")}. " +
        $"The upper gate is {(HighWaterGateOpen ? "Open" : "Closed")}. " +
        $"The water level is {CanalLockWaterLevel}.";
  }
}