//USING RELEVANT LIBRARIES
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

/*CLASS DOCUMENTATION: This class calls the favorites XML file, displays and processes it. These functionalities include deletion,
 *navigation and also modification of the name of the URL.*/ 

//STARTING HERE
namespace CourseworkTrial3
{
    public partial class ModifyFavorites : Form
    {
        public static string NameOfNewFavorite;
        public ModifyFavorites()
        {
            //INITIALIZE
            InitializeComponent();

            //SET NEW DATASET
            DataSet ds = new DataSet();
            
            //TRY
            try
            {
                ds.ReadXml("myFavorites.xml");
                dataGridView1.DataSource = ds.Tables[0];
            }
            //IF THE FILE IS NOT FOUND
            catch (Exception)                           //handle exception gracefully
            {
                MessageBox.Show("Favorites is empty!");
                Form1 f1 = (Form1)Application.OpenForms["Form1"];
                f1.Close();
            }
        }

        //DELETE BUTTON IS CLICKED
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Delete from datagridview     
            DataGridViewSelectedRowCollection dgv_rc = dataGridView1.SelectedRows;
            foreach (DataGridViewRow dgv_r in dgv_rc)
            {
                //DELETE ALL IN THE SELECTED COLLECTION
                dataGridView1.Rows.Remove(dgv_r);
            }

            //delete from data source
            int selectedIndex = dataGridView1.CurrentRow.Index;
            string rowID = dataGridView1[0, selectedIndex].Value.ToString();

            //USE LINQ TO GET SELECTED ROWS AND DELETE THEM
            XDocument document = XDocument.Load("myFavorites.xml"); 
            var pageInfo = (from xml in document.Descendants("Details")
                            where xml.Element("Fav_ID").Value == rowID
                            select xml).FirstOrDefault();

            //REMOVE FROM FILE
            pageInfo.Remove();

            //REFLECT CHANGES IN THE FILE
            document.Save("myFavorites.xml");

        }

        //IF THE USER WISHES TO OPEN THE FAVORTIES WEB PAGE
        public void buttonGoToFav_Click(object sender, EventArgs e)
        {
            //CLOSE ALL FORMS EXCEPT MAIN FORM
            ModifyFavorites f1 = (ModifyFavorites)Application.OpenForms["ModifyFavorites"];
            f1.Close();
            Settings f2 = (Settings)Application.OpenForms["Settings"];
            f2.Close();

            //SET SELECTED URL TO THE TEXT BOX
            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            string selectedURL = dataGridView1[2, selectedIndex].Value.ToString();
            Form1.favURL = selectedURL;

            //FLAG IS ONE SO FETCH KNOWS TEXT BOX URL IS COMING FROM FAVORITES.
            Form1.flag = 1;
        }

        //MODIFY NAME OF THE FAVORITE
        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            ModifyFavorite obj = new ModifyFavorite();
            obj.ShowDialog();
            dataGridView1[1, selectedIndex].Value = NameOfNewFavorite;

            //selectedIndex = dataGridView1.CurrentRow.Index;
            string rowID = dataGridView1[0, selectedIndex].Value.ToString();

            XDocument document = XDocument.Load("myFavorites.xml");       //using linq
            var pageInfo = (from xml in document.Descendants("Details")
                            where xml.Element("Fav_ID").Value == rowID
                            select xml).FirstOrDefault();
            pageInfo.Element("Name").Value = NameOfNewFavorite;
            document.Save("myFavorites.xml");

        }
    }
    //END OF MODIFY FAVORITES
}
