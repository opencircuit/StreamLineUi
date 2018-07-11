using System;
using System.Windows.Forms;
using System.Xml;

namespace StreamLineUi
{
    public partial class ControlScriptEditor : UserControl
    {
        private FormMain formMain;
        private Common common;
        private GridviewManager gridviewManager;

        private string scriptPath;

        public ControlScriptEditor(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            common = new Common();
            gridviewManager = new GridviewManager();
        }

        private void action_FormLoad(object sender, EventArgs e)
        {
            initialize_ChangeUiColor();
            initialize_GridviewColumn();
            initialize_ComponentList();
            initialize_LoadScript();
        }

        private void initialize_LoadScript()
        {
            scriptPath = formMain.settingsInfo["ScriptsDirectory"] 
                + "\\" + formMain.settingsInfo["ScriptName"] + "\\Script.xml";

            XmlNodeList nodeList = common.event_LoadXmlPrimaryNodes(scriptPath, "Component");

            foreach (XmlNode node in nodeList) {
                gridview.Rows.Add(node.Attributes["value"].Value);
            }
        }

        private void action_RefreshComponentsList(object sender, EventArgs e)
        {
            initialize_ComponentList();
        }

        private void action_AddComponent(object sender, EventArgs e)
        {
            try {

                string componentName = dropdownComponentList.Text;
                if (componentName.Length == 0) { return; }
                int insertIndex = gridview.Rows.Count;
                event_AddComponentToGridview(insertIndex);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void action_AddComponentBelow(object sender, EventArgs e)
        {
            try {

                if (!gridviewManager.event_SingleRowSelected(gridview)) { return; }
                DataGridViewRow selectedRow = gridview.SelectedRows[0];
                int insertIndex = selectedRow.Index + 1;
                event_AddComponentToGridview(insertIndex);
                gridview.ClearSelection();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void action_MoveComponentUp(object sender, EventArgs e)
        {
            gridviewManager.event_MoveRowUp(gridview, "component");
        }

        private void action_MoveComponentDown(object sender, EventArgs e)
        {
            gridviewManager.event_MoveRowDown(gridview, "component");
        }

        private void action_RemoveComponents(object sender, EventArgs e)
        {
            gridviewManager.event_DeleteRows(gridview);
        }

        private void action_SaveScript(object sender, EventArgs e)
        {
            XmlWriter xml = event_InitializeXml();
            event_WriteToXml(xml);
            event_FinalizeXml(xml);
        }
    }
}