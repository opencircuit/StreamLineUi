using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace StreamLineUi
{
    internal class ModelScriptEditor { }

    public partial class ControlScriptEditor : UserControl
    {
        //***************************************************************************************************************
        // Initial Setup Methods
        //***************************************************************************************************************



        private void initialize_ChangeUiColor()
        {
            Color color = common.event_RetrieveUiColor(formMain.settingsInfo["UiColor"]);
            gridview.DefaultCellStyle.SelectionBackColor = color;
            common.event_ChangeButtonsColor(this, color);
        }

        private void initialize_GridviewColumn()
        {
            gridview.Columns.Add("ComponentName", "Component List (In Order of Execution)");
        }

        private void initialize_ComponentList()
        {
            string componentsDirectory = formMain.settingsInfo["ScriptsDirectory"] 
                + "\\" + formMain.settingsInfo["ScriptName"] + "\\Components";

            dropdownComponentList.DataSource = common.event_GetDirectoryFileList(componentsDirectory);
        }



        //***************************************************************************************************************
        // Action Events Handler Methods
        //***************************************************************************************************************



        private void event_AddComponentToGridview(int insertIndex)
        {
            try {

                string[] row = new string[] { dropdownComponentList.Text };
                gridview.Rows.Insert(insertIndex, row);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private XmlWriter event_InitializeXml()
        {
            XmlWriter xml = null;

            try {

                XmlWriterSettings xmlSettings = new XmlWriterSettings();
                xmlSettings.Encoding = Encoding.UTF8;
                xmlSettings.Indent = true;

                xml = XmlWriter.Create(scriptPath, xmlSettings);
                xml.WriteStartDocument();
                xml.WriteStartElement("Script");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            return xml;
        }

        private void event_WriteToXml(XmlWriter xml)
        {
            try {

                foreach (DataGridViewRow row in gridview.Rows) {

                    var cell = row.Cells[0].Value;
                    if (cell == null) { continue; }

                    xml.WriteStartElement("Component");
                    xml.WriteAttributeString("value", cell.ToString());
                    xml.WriteEndElement();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_FinalizeXml(XmlWriter xml)
        {
            try {

                xml.WriteEndElement();
                xml.WriteEndDocument();
                xml.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}