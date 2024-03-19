using Timer = System.Windows.Forms.Timer;

namespace appKeysControl
{
  public partial class Form1 : Form
  {
    int points = 0;
    //create a timer
    Timer timer = new Timer();
    //create keyCode enum
    enum KeyCode
    {
      Left = 37,
      Up = 38,
      Right = 39,
      Down = 40
    }
    KeyCode SelectedKeyCode;
    public Form1()
    {
      InitializeComponent();
      timer.Interval = 50;
      timer.Tick += new EventHandler(timer_Tick);
      timer.Start();
      this.CenterToScreen();
      this.KeyPreview = true;
      lbl.Text = "";

      int formWidth = this.Size.Width;
      int formHeight = this.Size.Height;
      int labelWidth = lbl.Size.Width;
      int labelHeight = lbl.Size.Height;
      lbl.Location = new Point((formWidth - labelWidth) / 2, (formHeight - labelHeight) / 2);
    }

    private void timer_Tick(object? sender, EventArgs e)
    {
      //si lbl toca al lblCoin entonces lblcoin se mueve a una nueva posición
      if (lbl.Bounds.IntersectsWith(lblCoin.Bounds))
      {
        Random random = new Random();
        lblCoin.Location = new Point(random.Next(0, this.Width - lblCoin.Width), random.Next(0, this.Height - lblCoin.Height));
        points++;
        //change lblCoin bgcolor
        lblCoin.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
        timer.Interval -= 10;
        lblPoints.Text = "Puntos: " + points;
      }
     //move the label control 
     
      
      switch (SelectedKeyCode)
      {
        case KeyCode.Left:
          lbl.Left -= 5;
          if (lbl.Left < 0 - lbl.Width)
          {
            lbl.Left = this.Width;
          }
          break;
        case KeyCode.Right:
          lbl.Left += 5;
          if (lbl.Left > this.Width)
          {
            lbl.Left = 0 - lbl.Width;
          }
          break;
        case KeyCode.Up:
          lbl.Top -= 5;
          if (lbl.Top < 0 - lbl.Height)
          {
            lbl.Top = this.Height;
          }
          break;
        case KeyCode.Down:
          lbl.Top += 5;
          if (lbl.Top > this.Height)
          {
            lbl.Top = 0 - lbl.Height;
          }
          break;
      }
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      SelectedKeyCode = (KeyCode)e.KeyValue;
    }
  }
}
