using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statki
{
  public class Result
  {
    string player_name;
    int player_skill;
    int player_type;

    public Result(Player player)
    {
      player_name = player.GetName();
      player_skill = player.GetSkill();
      player_type = player.GetPlayerType();
    }

  }
}
