//USING RELEVANT LIBRARIES
using System;
using System.Windows.Forms;

//CLASS DOCUMENTATION: This class creates a new form for the user to modify the selected Favorite.

//STARTING HERE
namespace CourseworkTrial3
{
    public partial class ModifyFavorite : Form
    {
        //INITIALIZE
        public ModifyFavorite()
        {
            InitializeComponent();
        }

        //WHEN BUTTON IS CLICKED
        private void buttonOK_Click(object sender, EventArgs e)
        {
            //SAVE THE TEXT FROM TEXT BOX TO NAME OF NEW FAVORITE
            ModifyFavorites.NameOfNewFavorite = textBoxNewName.Text;

            //CLOSE THIS FORM
            ModifyFavorite f1 = (ModifyFavorite)Application.OpenForms["ModifyFavorite"];
            f1.Close();
        }
    }
    //END OF MODIFY FAVORITE
}
