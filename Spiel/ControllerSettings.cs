using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel
{
    using System.Windows.Forms;

    namespace Spiel
    {
        public class ControllerSettings
        {
            private Settings settingsFormInstance; // Assuming you have an instance of Settings
            private Spielfeld spielfeldFormInstance; // Assuming you have an instance of Spielfeld

            public ControllerSettings(Settings settingsForm, Spielfeld spielfeldForm)
            {
                settingsFormInstance = settingsForm;
                spielfeldFormInstance = spielfeldForm;
            }

            public bool GetCheckBoxStateFromSettings()
            {
                // Access the checkbox state from the Settings form
                return settingsFormInstance.GetCheckBoxState();
            }

            public void SetCheckBoxStateInSettings(bool newState)
            {
                // Set the checkbox state in the Settings form
                settingsFormInstance.SetCheckBoxState(newState);
            }

            public void PerformSomeActionInSpielfeld()
            {
                // Access the checkbox state from the Settings form
                bool checkBoxState = GetCheckBoxStateFromSettings();

                // Perform some action in the Spielfeld form based on the checkbox state
                spielfeldFormInstance.PerformAction(checkBoxState);
            }
        }
    }
}
