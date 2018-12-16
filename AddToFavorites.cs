//USING RELEVANT LIBRARIES
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

/*CLASS DOCUMENTATION: This class is responsible for initializing the form which 
 *adds a new entry to the favorites list.*/

//STARTING HERE
namespace CourseworkTrial3
{
    public partial class AddToFavorites : Form
    {
        //INITIALIZE STATIC VARIABLE FAVCOUNT
        private static int favCount;

        public AddToFavorites()
        {
            //INITIALIZE
            InitializeComponent();

            //GET ALL FAVCOUNT FROM THE FILE
            string favCountstr = File.ReadAllText("favCount.txt");
            favCount = Convert.ToInt32(favCountstr);
        }

        private void buttonAddFav_Click(object sender, EventArgs e)
        {
            //GET NEW NAME AND URL
            string Name = textBoxAddName.Text;
            string URL = textBoxFavURL.Text;
            
            //CHECK IF THE FILE EXISTS
            if (!File.Exists("myFavorites.xml"))
            {
                //IF FILE DOES NOT EXIST, CREATE NEW FILE AND ADD FIRST ENTRY
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.NewLineOnAttributes = true;
                using (XmlWriter xmlWriter = XmlWriter.Create("myFavorites.xml", xmlWriterSettings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("Favorites");

                    xmlWriter.WriteStartElement("Details");
                    xmlWriter.WriteElementString("Fav_ID", favCount.ToString());
                    xmlWriter.WriteElementString("Name", Name);
                    xmlWriter.WriteElementString("URL", URL);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Flush();
                    xmlWriter.Close();
                }
            }
            else
            {
                //IF FILE EXISTS, ADD NEW ENTRY
                XDocument xDocument = XDocument.Load("myFavorites.xml");
                XElement root = xDocument.Element("Favorites");
                IEnumerable<XElement> rows = root.Descendants("Details");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement("Details",
                   new XElement("Fav_ID", favCount.ToString()),
                   new XElement("Name", Name),
                   new XElement("URL", URL)));
                xDocument.Save("myFavorites.xml");
            }

            //INCREMENT FAVCOUNT
            favCount++;

            //REPLACE OLD FAV COUNT
            File.WriteAllText("favCount.txt", String.Empty);
            File.WriteAllText("favCount.txt", favCount.ToString());

            //CONFIRMATION MESSAGE TO THE USER
            MessageBox.Show(Name + " added to Favorites!");

            //CLEAR THE FORM IN CASE USER WANTS TO ADD MORE ENTRIES
            textBoxAddName.Clear();
            textBoxFavURL.Clear();
        }
    }
    //END OF ADD TO FAVORITES 
}
