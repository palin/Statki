using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statki
{
  public class Player
  {
    string player_name;
    int player_skill;
    int player_type; // Human=0, Computer=1

    public Player(string name, int type, int skill=0)
    {
      SetName(name);
      SetPlayerType(type);
      SetSkill(skill);
    }

    private void SetName(string name)
    {
      player_name = name;
    }

    public string GetName()
    {
      return player_name;
    }

    private void SetPlayerType(int type)
    {
      player_type = type;
    }

    public int GetPlayerType()
    {
      return player_type;
    }
    
    private void SetSkill(int skill)
    {
      player_skill = skill;
    }

    public int GetSkill()
    {
      return player_skill;
    }
    
  }
}
