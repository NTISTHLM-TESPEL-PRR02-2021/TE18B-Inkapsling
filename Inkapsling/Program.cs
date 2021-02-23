using System;

namespace Inkapsling
{
  class Program
  {
    static void Main(string[] args)
    {
      Fungi fun = new Fungi();

      fun.Taste = -500;

      fun.Xp += 100;

      fun.Name = "Zvampish McSvampface";

      Console.WriteLine(fun.Name);

      // fun.SetTaste(-500);

      // Console.WriteLine(fun.GetTaste());

      Console.ReadLine();
      
    }
  }
}
