using System.Linq;
using System.Windows.Forms;

namespace StreamLineUi
{
    internal class ModelSettings
    {
    }

    public partial class ControlSettings : UserControl
    {
        private void initialize_ChooseUiColor()
        {
            string selectedColor = settingsDictionary["UiColor"];
            uiColor = common.event_RetrieveSpecifiedColor(selectedColor);
        }

        private void initialize_ChangeUiColor()
        {
            buttonSelectScriptsDirectory.BackColor = uiColor;
            buttonDefaultScriptsDirectory.BackColor = uiColor;
            buttonSelectTestDatabaseDirectory.BackColor = uiColor;
            buttonDefaultTestDatabaseDirectory.BackColor = uiColor;
            buttonSelectResultsDatabaseDirectory.BackColor = uiColor;
            buttonDefaultResultsDatabaseDirectory.BackColor = uiColor;
            buttonSelectResultsFileDirectory.BackColor = uiColor;
            buttonDefaultResultsFileDirectory.BackColor = uiColor;
            buttonResetResultsDatabase.BackColor = uiColor;
            buttonResetTestDatabase.BackColor = uiColor;
            buttonClearTestDatabase.BackColor = uiColor;
            buttonSaveSettings.BackColor = uiColor;
        }

        private void initialize_LoadSettings()
        {
            textboxScriptsDirectory.Text = settingsDictionary["ScriptsDirectory"];
            textboxTestDatabaseDirectory.Text = settingsDictionary["TestDatabaseDirectory"];
            textboxResultsDatabaseDirectory.Text = settingsDictionary["ResultsDatabaseDirectory"];
            textboxResultsFileDirectory.Text = settingsDictionary["ResultsFileDirectory"];
            string selectedColor = settingsDictionary["UiColor"];

            if (selectedColor.Equals("Blue")) { radioColorBlue.Checked = true; }
            else if (selectedColor.Equals("Orange")) { radioColorOrange.Checked = true; }
            else if (selectedColor.Equals("Green")) { radioColorGreen.Checked = true; }
            else if (selectedColor.Equals("Purple")) { radioColorPurple.Checked = true; }
            else if (selectedColor.Equals("Pink")) { radioColorPink.Checked = true; }
            else if (selectedColor.Equals("Crimson")) { radioColorCrimson.Checked = true; }
            else if (selectedColor.Equals("Teal")) { radioColorTeal.Checked = true; }
            else if (selectedColor.Equals("Brown")) { radioColorBrown.Checked = true; }
            else { radioColorGray.Checked = true; }
        }

        private void event_CollectSettingsData()
        {
            var selectedColor = groupboxUIColor.Controls.OfType<RadioButton>().
                FirstOrDefault(radio => radio.Checked);

            settingsDictionary["ScriptsDirectory"] = textboxScriptsDirectory.Text;
            settingsDictionary["TestDatabaseDirectory"] = textboxTestDatabaseDirectory.Text;
            settingsDictionary["ResultsDatabaseDirectory"] = textboxResultsDatabaseDirectory.Text;
            settingsDictionary["ResultsFileDirectory"] = textboxResultsFileDirectory.Text;
            settingsDictionary["UiColor"] = selectedColor.Text;

            string currentDirectory = common.event_GetCurrentDirectory();
            string setupDirectory = currentDirectory + "\\Resources\\Setup";
            string filePath = setupDirectory + "\\Settings.xml";
            common.event_GenerateXml(settingsDictionary, filePath, "Settings");
        }
    }
}
