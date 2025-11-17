
// Starts the Whack-A-Mole Activity 5 app.
using System;
using System.Windows.Forms;
using WhackAMole.PresentationLayer;

namespace WhackAMole
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Start the FrmStopwatch form from the PresentationLayer.
            Application.Run(new FrmStopwatch());
        }
    }
}