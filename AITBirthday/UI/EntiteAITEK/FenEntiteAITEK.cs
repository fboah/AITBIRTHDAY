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

namespace AITBirthday.UI.EntiteAITEK
{
    public partial class FenEntiteAITEK : Form
    {

        private string myChaine;
        //Tester si on ajoute ou modif 
        private bool IsAjout;

        private string Appli = "AITBIRTHDAY";

        private readonly DAOASS mDao = new DAOASS();

        private List<CPays> myListePays;


        public FenEntiteAITEK(string CH, List<CPays> LP)
        {
            InitializeComponent();
            this.myChaine = CH;
            this.myListePays = LP;
        }

        public void ReloadGrid()
        {
            try
            {
                var Listeentite = mDao.getAllEntiteAITEK(myChaine,myListePays);

                gCEntiteAITEK.DataSource = Listeentite.OrderBy(c => c.mLibelleEntiteAITEK).ToList();
            }
            catch (Exception ex)
            {
                var msg = "FenDirection -> ReloadGrid-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
            }

        }

        private void FenEntiteAITEK_Load(object sender, EventArgs e)
        {
            try
            {
                ReloadGrid();
            }
            catch (Exception ex)
            {

            }
        }

        private void sBtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                IsAjout = true;

                var FenAjoutDirection = new AjoutEntiteAITEK(IsAjout, null, myChaine,myListePays);

                FenAjoutDirection.ShowDialog();

                ReloadGrid();
            }
            catch (Exception ex)
            {
                var msg = "FenDirection -> sBtnAjouter_Click-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
            }
        }

        private void sBtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                IsAjout = false;

                if (gridView1.DataRowCount > 0)
                {
                    CEntiteAITEK ClientOp = new CEntiteAITEK();

                    var Identif = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mId").ToString());
                    var IdPays = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mIdPays").ToString());
                    var LibelleAitek = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mLibelleEntiteAITEK").ToString();
                    //var LibellePoste = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mIntituleDirection").ToString();
                    //var DescriptionPoste = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mDescription").ToString();

                    ClientOp.mId = Identif;
                    ClientOp.mIdPays = IdPays;
                    ClientOp.mLibelleEntiteAITEK = LibelleAitek;
                    //ClientOp.mIntituleDirection = LibellePoste;
                    //ClientOp.mDescription = DescriptionPoste;

                    ClientOp.mDateLastModification = DateTime.Now;
                    ClientOp.mUserLastModification = Environment.UserDomainName + "\\" + Environment.UserName;


                    var Fen = new AjoutEntiteAITEK(IsAjout, ClientOp, myChaine,myListePays);
                    //var Fen = new AjoutDemandeur();

                    Fen.Text = "Modifier une Entité AITEK";
                    Fen.ShowDialog();
                    ReloadGrid();

                }
            }
            catch (Exception ex)
            {
                var msg = "FenDemandeur -> sBtnModifier_Click-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
            }

        }

        private void sBtnSupprimer_Click(object sender, EventArgs e)
        {
            bool ret = false;

            try
            {
                if (gridView1.DataRowCount > 0)
                {
                    var Identif = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mId").ToString());
                    var IdPays = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mIdPays").ToString());
                    var codDem = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mLibelleEntiteAITEK").ToString());

                    //Récupérer les infos du user connecté pour mettre aussi les commentaires dans la bonne case

                    var mDateModif = DateTime.Now;

                    var mUserModification = Environment.UserDomainName + "\\" + Environment.UserName;

                    if (Identif > 0)
                    {
                        var rep = MessageBox.Show("Voulez-vous supprimer l'Entité " + codDem.ToString() + " selectionné ?", Appli, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (rep == DialogResult.Yes)
                        {
                            ////Vérifier qu'il n'y a pas de Candidat qui a ce demandeur

                            //bool retour = IsAffectCandidatDemandeur(Identif);

                            //if (retour)
                            //{
                            //    MessageBox.Show("Ce Demandeur est affecté à un(des) candidat(s).On ne peut pas le supprimer!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            //    return;
                            //}


                            ret = mDao.deleteEntiteAITEK(Identif, myChaine);

                            if (ret)
                            {
                                // if (splashScreenManager1.IsSplashFormVisible) splashScreenManager1.CloseWaitForm();
                                MessageBox.Show("Entité AITEK supprimée avec succès!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ReloadGrid();
                            }
                            else
                            {
                                MessageBox.Show("Une erreur est survenue lors de la suppression!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                var msg = "FenDemandeur -> sBtnSupprimer_Click-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
            }
        }
    }
}
