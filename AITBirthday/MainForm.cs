using AITBirthday.UI.Poste;
using AITBirthday.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AITBirthday
{
    public partial class MainForm : Form
    {
        private string Chaine = @"Initial Catalog=AITSOFTWARE;Data Source=FRANCK\SAGE300;Integrated Security=SSPI";
      //  private string Chaine = @"Initial Catalog=AITSOFTWARE;Data Source=NATSQL02\SAGE100C;user=SA;password=$AGE100";


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                IsMdiContainer = true;
            }
            catch(Exception ex)
            {

            }
        }

        private void posteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var FenCad = new FenPoste(Chaine);

                FenCad.MdiParent = this;

                FenCad.Show();

            }
            catch (Exception ex)
            {
                var msg = "MainForm -> posteToolStripMenuItem_Click-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
            }
        }
    }
}
