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
  public class Field
  {   
    public Button button;             // button, ktory nalezy do fielda
    public Ship   chosen_ship;        // statek, ktory zostal klikniety i jest aktualnie ustawiany na playboardzie

    public bool shoot_failed;         // trafiono pole, ktore nie ma statku
    public bool shoot_success;        // trafiono pole, ktore ma statek

    public bool has_ship;             // pole ma ustawiony statek
    public static int zajete;    

    public Field(int x, int y, System.Windows.Forms.GroupBox container)
    {
      System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();
      
      button1.Location = new System.Drawing.Point(10 + x * 25, 23 + y * 25);
      button1.AllowDrop = true;
      button1.Name = y + "_" + x;
      button1.Size = new System.Drawing.Size(25, 25);      
      button1.TabIndex = 0;
      button1.UseVisualStyleBackColor = true;
      button1.MouseEnter += new EventHandler(Field_MouseEnter);
      button1.MouseDown += new MouseEventHandler(Field_MouseDown);
      button1.MouseLeave += new EventHandler(Field_MouseLeave);
      container.Controls.Add(button1);
      button = button1;    
    }    

    private void Field_MouseLeave(object sender, EventArgs e)
    {
      try
      {
        Button target = this.button;

        if (MainForm.chosen_ship.horizontal)
        {
          for (int i = 0; i < MainForm.chosen_ship.length; i++) // oznaczamy pola gry, na których został ustawiony statek
          {
            Field field = MainForm.play_board_1.FindFieldByLocation(target.Location.X + target.Size.Width * i, target.Location.Y); //czyscimy poprzednie polozenie statku poziomo

            int pos_x = MainForm.play_board_1.FindFieldX(target.Location.X + target.Size.Width * i); //znajdujemy odpowiednie pole za pomocą jego lokalizacji X i Y
            int pos_y = MainForm.play_board_1.FindFieldY(target.Location.Y);
            if (!MainForm.temp_array[pos_x, pos_y])
              field.button.Text = "";
            else
              field.button.Text = "X";
          }
        }
        else
        {
          for (int i = 0; i < MainForm.chosen_ship.length; i++) // oznaczamy pola gry, na których został ustawiony statek
          {
            Field field = MainForm.play_board_1.FindFieldByLocation(target.Location.X, target.Location.Y + target.Size.Width * i); //czyscimy poprzednie polozenie statku pionowo
            field.button.Text = "";
          }
        } 
      }
      catch { }
    }

    private void Field_MouseDown(object sender, MouseEventArgs e) // KLIKNIĘCIE
    {
      if (e.Button == MouseButtons.Right) //jesli kliknieto PPM, to statek obracamy
      {
        if (!MainForm.chosen_ship.horizontal) MainForm.chosen_ship.horizontal = true; //jesli statek byl pionowo, to teraz jest poziomo
        else MainForm.chosen_ship.horizontal = false; //jesli byl poziomo to jest pionowo
      }
      else // jesli kliknieto LPM, zatwierdzamy polozenie statku na playboardzie
      {
        if (MainForm.chosen_ship.horizontal) //jesli statek jest poziomo
        {
          for (int i = 0; i < MainForm.chosen_ship.length; i++) // oznaczamy pola gry, na których został ustawiony statek
          {            
            int pos_x = MainForm.play_board_1.FindFieldX(this.button.Location.X + this.button.Size.Width * i); //znajdujemy odpowiednie pole za pomocą jego lokalizacji X i Y
            int pos_y = MainForm.play_board_1.FindFieldY(this.button.Location.Y);
            MainForm.temp_array[pos_x, pos_y] = true; //oznaczamy, ze na polu jest statek
            PlayBoard.Clear(MainForm.play_board_1);
            PlayBoard.UpdatePlayboard(MainForm.play_board_1);
            PlayBoard.Refresh(MainForm.play_board_1);
          }
        }
        else //jesli statek jest pionowo
        {
          for (int i = 0; i < MainForm.chosen_ship.length; i++) // oznaczamy pola gry, na których został ustawiony statek
          {
            Field field = MainForm.play_board_1.FindFieldByLocation(this.button.Location.X, this.button.Location.Y + this.button.Size.Width * i); //znajdujemy odpowiednie pole za pomocą jego lokalizacji X i Y
            field.has_ship = true; //oznaczamy, ze na polu jest statek
          }         
        }
        MainForm.chosen_ship = null; //aktualnie nie wybrano zadnego statku do ustawienia na playboardzie
      }
      MainForm.richtext.Clear();
      for (int j = 0; j < 10; j++)
      {
        for (int i = 0; i < 10; i++)
        {
          MainForm.richtext.Text += MainForm.temp_array[i, j].ToString() + " | ";
        }
        MainForm.richtext.Text += "\n";
      }
    }

    public void Field_MouseEnter(object sender, EventArgs e)
    {
      try
      {
        int pos_x = MainForm.play_board_1.FindFieldX(this.button.Location.X); //znajdujemy odpowiednie pole za pomocą jego lokalizacji X i Y
        int pos_y = MainForm.play_board_1.FindFieldY(this.button.Location.Y);
        
        if(CheckIfLocationIsFree(pos_x, pos_y)) 
          SetShip(this.button);
      }
      catch {     }
    }

    private bool CheckIfLocationIsFree(int x, int y) //metoda sprawdza obszar dookoła aktualnego połozenia statku, czy nie ma tam zajetego pola
    {
      for (int i = 0; i < 3; i++)
      {
        for (int j = 0; j < MainForm.chosen_ship.length + 2; j++)
        {
          
          if (MainForm.temp_array[x-1+j, y-1+i] == true)
            return false;
        }
      }
      return true;
    }

    private void SetShip(Button target)
    {
      PlayBoard.Clear(MainForm.play_board_1);
      PlayBoard.Refresh(MainForm.play_board_1);

      if (MainForm.chosen_ship.horizontal == true)
      {
        for (int i = 0; i < MainForm.chosen_ship.length; i++) // oznaczamy pola gry, na których został ustawiony statek
        {
          Field field = MainForm.play_board_1.FindFieldByLocation(target.Location.X + target.Size.Width * i, target.Location.Y); //znajdujemy odpowiednie pole za pomocą jego lokalizacji X i Y
          field.button.Text = i.ToString();
        }
      }
      else
      {
        for (int i = 0; i < MainForm.chosen_ship.length; i++) // oznaczamy pola gry, na których został ustawiony statek
        {          
          Field field = MainForm.play_board_1.FindFieldByLocation(target.Location.X, target.Location.Y + target.Size.Width * i); //znajdujemy odpowiednie pole za pomocą jego lokalizacji X i Y
          field.button.Text = i.ToString();
        }
      }
    }
  }
}
