using Timer = System.Windows.Forms.Timer;

namespace appKeysControl
{
  public partial class Form1 : Form
  {
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
      timer.Interval = 10;
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
     //move the label control
     
      switch (SelectedKeyCode)
      {
        case KeyCode.Left:
          lbl.Left -= 5;
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
          break;
        case KeyCode.Down:
          lbl.Top += 5;
          break;
      }
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      SelectedKeyCode = (KeyCode)e.KeyValue;
    }
  }
}
