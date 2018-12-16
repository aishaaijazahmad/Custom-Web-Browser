//USING RELEVANT LIBRARIES
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

/*CLASS DOCUMENTATION: This class calls the myHistory.xml file to display its contents to the datagridview
 *and also then provides various functionalities. These include deletion, navigation as well as clear browsing data.*/ 

//STARTING HERE
namespace CourseworkTrial3
{
    public partial class ViewHistory : Form
    {
        public ViewHistory()
        {
            //INITIALIZE
            InitializeComponent();

            //SET NEW DATASET AS MY HISTORY FILE
            DataSet ds = new DataSet();
                //TRY
                try
                {
                    ds.ReadXml("myHistory.xml");
                    dataGridView1.DataSource = ds.Tables[0];
                }
                //IF FILE NOT FOUND
                catch (Exception)                           //handle exception gracefully
                {
                    MessageBox.Show("History is empty!");
                    Form1 f1 = (Form1)Application.OpenForms["Form1"];
                    f1.Close();
                }
        }

        //IF BUTTON DELETE IS CLICKED
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Delete from datagridview     
            DataGridViewSelectedRowCollection dgv_rc = dataGridView1.SelectedRows;
            foreach (DataGridViewRow dgv_r in dgv_rc)       //FOR EACH IN SELECTED COLLECTION
            {
                dataGridView1.Rows.Remove(dgv_r);
            }

            //delete from data source
            int selectedIndex = dataGridView1.CurrentRow.Index;
            string rowID = dataGridView1[0, selectedIndex].Value.ToString();
            
            //USE LINQ TO FIND THE SELECTED NODES AND REMOVE THEM
            XDocument document = XDocument.Load("myHistory.xml");       //using linq
            var pageInfo = (from xml in document.Descendants("Details")
                            where xml.Element("Web_ID").Value == rowID
                            select xml).FirstOrDefault();

            //REMOVE THEM
            pageInfo.Remove();

            //REFLECT CHANGES PERMANENTLY
            document.Save("myHistory.xml");

        }

        //CLEAR MYHISTORY FILE
        private void button1_Click(object sender, EventArgs e)              //Delete all History
        {  
            dataGridView1.DataSource = null;
            File.Delete("myHistory.xml");
        }

        private void buttonNavigateTo_Click(object sender, EventArgs e)
        {
            //CLOSE ALL FORMS EXCEPT MAIN FORM
            ViewHistory f1 = (ViewHistory)Application.OpenForms["ViewHistory"];
            f1.Close();
            Settings f2 = (Settings)Application.OpenForms["Settings"];
            f2.Close();

            //SET SELECTED URL TO THE TEXT BOX
            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            string selectedURL = dataGridView1[1, selectedIndex].Value.ToString();
            Form1.historyURL = selectedURL;
            
            //FLAG IS ONE SO FETCH KNOWS TEXT BOX URL IS COMING FROM FAVORITES.
            Form1.flag = 2;
        }
    }
    //END OF VIEW HISTORY
}
