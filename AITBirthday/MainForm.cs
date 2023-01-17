using AITBirthday.DAO;
using AITBirthday.Models;
using AITBirthday.UI.Direction;
using AITBirthday.UI.EntiteAITEK;
using AITBirthday.UI.GestionAnniversaire;
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

        private readonly DAOASS mDao = new DAOASS();

        public List<CPays> ListePays = new List<CPays>();

        public List<CPoste> ListePoste = new List<CPoste>();

        public List<CEntiteAITEK> ListeEntiteAITEK = new List<CEntiteAITEK>();

        public List<CDirection> ListeDirection = new List<CDirection>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                IsMdiContainer = true;

                ListePays = mDao.getAllPays(Chaine);

                ListePoste = mDao.getAllPoste(Chaine);

                ListeEntiteAITEK = mDao.getAllEntiteAITEK(Chaine, ListePays);

                ListeDirection = mDao.getAllDirection(Chaine);
            }
            catch(Exception ex)
            {
                var msg = "MainForm -> MainForm_Load-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
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

        private void directionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var FenCad = new FenDirection(Chaine);

                FenCad.MdiParent = this;

                FenCad.Show();

            }
            catch (Exception ex)
            {
                var msg = "MainForm -> directionToolStripMenuItem_Click-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
            }
        }

        private void entitéAITEKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var FenCad = new FenEntiteAITEK(Chaine, ListePays);

                FenCad.MdiParent = this;

                FenCad.Show();

            }
            catch (Exception ex)
            {
                var msg = "MainForm -> entitéAITEKToolStripMenuItem_Clicks-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
            }
        }

        private void gestionAnniversairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var FenCad = new FenGestAnniv (Chaine, ListePoste, ListeEntiteAITEK, ListeDirection);
                
                FenCad.MdiParent = this;

                FenCad.Show();

            }
            catch (Exception ex)
            {
                var msg = "MainForm -> gestionAnniversairesToolStripMenuItem_Click-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
            }
        }
    }
}
