using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIMS_dan {
internal static class Program {
  /// <summary>
  /// The main entry point for the application.
  /// </summary>
  [STAThread]
  static void Main() {
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);

    // Start with the WelcomePage
    ShowForm(new WelcomePage());

    ShowForm(new SignInForm());
  }

  static void ShowForm(Form form) { Application.Run(form); }
}
}