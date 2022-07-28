using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using System.Xml;


namespace CRI_Data_Interface
{
    public static class ProgramParser
    {
        public static ArrayList Parse(string filePath) 
        {
            if (filePath == null) return null;

            ArrayList parsedProgram = new ArrayList();

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            // Console.WriteLine(filePath);

            foreach(XmlNode node in doc.DocumentElement) 
            {
                string name = node.Name;

                Dictionary<string, string> attributes = new Dictionary<string, string>();

                for ( int i = 0; i < node.Attributes.Count; i++)
                {
                    attributes.Add(node.Attributes[i].Name, node.Attributes[i].Value);

                    // Console.WriteLine(node.Attributes[i].Name + " : " + node.Attributes[i].Value);
                }

                if (name == "Joint") 
                {
                    parsedProgram.Add(string.Format("CMD Move Joint {0} {1} {2} {3} {4} {5} 0 0 0 {6}",
                            attributes["a1"], attributes["a2"], attributes["a3"], attributes["a4"],
                            attributes["a5"], attributes["a6"], attributes["velPercent"])
                    );
                }
                else if (name == "Linear") 
                {
                    parsedProgram.Add(string.Format("CMD Move Cart {0} {1} {2} {3} {4} {5} 0 0 0 {6}",
                            attributes["x"], attributes["y"], attributes["z"], attributes["a"],
                            attributes["b"], attributes["c"], attributes["vel"])
                    );
                }
                else if (name == "Relative") 
                {
                    string moveType = FirstLetterToUpper(attributes["MoType"]);
                    string message = "CMD Relative"; 

                    if (moveType == "Joint")
                    {
                        message += moveType + " ";
                        message += attributes["a1"] + " ";
                        message += attributes["a2"] + " ";
                        message += attributes["a3"] + " ";
                        message += attributes["a4"] + " ";
                        message += attributes["a5"] + " ";
                        message += attributes["a6"] + " ";
                        message += attributes["velPercent"];
                    }
                    else if (moveType == "Cartbase")
                    {
                        message += "Base ";
                        message += attributes["x"] + " ";
                        message += attributes["y"] + " ";
                        message += attributes["z"] + " ";
                        message += attributes["e1"] + " ";
                        message += attributes["e2"] + " ";
                        message += attributes["e3"] + " ";
                        message += attributes["vel"];
                    }
                        
                    parsedProgram.Add(message);
                }
                else if (name == "Gripper") 
                {
                    parsedProgram.Add(string.Format("PROG 55 GRIPPER {0} 0.0 0.0", attributes["Position"]));
                }
                else if (name == "Output") 
                {
                    parsedProgram.Add(string.Format("PROG 77 DOUT {0} {1}",
                            attributes["Channel"][attributes["Channel"].Length - 1], 
                            attributes["State"].ToLower())
                    );
                }
                // Wait command
            }

            return parsedProgram;
        }

        public static bool checkIfProgram(string filePath)
        {
            // TODO: expand
            if (filePath == null) return false;

            if (filePath.Split('.')[1] != "xml") return false;

            return true;
        }
        
        private static string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }
    }
}
