namespace appKeysControl
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      lbl = new Label();
      lblCoin = new Label();
      lblPoints = new Label();
      SuspendLayout();
      // 
      // lbl
      // 
      lbl.BackColor = Color.Black;
      lbl.Font = new Font("Segoe UI", 20F);
      lbl.Location = new Point(732, 339);
      lbl.Name = "lbl";
      lbl.Size = new Size(50, 50);
      lbl.TabIndex = 0;
      lbl.Text = "X";
      // 
      // lblCoin
      // 
      lblCoin.BackColor = Color.Green;
      lblCoin.Font = new Font("Segoe UI", 20F);
      lblCoin.Location = new Point(850, 321);
      lblCoin.Name = "lblCoin";
      lblCoin.Size = new Size(50, 50);
      lblCoin.TabIndex = 1;
      // 
      // lblPoints
      // 
      lblPoints.BackColor = Color.Transparent;
      lblPoints.Font = new Font("Segoe UI", 20F);
      lblPoints.Location = new Point(1318, 35);
      lblPoints.Name = "lblPoints";
      lblPoints.Size = new Size(143, 50);
      lblPoints.TabIndex = 2;
      lblPoints.Text = "Puntos: 0";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1484, 761);
      Controls.Add(lblPoints);
      Controls.Add(lblCoin);
      Controls.Add(lbl);
      Name = "Form1";
      Text = "Form1";
      KeyDown += Form1_KeyDown;
      ResumeLayout(false);
    }

    #endregion

    private Label lbl;
    private Label lblCoin;
    private Label lblPoints;
  }
}
