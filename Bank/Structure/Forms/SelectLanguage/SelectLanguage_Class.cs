using Bank.Properties;
using System;
namespace Bank.Structure.Forms.SelectLanguage
{
  public static class SelectLanguage
  {
    public static void SetInSetting(string language)
    {
      if (language != String.Empty)
      {
        Settings.Default.Language = language;
      }
    }
  }
}
