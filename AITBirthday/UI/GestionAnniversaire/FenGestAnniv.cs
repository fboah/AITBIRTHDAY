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

        private void sBtnSupprimer_Click(object sender, EventArgs e)
        {
            bool ret = false;

            try
            {
                if (gridView1.DataRowCount > 0)
                {

                    var Identif = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mId").ToString());
                    var NomEmpl = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mNom").ToString());
                    var PrenomEmpl = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mPrenoms").ToString());

                    //Récupérer les infos du user connecté pour mettre aussi les commentaires dans la bonne case

                    var mDateModif = DateTime.Now;

                    var mUserModification = Environment.UserDomainName + "\\" + Environment.UserName;

                    if (Identif > 0)
                    {
                        var rep = MessageBox.Show("Voulez-vous supprimer l'anniversaire de: " + NomEmpl.ToString() +" "+PrenomEmpl.ToString()+ " selectionné ?", Appli, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (rep == DialogResult.Yes)
                        {
                            ////Vérifier qu'il n'y a pas de Candidat qui a ce demandeur

                            //bool retour = IsAffectCandidatDemandeur(Identif);

                            //if (retour)
                            //{
                            //    MessageBox.Show("Ce Demandeur est affecté à un(des) candidat(s).On ne peut pas le supprimer!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            //    return;
                            //}


                            ret = mDao.deleteEmploye(Identif, myChaine);

                            if (ret)
                            {
                                // if (splashScreenManager1.IsSplashFormVisible) splashScreenManager1.CloseWaitForm();
                                MessageBox.Show("Anniversaire supprimé avec succès!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var msg = "FenPoste -> sBtnSupprimer_Click-> TypeErreur: " + ex.Message;
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
                    CEmploye ClientOp = new CEmploye();

                    var Identif = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mId").ToString());

                    var NomEmpl = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mNom").ToString());
                    var PrenomEmpl = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mPrenoms").ToString());

                    var IdDirection = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mIdDirection").ToString());
                    var IdPoste = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mIdPoste").ToString());
                    var IdEntiteAITEK = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mIdEntiteAITEK").ToString());
                    var IsDelete = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mIsDelete").ToString());
                    
                    var Email = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mEmail").ToString();
                    var DateNaissance = DateTime.Parse( gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mDateNaissance").ToString());

                    
                    ClientOp.mId = Identif;
                    ClientOp.mNom = NomEmpl;
                    ClientOp.mPrenoms = PrenomEmpl;
                    ClientOp.mIdDirection = IdDirection;
                    ClientOp.mIdEntiteAITEK = IdEntiteAITEK;
                    ClientOp.mIsDelete = IsDelete;

                    ClientOp.mIdPoste = IdPoste;
                    ClientOp.mEmail = Email;
                    ClientOp.mDateNaissance = DateNaissance;

                    ClientOp.mDateLastModification = DateTime.Now;
                    ClientOp.mUserLastModification = Environment.UserDomainName + "\\" + Environment.UserName;
                    
                    var FenAjoutPoste = new AjoutAnniversaire(IsAjout, ClientOp, myChaine, myListeDirection, myListeEntiteAITEK, myListePoste);
                    

                    FenAjoutPoste.Text = "Modifier un Anniversaire";
                    FenAjoutPoste.ShowDialog();
                    ReloadGrid();

                }
            }
            catch (Exception ex)
            {
                var msg = "FenPoste -> sBtnModifier_Click-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
            }

        }
    }
}
