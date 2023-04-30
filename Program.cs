using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Structure.Forms.SelectLanguage;

namespace Bank
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>

    public static bool Close_SelectLanguageForm = false;
    
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new SelectLanguage_Form());
      if (Close_SelectLanguageForm)
      {
        Close_SelectLanguageForm = false;
        new Authorization_Form().ShowDialog();
      }
    }
  }
}
