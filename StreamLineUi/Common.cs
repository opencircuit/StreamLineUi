using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
        private XmlWriter xml;

        internal string event_GetCurrentDirectory()
        {
            return Path.GetDirectoryName(Application.ExecutablePath); ;
        }

        internal string event_GetComputerName()
        {
            return Environment.MachineName;
        }

        internal void event_CreateDirectory(string directory)
        {
            try {
                Directory.CreateDirectory(directory);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        internal void event_ExtractEmbeddedResource(string projectName, string fileNameAndExtension, string outputDirectory)
        {
            try {

                string resourceFile = projectName + ".Resources." + fileNameAndExtension;
                outputDirectory = outputDirectory + "\\";

                Stream inputStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceFile);
                Stream outputStream = File.Create(outputDirectory + fileNameAndExtension);

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

        internal Color event_RetrieveSpecifiedColor(string selectedColor)
        {
            Color color;

            if (selectedColor.Equals("Blue")) { color = Color.DodgerBlue; }
            else if (selectedColor.Equals("Orange")) { color = Color.DarkOrange; }
            else if (selectedColor.Equals("Green")) { color = Color.Green; }
            else if (selectedColor.Equals("Purple")) { color = Color.Purple; }
            else if (selectedColor.Equals("Pink")) { color = Color.HotPink; }
            else if (selectedColor.Equals("Crimson")) { color = Color.Crimson; }
            else if (selectedColor.Equals("Teal")) { color = Color.Teal; }
            else if (selectedColor.Equals("Brown")) { color = Color.Brown; }
            else { color = Color.Gray; }

            return color;
        }

        internal XmlNodeList event_LoadXmlPrimaryNodes(string filePath, string nodeName)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);
            XmlElement root = xmlDocument.DocumentElement;
            XmlNodeList primaryNodes = root.GetElementsByTagName(nodeName);

            return primaryNodes;
        }

        internal ArrayList event_GetDirectoryFileList(string directoryPath)
        {
            ArrayList fileList = new ArrayList();
            string[] fileEntries = Directory.GetFiles(directoryPath);

            foreach (string filePath in fileEntries) {

                string fileName = filePath.Substring(filePath.LastIndexOf("\\") + 1);
                fileName = fileName.Replace(".xml", "");
                fileList.Add(fileName.ToUpper());
            }

            return fileList;
        }

        internal void event_GenerateXml(Dictionary<string, string> nodesCollection, string filePath, string primaryNode)
        {
            try {

                XmlWriterSettings xmlSettings = new XmlWriterSettings();
                xmlSettings.Encoding = Encoding.UTF8;
                xmlSettings.Indent = true;

                xml = XmlWriter.Create(filePath, xmlSettings);
                xml.WriteStartDocument();
                xml.WriteStartElement("Information");
                xml.WriteStartElement(primaryNode);

                foreach (KeyValuePair<string, string> node in nodesCollection) {
                    event_CreateXmlNode(node.Key, node.Value);
                }

                xml.WriteEndElement();
                xml.WriteEndElement();
                xml.WriteEndDocument();
                xml.Close();
                xml = null;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_CreateXmlNode(string nodeName, string nodeValue)
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

        internal Process event_CreateJarProcess(string testCaseID)
        {
            Process process = new Process();

            try {

                string currentDirectory = event_GetCurrentDirectory();
                StringBuilder processArgument = new StringBuilder();
                processArgument.Append("-jar");
                processArgument.Append(" \"");
                processArgument.Append(currentDirectory);
                processArgument.Append("\\StreamLineEngine.jar");
                processArgument.Append("\" ");
                processArgument.Append(testCaseID);

                ProcessStartInfo processInfo = new ProcessStartInfo();
                processInfo.UseShellExecute = true;
                processInfo.FileName = "java.exe";
                processInfo.Arguments = processArgument.ToString();
                processInfo.WindowStyle = ProcessWindowStyle.Hidden;

                process.StartInfo = processInfo;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            return process;
        }
    }
}