using System;
using System.Data;
using System.Timers;
using System.Windows.Forms;

namespace Bank.Structure.Forms.SelectLanguage
{
  public partial class SelectLanguage_Form : Form
  {
    public SelectLanguage_Form()
    {
      InitializeComponent();
    }
    
    //===============================================//

    #region Form Load Event
    
    private void SelectLanguage_Form_Load(object sender, EventArgs e) => StartTimer();

    private void StartTimer() => DateTimer.Enabled = true;

    #endregion
    
    //===============================================//

    #region Button Click Event
    
    private void SelectLanguage_Button_Click(object sender, EventArgs e)
    {
      bool IsLanguageSelected() => comboBox1.SelectedIndex != -1;
      string language = Convert.ToString(comboBox1.SelectedItem);

      SelectLanguage.SetInSetting(language);

      if (IsLanguageSelected())
      {
        CloseForm();
      }
      else
      {
        ShowErrorMessage();
      }
    }

    private void CloseForm()
    {
      Program.Close_SelectLanguageForm = true;
      Close();
    }

    private void ShowErrorMessage()
    {
      string persianMessage = "ابتدا زبان خود را انتخاب کنید";
      string englishMessage = "First Select your Language";
      MessageBox.Show($"{englishMessage} \n {persianMessage}");
    }

    #endregion
    
    //===============================================//

    #region Timer Tick Event

    private void DateTimer_Elapsed(object sender, ElapsedEventArgs e)
    {
      SetDate();
      SetTime();
    }
    
    private void SetDate() => Date_ToolStrip.Text = DateTime.Now.ToShortDateString();
    
    private void SetTime() => Time_ToolStrip.Text = DateTime.Now.ToShortTimeString();

    #endregion
  }
}
