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
  public partial class MainForm : Form
  {
    public static Player player_1;
    public static Player player_2;
    public static PlayBoard play_board_1;
    public static PlayBoard play_board_2;
    public static Settings settings;
    public static Record records;
    public static Ship[] ships;
    public static Ship chosen_ship; //statek, ktory wybrano do ustawienia na playboardzie
    public static MainForm mainform;
    public static RichTextBox richtext;
    public static bool[,] temp_array;        // tablica pomocnicza do zapisywania pozycji statku 
    public static Button statek3;

    public MainForm()
    {
      InitializeComponent();
      FillTempArray();
      richtext = richTextBox1;
      chosen_ship = null;

      mainform = this;

      play_board_1 = new PlayBoard(groupBox1);
      play_board_2 = new PlayBoard(groupBox2);
      settings = new Settings();
      records = new Record();
      ships = new Ship[5];
      ships[0] = new Ship(1, 2, "S_2");
      ships[1] = new Ship(2, 3, "S_3_1");
      ships[2] = new Ship(3, 3, "S_3_2");
      ships[3] = new Ship(4, 4, "S_4");
      ships[4] = new Ship(5, 5, "S_5");
    }

    public void FillTempArray()
    {
      temp_array = new bool[10, 10];

      for (int i = 0; i < 10; i++)
      {
        for (int j = 0; j < 10; j++)
        {
          temp_array[i, j] = false;
        }
      }
    }

    private void GameNewToolStripMenuItem3_Click(object sender, EventArgs e)
    {
      StartForm startform = new StartForm();
      startform.Show();
    }

    private void RecordsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      RecordsForm records = new RecordsForm();
      records.Show();
    }

    private void GameEndToolStripMenuItem4_Click(object sender, EventArgs e)
    {
      records.Save();
      this.Close();
    }

    private void OptionsSoundOffToolStripMenuItem_Click(object sender, EventArgs e)
    {
      settings.TurnOffSound();
    }

    private void OptionsSoundOnToolStripMenuItem_Click(object sender, EventArgs e)
    {
      settings.TurnOnSound();
    }

    private void OptionsAnimationOffToolStripMenuItem8_Click(object sender, EventArgs e)
    {
      settings.TurnOffAnimation();
    }

    private void OptionsAnimationOnToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      settings.TurnOnAnimation();
    }
  }
}
