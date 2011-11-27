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
  public class Ship
  {
    public int length;      // ilosc zajmowanych pol
    public bool horizontal; // domyslna pozycja statku to pozycja pozioma 
    Point location;
    public Button button;
    public bool on_playboard;
    public PictureBox ship_picture;

    public Ship(int number, int ship_length, string name)
    {
      on_playboard = false;
      length = ship_length;
      horizontal = true;

      System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();
      button1.Location = new System.Drawing.Point(100, 30*number); 
      button1.Text = "S_" + length;
      button1.Name = name;
      button1.Size = new System.Drawing.Size(25*length, 25);
      button1.TabIndex = 0;
      button1.MouseClick += new System.Windows.Forms.MouseEventHandler(ship_Click);
      location = button1.Location;
      button = button1;
      MainForm.mainform.Controls.Add(button1);
      button1.BringToFront();
    }

    private void ship_Click(object sender, MouseEventArgs e)
    {
      Ship ship = this;
      MainForm.chosen_ship = this; //wybrano statek do ustawienia na playboardzie

      Point ship_location = ship.button.Location;
    }

    public Point GetLocation()
    {
      return location;
    }

    public void SetLocation(Point coordinates)
    {
      button.Location = coordinates;
      location = coordinates;
    }
  }
}
