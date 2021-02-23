using System;

namespace Inkapsling
{
  public class Fungi
  {
    // public string name;
    private float taste; // 1-20
    public int growthRate;

    public string Name {get; set;}


    private int xp = 0;

    public int Xp {
      get {
        return xp;
      }
      set {
        xp = value;
      }
    }

    public int Level {
      get {
        return xp / 10 + 1;
      }
      private set {
        xp = value * 10 -1;
      }
    }

    public float Taste
    {
      set
      {
        taste = value;
        if (taste < 1)
        {
          taste = 0;
        }
      }
      get
      {
        return taste;
      }
    }


    // public void SetTaste(int amount)
    // {
    //   taste = amount;
    //   // if (taste < 1)
    //   // {
    //   //   taste = 0;
    //   // }
    // }

    // public int GetTaste()
    // {
    //   return (int) taste;
    // }
  }
}
