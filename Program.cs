using System;
using System.Windows.Forms;

// Translating text with Azure cognitive services
// http://www.cyotek.com/blog/translating-text-with-azure-cognitive-services

// This work is licensed under the Creative Commons Attribution 4.0 International License.
// To view a copy of this license, visit http://creativecommons.org/licenses/by/4.0/.

namespace Cyotek.Demo.AzureTranslation
{
  static class Program
  {
    #region Static Methods

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }

    #endregion
  }
}
