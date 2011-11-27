using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statki
{
  public class Settings
  {
    bool animation, sound;

    public Settings()
    {
      try
      {
        Load();
      }
      catch
      {
        animation = true;
        sound = true;
      }      
    }

    public void TurnOffSound()
    {
      sound = false;
    }

    public void TurnOnSound()
    {
      sound = true;
    }

    public void TurnOffAnimation()
    {
      animation = false;
    }

    public void TurnOnAnimation()
    {
      animation = true;
    }

    public void Save()
    {
    }

    public void Load()
    {
    }
  }
}
