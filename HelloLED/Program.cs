using System;
using System.Collections;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Presentation;
using Microsoft.SPOT.Presentation.Controls;
using Microsoft.SPOT.Presentation.Media;
using Microsoft.SPOT.Presentation.Shapes;
using Microsoft.SPOT.Touch;

using Gadgeteer.Networking;
using GT = Gadgeteer;
using GTM = Gadgeteer.Modules;
using Gadgeteer.Modules.GHIElectronics;

namespace HelloLED
{
    public partial class Program
    {
        // This method is run when the mainboard is powered up or reset.   
        void ProgramStarted()
        {
            Debug.Print("Blink green LED");

            ledStrip.TurnLedOn(2);
            ledStrip.TurnLedOn(5);

            while (true)
            {
                Mainboard.SetDebugLED(true);
                Thread.Sleep(1000); // leave it on for 1 second
                Mainboard.SetDebugLED(false);
                Thread.Sleep(500); // turn it of for 500 milliseconds
            }

            Debug.Print("Program finished");
        }
    }
}
