using System;
using CanalLockApp.Canals;

namespace CanalLockApp
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create a new canal lock:
      var canalGate = new CanalLock();

      // State should be doors closed, water level low:
      Console.WriteLine(canalGate);

      canalGate.OpenLowGate();
      Console.WriteLine($"Open the lower gate:  {canalGate}");

      Console.WriteLine("Boat enters lock from lower gate");

      canalGate.CloseLowGate();
      Console.WriteLine($"Close the lower gate:  {canalGate}");

      canalGate.FillWaterLevel();
      Console.WriteLine($"Raise the water level: {canalGate}");
      Console.WriteLine(canalGate);

      canalGate.OpenHighGate();
      Console.WriteLine($"Open the higher gate:  {canalGate}");

      Console.WriteLine("Boat exits lock at upper gate");
      Console.WriteLine("Boat enters lock from upper gate");

      canalGate.CloseHighGate();
      Console.WriteLine($"Close the higher gate: {canalGate}");

      canalGate.EmptyWaterLevel();
      Console.WriteLine($"Lower the water level: {canalGate}");

      canalGate.OpenLowGate();
      Console.WriteLine($"Open the lower gate:  {canalGate}");

      Console.WriteLine("Boat exits lock at upper gate");

      canalGate.CloseLowGate();
      Console.WriteLine($"Close the lower gate:  {canalGate}");


      Console.WriteLine("=============================================");
      Console.WriteLine("     Test invalid commands");
      // Open "wrong" gate (2 tests)
      try
      {
          canalGate = new CanalLock();
          canalGate.OpenHighGate();
      }
      catch (InvalidOperationException)
      {
          Console.WriteLine("Invalid operation: Can't open the high gate. Water is low.");
      }
      Console.WriteLine($"Try to open upper gate: {canalGate}");

      Console.WriteLine();
      Console.WriteLine();
      try
      {
        canalGate = new CanalLock();
        canalGate.FillWaterLevel();
        canalGate.OpenLowGate();
      }
      catch (InvalidOperationException)
      {
          Console.WriteLine("invalid operation: Can't open the lower gate. Water is high.");
      }
      Console.WriteLine($"Try to open lower gate: {canalGate}");
      // change water level with gate open (2 tests)
      Console.WriteLine();
      Console.WriteLine();
      try
      {
          canalGate = new CanalLock();
          canalGate.OpenLowGate();
          canalGate.FillWaterLevel();
      }
      catch (InvalidOperationException)
      {
          Console.WriteLine("invalid operation: Can't raise water when the lower gate is open.");
      }
      Console.WriteLine($"Try to raise water with lower gate open: {canalGate}");
      Console.WriteLine();
      Console.WriteLine();
      try
      {
          canalGate = new CanalLock();
          canalGate.FillWaterLevel();
          canalGate.OpenHighGate();
          canalGate.EmptyWaterLevel();
      }
      catch (InvalidOperationException)
      {
          Console.WriteLine("invalid operation: Can't lower water when the high gate is open.");
      }
      Console.WriteLine($"Try to lower water with high gate open: {canalGate}");
    }
  }
}
