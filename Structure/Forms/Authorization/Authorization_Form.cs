using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Properties;
using Bank.Structure.Forms.CreateUser;

namespace Bank
{
  public partial class Authorization_Form : Form
  {
    public Authorization_Form()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      string language = Settings.Default.Language;
      
      if (language == "English")
      {
        //change language
      }
      //load database
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //check empty
      //check if its user or admin
    }

    private void label4_Click(object sender, EventArgs e) => Hide_AND_ShowThisForm();

    private void Hide_AND_ShowThisForm()
    {
      Hide();
      new CreateUser_Form().ShowDialog();
      Show();
    }
  }
}
