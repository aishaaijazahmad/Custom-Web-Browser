//USING RELEVANT LIBRARIES
using System;
using System.IO;
using System.Windows.Forms;

/*CLASS DOCUMENTATION: This class modifies the homepage given by the user.*/

//STARTING HERE
namespace CourseworkTrial3
{
    public partial class ModifyHomepage : Form
    {
        public ModifyHomepage()
        {
            //INITIALIZE
            InitializeComponent();
        }

        //CLICK BUTTON TO SUBMIT NEW HOMEPAGE
        private void buttonOK_Click(object sender, EventArgs e)
        {
            //GET NEW HOMEPAGE
            Form1.HomepageURL = textBoxNewHomepage.Text;

            //REPLACE IN THE TEXT FILE
            File.WriteAllText("homepageURL.txt", String.Empty);
            File.WriteAllText("homepageURL.txt", Form1.HomepageURL);

            //CONFIRMATION MESSAGE FOR THE USER
            MessageBox.Show("The HomePage is set to " + Form1.HomepageURL);
        }
    }
    //END OF MODIFY HOMEPAGE
}
