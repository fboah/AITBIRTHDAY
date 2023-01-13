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

namespace AITBirthday.UI.Poste
{
    public partial class FenPoste : Form
    {
        private string myChaine;
        //Tester si on ajoute ou modif 
        private bool IsAjout;

        private string Appli = "AITBIRTHDAY";

        private readonly DAOASS mDao = new DAOASS();


        public FenPoste(string CH)
        {
            InitializeComponent();

            this.myChaine = CH;
        }

        private void sBtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                IsAjout = true;
                
                var FenAjoutPoste = new AjoutPoste(IsAjout, null, myChaine);
                
                FenAjoutPoste.ShowDialog();

                ReloadGrid();
            }
            catch (Exception ex)
            {
                var msg = "FenPoste -> sBtnAjouter_Click-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
            }
        }

        private void FenPoste_Load(object sender, EventArgs e)
        {
            try
            {
                ReloadGrid();
            }
            catch(Exception ex)
            {

            }
        }


        public void ReloadGrid()
        {
            try
            {
                var ListePoste = mDao.getAllPoste(myChaine);

                gcPoste.DataSource = ListePoste.OrderBy(c => c.mCodePoste).ToList();
            }
            catch (Exception ex)
            {
                var msg = "FenDemandeur -> ReloadGrid-> TypeErreur: " + ex.Message;
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
                    var codDem = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mCodePoste").ToString());

                    //Récupérer les infos du user connecté pour mettre aussi les commentaires dans la bonne case

                    var mDateModif = DateTime.Now;

                    var mUserModification = Environment.UserDomainName + "\\" + Environment.UserName;

                    if (Identif > 0)
                    {
                        var rep = MessageBox.Show("Voulez-vous supprimer le Poste " + codDem.ToString() + " selectionné ?", Appli, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (rep == DialogResult.Yes)
                        {
                            ////Vérifier qu'il n'y a pas de Candidat qui a ce demandeur

                            //bool retour = IsAffectCandidatDemandeur(Identif);

                            //if (retour)
                            //{
                            //    MessageBox.Show("Ce Demandeur est affecté à un(des) candidat(s).On ne peut pas le supprimer!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            //    return;
                            //}


                            ret = mDao.deletePoste(Identif, myChaine);

                            if (ret)
                            {
                                // if (splashScreenManager1.IsSplashFormVisible) splashScreenManager1.CloseWaitForm();
                                MessageBox.Show("Poste supprimé avec succès!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void sBtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                IsAjout = false;
                

                if (gridView1.DataRowCount > 0)
                {
                    CPoste ClientOp = new CPoste();

                    var Identif = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mId").ToString());
                    var CodePoste = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mCodePoste").ToString();
                    var LibellePoste = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mIntitulePoste").ToString();
                    var DescriptionPoste = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mDescription").ToString();

                    ClientOp.mId = Identif;
                    ClientOp.mCodePoste = CodePoste;
                    ClientOp.mIntitulePoste = LibellePoste;
                    ClientOp.mDescription = DescriptionPoste;

                    ClientOp.mDateLastModification = DateTime.Now;
                    ClientOp.mUserLastModification = Environment.UserDomainName + "\\" + Environment.UserName;


                    var Fen = new AjoutPoste(IsAjout,  ClientOp, myChaine);
                    //var Fen = new AjoutDemandeur();

                    Fen.Text = "Modifier un Poste";
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
    }
}
