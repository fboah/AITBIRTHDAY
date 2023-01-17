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

namespace AITBirthday.UI.Direction
{
    public partial class FenDirection : Form
    {
        private string myChaine;
        //Tester si on ajoute ou modif 
        private bool IsAjout;

        private string Appli = "AITBIRTHDAY";

        private readonly DAOASS mDao = new DAOASS();



        public FenDirection(string CH)
        {
            InitializeComponent();
            this.myChaine = CH;
        }

       
        private void FenDirection_Load(object sender, EventArgs e)
        {
            try
            {
                ReloadGrid();
            }
            catch (Exception ex)
            {
                var msg = "FenDirection -> FenDirection_Load-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
            }
        }


      
        public void ReloadGrid()
        {
            try
            {
                var ListeDirection = mDao.getAllDirection(myChaine);

                gCDirection.DataSource = ListeDirection.OrderBy(c => c.mCodeDirection).ToList();
            }
            catch (Exception ex)
            {
                var msg = "FenDirection -> ReloadGrid-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
            }

        }


       
        private void sBtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                IsAjout = true;

                var FenAjoutDirection = new AjoutDirection(IsAjout, null, myChaine);

                FenAjoutDirection.ShowDialog();

                ReloadGrid();
            }
            catch (Exception ex)
            {
                var msg = "FenDirection -> sBtnAjouter_Click-> TypeErreur: " + ex.Message;
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
                    var codDem = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mCodeDirection").ToString());

                    //Récupérer les infos du user connecté pour mettre aussi les commentaires dans la bonne case

                    var mDateModif = DateTime.Now;

                    var mUserModification = Environment.UserDomainName + "\\" + Environment.UserName;

                    if (Identif > 0)
                    {
                        var rep = MessageBox.Show("Voulez-vous supprimer la direction " + codDem.ToString() + " selectionné ?", Appli, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (rep == DialogResult.Yes)
                        {
                            ////Vérifier qu'il n'y a pas de Candidat qui a ce demandeur

                            //bool retour = IsAffectCandidatDemandeur(Identif);

                            //if (retour)
                            //{
                            //    MessageBox.Show("Ce Demandeur est affecté à un(des) candidat(s).On ne peut pas le supprimer!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            //    return;
                            //}


                            ret = mDao.deleteDirection(Identif, myChaine);

                            if (ret)
                            {
                                // if (splashScreenManager1.IsSplashFormVisible) splashScreenManager1.CloseWaitForm();
                                MessageBox.Show("Direction supprimé avec succès!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var msg = "FenDirection -> sBtnSupprimer_Click-> TypeErreur: " + ex.Message;
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
                    CDirection ClientOp = new CDirection();

                    var Identif = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mId").ToString());
                    var CodePoste = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mCodeDirection").ToString();
                    var LibellePoste = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mIntituleDirection").ToString();
                    var DescriptionPoste = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mDescription").ToString();

                    ClientOp.mId = Identif;
                    ClientOp.mCodeDirection = CodePoste;
                    ClientOp.mIntituleDirection = LibellePoste;
                    ClientOp.mDescription = DescriptionPoste;

                    ClientOp.mDateLastModification = DateTime.Now;
                    ClientOp.mUserLastModification = Environment.UserDomainName + "\\" + Environment.UserName;


                    var Fen = new AjoutDirection(IsAjout, ClientOp, myChaine);
                    //var Fen = new AjoutDemandeur();

                    Fen.Text = "Modifier une Direction";
                    Fen.ShowDialog();
                    ReloadGrid();

                }
            }
            catch (Exception ex)
            {
                var msg = "FenDirection -> sBtnModifier_Click-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
            }

        }
    }
}
