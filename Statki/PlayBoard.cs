using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Statki
{
  public class PlayBoard
  {
    public Field[,] fields;
    
    public PlayBoard(System.Windows.Forms.GroupBox container)
    {
      fields = new Field[10,10];

      for (int j = 0; j < 10; j++)
      {
        for (int i = 0; i < 10; i++)
        {
          fields[i, j] = new Field(i, j, container);
        }
      }
    }

    public static void Clear(PlayBoard pb)
    {
      for (int j = 0; j < 10; j++)
      {
        for (int i = 0; i < 10; i++)
        {
          pb.fields[i, j].button.Text = "";
        }
      }
    }

    public static void Refresh(PlayBoard pb)
    {
      for (int j = 0; j < 10; j++)
      {
        for (int i = 0; i < 10; i++)
        {
          if (pb.fields[i, j].has_ship)
          {
            pb.fields[i, j].button.Text = "X";
          }
        }
      }
    }

    public Field FindFieldByLocation(int x, int y)
    {
      for (int j = 0; j < 10; j++)
      {
        for (int i = 0; i < 10; i++)
        {
          if (fields[i, j].button.Location.X == x && fields[i, j].button.Location.Y == y)
          {
            return fields[i, j];
          }
          else continue;
        }
      }
      return null;
    }

    public int FindFieldX(int x) //znajdowanie indeksu pola na playboardzie po wspolrzednych X
    {
      for (int j = 0; j < 10; j++)
      {
        for (int i = 0; i < 10; i++)
        {
          if (fields[j, i].button.Location.X == x)
          {
            return j;
          }
          else continue;
        }
      }
      return 0;
    }

    public int FindFieldY(int y) //znajdowanie indeksu pola na playboardzie po wspolrzednych Y
    {
      for (int j = 0; j < 10; j++)
      {
        for (int i = 0; i < 10; i++)
        {
          if (fields[j, i].button.Location.Y == y)
          {
            return i;
          }
          else continue;
        }
      }
      return 0;
    }

    public static void UpdatePlayboard(PlayBoard pb)
    {
      for (int j = 0; j < 10; j++)
      {
        for (int i = 0; i < 10; i++)
        {
          pb.fields[j, i].has_ship = MainForm.temp_array[j, i];
        }
      }
    }


  }
}
