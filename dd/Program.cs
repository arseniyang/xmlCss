using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            string inputFilePath = @"C:\Users\Admin\Desktop\���������\powershell\������.txt";
            string outputFilePath = @"C:\Users\Admin\Desktop\���������\powershell\phones.xml";
            string outputcssFilePath = @"C:\Users\Admin\Desktop\���������\powershell\tt.css";


            // ������ ������ �� �������� ����� 
            string[] lines = File.ReadAllLines(inputFilePath);

            // �������� XML ��������� 
            XmlDocument xmlDoc = new XmlDocument();

            // �������� ��������� �������� 
            XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
            xmlDoc.AppendChild(xmlDeclaration);

            // ���������� ������, ����������� XML ���� � CSS ������
            XmlProcessingInstruction pi = xmlDoc.CreateProcessingInstruction("xml-stylesheet", "type=\"text/css\" href=\"tt.css\""); xmlDoc.AppendChild(pi);
            XmlElement root = xmlDoc.CreateElement("telef");
            xmlDoc.AppendChild(root);

          

           




            xmlDoc.AppendChild(root);

            foreach (string line in lines)
            {
                string[] data = line.Split(',');

                XmlElement tele = xmlDoc.CreateElement("tele");
                root.AppendChild(tele);

                XmlElement nazv = xmlDoc.CreateElement("nazv");
                nazv.InnerText = data[0];
                tele.AppendChild(nazv);

                XmlElement izgot = xmlDoc.CreateElement("izgot");
                izgot.InnerText = data[1];
                tele.AppendChild(izgot);

                XmlElement color = xmlDoc.CreateElement("color");
                color.InnerText = data[2];
                tele.AppendChild(color);

                XmlElement display = xmlDoc.CreateElement("display");
                display.InnerText = data[3];
                tele.AppendChild(display);

                XmlElement corpus = xmlDoc.CreateElement("corpus");
                corpus.InnerText = data[4];
                tele.AppendChild(corpus);

                XmlElement year = xmlDoc.CreateElement("year");
                year.InnerText = data[5];
                tele.AppendChild(year);

                XmlElement timecharge = xmlDoc.CreateElement("timecharge");
                timecharge.InnerText = data[6];
                tele.AppendChild(timecharge);

                XmlElement timework = xmlDoc.CreateElement("timework");
                timework.InnerText = data[7];
                tele.AppendChild(timework);

                XmlElement chehol = xmlDoc.CreateElement("chehol");
                chehol.InnerText = data[8];
                tele.AppendChild(chehol);

                //��� ������������, ����� �������, ����� ������ � ��������, �����. 


            }

            // ���������� XML-��������� � �������� ���� 
            xmlDoc.Save(outputFilePath);
            Console.WriteLine("������ ������� ��������� � ���� phones.xml");

            string css = "/* CSS styles */\n" +

                         "telef { display: flex; flex-wrap: wrap; color: red; background-color: pink}\n" +
                         "tele { width: 30%; margin: 1%; padding: 1%; border: 1px solid black; }\n" +
                         "nazv { font-weight: bold; }\n" +
                         "izgot { font-style: italic; }\n" +
                         "color { }\n" +
                         "display { font-size: smaller; }\n" +
                         "corpus { font-size: smaller; }\n" +
                         "year { font-size: smaller; }\n" +
                         "timecharge { font-size: smaller; }\n" +
                         "timework { font-size: smaller; }\n" +
                         "chehol { font-size: smaller; }\n";

            File.WriteAllText(outputcssFilePath, css);
            //�������� ������ � 10-� ��������� �� ������� ����� � ��������� ����� �������, ��� ������-�������.
            Console.ReadKey();
            
        }
       

    }
}

