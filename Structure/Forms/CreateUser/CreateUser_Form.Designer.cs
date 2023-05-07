using System.ComponentModel;

namespace Bank.Structure.Forms.CreateUser
{
  partial class CreateUser_Form
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
      this.label2 = new System.Windows.Forms.Label();
      this.Password_Textbox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.CreateUser_Button = new System.Windows.Forms.Button();
      this.Username_Textbox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.RePassword_Textbox = new System.Windows.Forms.TextBox();
      this.IsAdmin_Checkbox = new System.Windows.Forms.CheckBox();
      this.label4 = new System.Windows.Forms.Label();
      this.KeyAdmin_Textbox = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.Username_StatusLabel = new System.Windows.Forms.Label();
      this.KeyAdmin_StatusLabel = new System.Windows.Forms.Label();
      this.RePassword_StatusLabel = new System.Windows.Forms.Label();
      this.Password_StatusLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(172, 43);
      this.label2.Name = "label2";
      this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.label2.Size = new System.Drawing.Size(100, 28);
      this.label2.TabIndex = 12;
      this.label2.Text = "رمز عبور :";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Password_Textbox
      // 
      this.Password_Textbox.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Password_Textbox.Location = new System.Drawing.Point(50, 43);
      this.Password_Textbox.Name = "Password_Textbox";
      this.Password_Textbox.Size = new System.Drawing.Size(116, 28);
      this.Password_Textbox.TabIndex = 11;
      this.Password_Textbox.TextChanged += new System.EventHandler(this.Password_Textbox_TextChanged);
      this.Password_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordInput_KeyPress);
      this.Password_Textbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Password_Textbox_KeyUp);
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(172, 9);
      this.label3.Name = "label3";
      this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.label3.Size = new System.Drawing.Size(100, 28);
      this.label3.TabIndex = 10;
      this.label3.Text = "نام کاربری :";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // CreateUser_Button
      // 
      this.CreateUser_Button.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CreateUser_Button.Location = new System.Drawing.Point(50, 181);
      this.CreateUser_Button.Name = "CreateUser_Button";
      this.CreateUser_Button.Size = new System.Drawing.Size(116, 31);
      this.CreateUser_Button.TabIndex = 9;
      this.CreateUser_Button.Text = "ثبت نام";
      this.CreateUser_Button.UseVisualStyleBackColor = true;
      this.CreateUser_Button.Click += new System.EventHandler(this.CreateUser_Button_Click);
      // 
      // Username_Textbox
      // 
      this.Username_Textbox.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Username_Textbox.Location = new System.Drawing.Point(50, 9);
      this.Username_Textbox.Name = "Username_Textbox";
      this.Username_Textbox.Size = new System.Drawing.Size(116, 28);
      this.Username_Textbox.TabIndex = 8;
      this.Username_Textbox.TextChanged += new System.EventHandler(this.Username_Textbox_TextChanged);
      this.Username_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameInput_KeyPress);
      this.Username_Textbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Username_Textbox_KeyUp);
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(172, 77);
      this.label1.Name = "label1";
      this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.label1.Size = new System.Drawing.Size(100, 28);
      this.label1.TabIndex = 13;
      this.label1.Text = "تکرار رمز عبور :";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // RePassword_Textbox
      // 
      this.RePassword_Textbox.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.RePassword_Textbox.Location = new System.Drawing.Point(50, 77);
      this.RePassword_Textbox.Name = "RePassword_Textbox";
      this.RePassword_Textbox.Size = new System.Drawing.Size(116, 28);
      this.RePassword_Textbox.TabIndex = 14;
      this.RePassword_Textbox.TextChanged += new System.EventHandler(this.RePassword_Textbox_TextChanged);
      this.RePassword_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RePasswordInput_KeyPress);
      this.RePassword_Textbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RePassword_Textbox_KeyUp);
      // 
      // IsAdmin_Checkbox
      // 
      this.IsAdmin_Checkbox.AutoSize = true;
      this.IsAdmin_Checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.IsAdmin_Checkbox.Location = new System.Drawing.Point(151, 125);
      this.IsAdmin_Checkbox.Name = "IsAdmin_Checkbox";
      this.IsAdmin_Checkbox.Size = new System.Drawing.Size(15, 14);
      this.IsAdmin_Checkbox.TabIndex = 15;
      this.IsAdmin_Checkbox.UseVisualStyleBackColor = true;
      this.IsAdmin_Checkbox.CheckedChanged += new System.EventHandler(this.IsAdmin_Checkbox_CheckedChanged);
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(172, 119);
      this.label4.Name = "label4";
      this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.label4.Size = new System.Drawing.Size(100, 28);
      this.label4.TabIndex = 16;
      this.label4.Text = "آیا ادمین هستید؟";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // KeyAdmin_Textbox
      // 
      this.KeyAdmin_Textbox.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.KeyAdmin_Textbox.Location = new System.Drawing.Point(50, 147);
      this.KeyAdmin_Textbox.Name = "KeyAdmin_Textbox";
      this.KeyAdmin_Textbox.Size = new System.Drawing.Size(116, 28);
      this.KeyAdmin_Textbox.TabIndex = 18;
      this.KeyAdmin_Textbox.Visible = false;
      this.KeyAdmin_Textbox.TextChanged += new System.EventHandler(this.KeyAdmin_Textbox_TextChanged);
      this.KeyAdmin_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyAdminInput_KeyPress);
      this.KeyAdmin_Textbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyAdmin_Textbox_KeyUp);
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(172, 147);
      this.label5.Name = "label5";
      this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.label5.Size = new System.Drawing.Size(100, 28);
      this.label5.TabIndex = 17;
      this.label5.Text = "کلید ادمین :";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.label5.Visible = false;
      // 
      // Username_StatusLabel
      // 
      this.Username_StatusLabel.BackColor = System.Drawing.Color.Blue;
      this.Username_StatusLabel.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Username_StatusLabel.Location = new System.Drawing.Point(24, 13);
      this.Username_StatusLabel.Name = "Username_StatusLabel";
      this.Username_StatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.Username_StatusLabel.Size = new System.Drawing.Size(20, 20);
      this.Username_StatusLabel.TabIndex = 19;
      this.Username_StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // KeyAdmin_StatusLabel
      // 
      this.KeyAdmin_StatusLabel.BackColor = System.Drawing.Color.Blue;
      this.KeyAdmin_StatusLabel.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.KeyAdmin_StatusLabel.Location = new System.Drawing.Point(24, 151);
      this.KeyAdmin_StatusLabel.Name = "KeyAdmin_StatusLabel";
      this.KeyAdmin_StatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.KeyAdmin_StatusLabel.Size = new System.Drawing.Size(20, 20);
      this.KeyAdmin_StatusLabel.TabIndex = 20;
      this.KeyAdmin_StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.KeyAdmin_StatusLabel.Visible = false;
      // 
      // RePassword_StatusLabel
      // 
      this.RePassword_StatusLabel.BackColor = System.Drawing.Color.Blue;
      this.RePassword_StatusLabel.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.RePassword_StatusLabel.Location = new System.Drawing.Point(24, 81);
      this.RePassword_StatusLabel.Name = "RePassword_StatusLabel";
      this.RePassword_StatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.RePassword_StatusLabel.Size = new System.Drawing.Size(20, 20);
      this.RePassword_StatusLabel.TabIndex = 21;
      this.RePassword_StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Password_StatusLabel
      // 
      this.Password_StatusLabel.BackColor = System.Drawing.Color.Blue;
      this.Password_StatusLabel.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Password_StatusLabel.Location = new System.Drawing.Point(24, 47);
      this.Password_StatusLabel.Name = "Password_StatusLabel";
      this.Password_StatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.Password_StatusLabel.Size = new System.Drawing.Size(20, 20);
      this.Password_StatusLabel.TabIndex = 22;
      this.Password_StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // CreateUser_Form
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.Password_StatusLabel);
      this.Controls.Add(this.RePassword_StatusLabel);
      this.Controls.Add(this.KeyAdmin_StatusLabel);
      this.Controls.Add(this.Username_StatusLabel);
      this.Controls.Add(this.KeyAdmin_Textbox);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.IsAdmin_Checkbox);
      this.Controls.Add(this.RePassword_Textbox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.Password_Textbox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.CreateUser_Button);
      this.Controls.Add(this.Username_Textbox);
      this.Name = "CreateUser_Form";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "CreateUser_Form";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.Label KeyAdmin_StatusLabel;
    private System.Windows.Forms.Label RePassword_StatusLabel;
    private System.Windows.Forms.Label Password_StatusLabel;

    private System.Windows.Forms.Label Username_StatusLabel;

    private System.Windows.Forms.TextBox KeyAdmin_Textbox;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.CheckBox IsAdmin_Checkbox;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox RePassword_Textbox;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox Password_Textbox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button CreateUser_Button;
    private System.Windows.Forms.TextBox Username_Textbox;

    #endregion
  }
}
