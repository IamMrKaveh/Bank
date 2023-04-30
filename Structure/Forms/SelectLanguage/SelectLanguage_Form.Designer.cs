using System.ComponentModel;

namespace Bank.Structure.Forms.SelectLanguage
{
  partial class SelectLanguage_Form
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.SelectLanguage_Button = new System.Windows.Forms.Button();
      this.DateTimer = new System.Timers.Timer();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.Date_ToolStrip = new System.Windows.Forms.ToolStripLabel();
      this.Time_ToolStrip = new System.Windows.Forms.ToolStripLabel();
      ((System.ComponentModel.ISupportInitialize)(this.DateTimer)).BeginInit();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(260, 33);
      this.label1.TabIndex = 0;
      this.label1.Text = "لطفا زبان خود را انتخاب کنید";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] { "English", "Persian" });
      this.comboBox1.Location = new System.Drawing.Point(51, 45);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(180, 21);
      this.comboBox1.TabIndex = 1;
      // 
      // SelectLanguage_Button
      // 
      this.SelectLanguage_Button.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SelectLanguage_Button.Location = new System.Drawing.Point(93, 72);
      this.SelectLanguage_Button.Name = "SelectLanguage_Button";
      this.SelectLanguage_Button.Size = new System.Drawing.Size(103, 34);
      this.SelectLanguage_Button.TabIndex = 2;
      this.SelectLanguage_Button.Text = "انتخاب";
      this.SelectLanguage_Button.UseVisualStyleBackColor = true;
      this.SelectLanguage_Button.Click += new System.EventHandler(this.SelectLanguage_Button_Click);
      // 
      // DateTimer
      // 
      this.DateTimer.Interval = 1000D;
      this.DateTimer.SynchronizingObject = this;
      this.DateTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.DateTimer_Elapsed);
      // 
      // toolStrip1
      // 
      this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.Date_ToolStrip, this.Time_ToolStrip });
      this.toolStrip1.Location = new System.Drawing.Point(0, 136);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.toolStrip1.Size = new System.Drawing.Size(284, 25);
      this.toolStrip1.TabIndex = 3;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // Date_ToolStrip
      // 
      this.Date_ToolStrip.Name = "Date_ToolStrip";
      this.Date_ToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.Date_ToolStrip.Size = new System.Drawing.Size(16, 22);
      this.Date_ToolStrip.Text = "...";
      // 
      // Time_ToolStrip
      // 
      this.Time_ToolStrip.Name = "Time_ToolStrip";
      this.Time_ToolStrip.Size = new System.Drawing.Size(16, 22);
      this.Time_ToolStrip.Text = "...";
      // 
      // SelectLanguage_Form
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 161);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.SelectLanguage_Button);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.label1);
      this.Name = "SelectLanguage_Form";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Select Language";
      this.Load += new System.EventHandler(this.SelectLanguage_Form_Load);
      ((System.ComponentModel.ISupportInitialize)(this.DateTimer)).EndInit();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.ToolStripLabel Time_ToolStrip;

    private System.Windows.Forms.ToolStripLabel Date_ToolStrip;

    private System.Timers.Timer DateTimer;

    private System.Windows.Forms.ToolStrip toolStrip1;

    private System.Windows.Forms.Button SelectLanguage_Button;

    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.Label label1;

    #endregion
  }
}
