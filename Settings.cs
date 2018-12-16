//USING RELEVANT LIBRARIES
using System;
using System.Windows.Forms;

/*CLASS DOCUMENTATION: This class calls the different forms which are responsible
 *for all the functionalities provided by the settings option.*/

//STARTING HERE
namespace CourseworkTrial3
{
    public partial class Settings : Form
    {
        //STATIC STRING IS URL 
        public static string URL;
        public Settings()
        {
            //INITIALIZE
            InitializeComponent();
        }

        //OPEN THE FORM TO MODIFY THE HOMEPAGE
        private void buttonModifyHomepage_Click(object sender, EventArgs e)
        {
            ModifyHomepage obj = new ModifyHomepage();
            obj.ShowDialog();
        }

        //OPEN THE FORM TO VIEW THE HISTORY
        private void buttonViewHistory_Click(object sender, EventArgs e)
        {
            ViewHistory obj = new ViewHistory();
            obj.ShowDialog();
        }

        //OPEN THE FORM TO MODIFY THE FAVORITES
        private void buttonModifyFav_Click(object sender, EventArgs e)
        {
            ModifyFavorites obj = new ModifyFavorites();
            obj.ShowDialog();
        }
    }
    //END OF SETTINGS
}
