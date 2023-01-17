using AITBirthday.DAO;
using AITBirthday.Models;
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

namespace AITBirthday.UI.GestionAnniversaire
{
    public partial class FenGestAnniv : Form
    {
        private string myChaine;
        //Tester si on ajoute ou modif 
        private bool IsAjout;

        private string Appli = "AITBIRTHDAY";

        private readonly DAOASS mDao = new DAOASS();

        private List<CPoste> myListePoste;
        private List<CEntiteAITEK> myListeEntiteAITEK;
        private List<CDirection> myListeDirection;


        public FenGestAnniv(string CH, List<CPoste> LP, List<CEntiteAITEK> ListeEntiteAITEK, List<CDirection> LD)
        {
            InitializeComponent();

            this.myChaine = CH;
            this.myListeDirection = LD;
            this.myListeEntiteAITEK = ListeEntiteAITEK;
            this.myListePoste = LP;
        }


        public void ReloadGrid()
        {
            try
            {
                var Listeentite = mDao.getAllEmploye(myChaine);

                gCAnniversaire.DataSource = Listeentite.OrderBy(c => c.mNom).ToList();
            }
            catch (Exception ex)
            {
                var msg = "FenGestAnniv -> ReloadGrid-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
            }

        }

        private void FenGestAnniv_Load(object sender, EventArgs e)
        {
            try
            {
                ReloadGrid();
            }
            catch (Exception ex)
            {
                var msg = "FenGestAnniv -> ReloadGrid-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
            }

        }

        private void sBtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                IsAjout = true;
               
                var FenAjoutPoste = new AjoutAnniversaire(IsAjout, null, myChaine, myListeDirection, myListeEntiteAITEK, myListePoste);
                
                FenAjoutPoste.ShowDialog();

                ReloadGrid();
            }
            catch (Exception ex)
            {
                var msg = "FenGestAnniv -> sBtnAjouter_Click-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
            }
        }
    }
}
