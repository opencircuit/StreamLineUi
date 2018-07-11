using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace StreamLineUi
{
    internal class Common
    {
        //***************************************************************************************************************
        // Internally Accessible Methods
        //***************************************************************************************************************



        internal string event_GetComputerName()
        {
            try { return Environment.MachineName; }
            catch (Exception ex) { return ex.Message; }
        }

        internal void event_CreateDirectory(string directory)
        {
            try { Directory.CreateDirectory(directory); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        internal void event_ChangeButtonsColor(UserControl userControl, Color color)
        {
            foreach (Control control in userControl.Controls) {

                Button button = control as Button;
                if (button == null) { continue; }
                event_ChangeButtonColor(button, color);
            }
        }

        internal void event_ChangeButtonColor(Button button, Color color)
        {
            button.FlatAppearance.BorderColor = color;
            button.FlatAppearance.MouseOverBackColor = color;
            button.FlatAppearance.MouseDownBackColor = color;
        }

        internal void event_ExtractResource(string resourceName, string outputDirectory)
        {
            try {

                if (File.Exists(outputDirectory + "\\" + resourceName)) { return; }
                string resourceFile = "StreamLineUi.Resources." + resourceName;
                outputDirectory = outputDirectory + "\\";

                Stream inputStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceFile);
                Stream outputStream = File.Create(outputDirectory + resourceName);

                byte[] buffer = new byte[8192];
                int bytesRead;

                while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0) {
                    outputStream.Write(buffer, 0, bytesRead);
                }

                inputStream.Close();
                outputStream.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        internal void event_ExtractResource(string resourceName, string newResourceName, string outputDirectory)
        {
            try {

                if (File.Exists(outputDirectory + "\\" + newResourceName)) { return; }
                string resourceFile = "StreamLineUi.Resources." + resourceName;
                outputDirectory = outputDirectory + "\\";

                Stream inputStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceFile);
                Stream outputStream = File.Create(outputDirectory + newResourceName);

                byte[] buffer = new byte[8192];
                int bytesRead;

                while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0) {
                    outputStream.Write(buffer, 0, bytesRead);
                }

                inputStream.Close();
                outputStream.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        internal Color event_RetrieveUiColor(string selectedColor)
        {
            Color color;

            if (selectedColor.Equals("Blue")) { color = Color.DodgerBlue; }
            else if (selectedColor.Equals("Orange")) { color = Color.DarkOrange; }
            else if (selectedColor.Equals("Green")) { color = Color.Green; }
            else if (selectedColor.Equals("Purple")) { color = Color.Purple; }
            else if (selectedColor.Equals("Pink")) { color = Color.HotPink; }
            else if (selectedColor.Equals("Crimson")) { color = Color.Crimson; }
            else if (selectedColor.Equals("Teal")) { color = Color.Teal; }
            else { color = Color.DimGray; }

            return color;
        }

        internal DatabaseManager event_DatabaseConnector(string scriptName, string databaseType)
        {
            DatabaseManager database = null;

            try {

                string scriptsDirectory = Directory.GetCurrentDirectory() + "\\Resources\\Scripts\\";
                string scriptDirectory = scriptsDirectory + scriptName;

                if (databaseType.Equals("Test")) { database = new DatabaseManager(scriptDirectory + "\\TestCaseData.db"); }
                else { database = new DatabaseManager(scriptDirectory + "\\TestCaseResults.db"); }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            return database;
        }

        internal XmlNodeList event_LoadXmlPrimaryNodes(string filePath, string nodeName)
        {
            XmlNodeList primaryNodes = null;

            try {

                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(filePath);
                XmlElement root = xmlDocument.DocumentElement;
                primaryNodes = root.GetElementsByTagName(nodeName);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            return primaryNodes;
        }

        internal ArrayList event_GetDirectoryFileList(string directoryPath)
        {
            ArrayList fileList = new ArrayList();
            string[] fileEntries = Directory.GetFiles(directoryPath);

            foreach (string filePath in fileEntries) {

                string fileName = filePath.Substring(filePath.LastIndexOf("\\") + 1);
                fileName = fileName.Replace(".xml", "");
                fileList.Add(fileName);
            }

            return fileList;
        }

        internal void event_CreateXml(Dictionary<string, string> nodesCollection, string filePath, string primaryNode)
        {
            try {

                XmlWriterSettings xmlSettings = new XmlWriterSettings();
                xmlSettings.Encoding = Encoding.UTF8;
                xmlSettings.Indent = true;

                XmlWriter xml = XmlWriter.Create(filePath, xmlSettings);
                xml.WriteStartDocument();
                xml.WriteStartElement("Information");
                xml.WriteStartElement(primaryNode);

                foreach (KeyValuePair<string, string> node in nodesCollection) {
                    event_CreateXmlNode(xml, node.Key, node.Value);
                }

                xml.WriteEndElement();
                xml.WriteEndElement();
                xml.WriteEndDocument();
                xml.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }



        //***************************************************************************************************************
        // Private Methods
        //***************************************************************************************************************



        private void event_CreateXmlNode(XmlWriter xml, string nodeName, string nodeValue)
        {
            try {

                xml.WriteStartElement(nodeName);
                xml.WriteString(nodeValue);
                xml.WriteEndElement();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}