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
    public partial class AjoutDirection : Form
    {
        private string Appli = "AITBIRTHDAY";

        private string myChaine;

        private readonly DAOASS mDao = new DAOASS();
        
        private bool myIsAjout;

        private CDirection myObjectPoste;

        public AjoutDirection(bool IsAjout, CDirection ObjectPoste, string CH)
        {
            InitializeComponent();
            this.myChaine = CH;

            this.myIsAjout = IsAjout;

            this.myObjectPoste = ObjectPoste;
        }


      
        private void AjoutDirection_Load(object sender, EventArgs e)
        {
            try
            {
                if (!myIsAjout)//Modification
                {
                    #region Modification

                    txtCodeDirection.Text = myObjectPoste.mCodeDirection;
                    txtIntituleDirection.Text = myObjectPoste.mIntituleDirection;
                    rTBDescription.Text = myObjectPoste.mDescription;

                    #endregion
                }
            }
            catch (Exception ex)
            {
                var msg = "AjoutDirection -> AjoutDirection_Load-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
            }
        }


      
        private void sBtnEnregistrer_Click(object sender, EventArgs e)
        {
            //Enregistrer
            try
            {
                bool res = false;

                //Exiger un Code et Libelle Demandeur 

                if (txtCodeDirection.Text.Trim() == string.Empty || txtIntituleDirection.Text.Trim() == string.Empty)
                {

                    MessageBox.Show("Veuillez renseigner un Code Direction et Intitulé obligatoirement!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Récupérer la liste des Postes existants pour éviter les doublons
                var ListDem = mDao.getAllDirection(myChaine);

                var IsExist = ListDem.Exists(x => x.mCodeDirection.ToUpper().Trim() == txtCodeDirection.Text.ToUpper().Trim() && x.mIsDelete == 0);
               // var IsExistModif = ListDem.Exists(x => x.mCodeDirection.ToUpper().Trim() == txtCodeDirection.Text.ToUpper().Trim() && x.mIntituleDirection.ToUpper().Trim() == txtIntituleDirection.Text.ToUpper().Trim() && x.mDescription.ToUpper().Trim() == rTBDescription.Text.ToUpper().Trim() && x.mIsDelete == 0);


                if (myIsAjout && IsExist)
                {
                    MessageBox.Show("Une Direction avec un code similaire existe déjà!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                //if (IsExistModif)
                //{
                //    MessageBox.Show("Une Direction avec un code similaire existe déjà!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //    return;
                //}

                #region Ajout Direction

                if (myObjectPoste == null && myIsAjout)
                {

                    CDirection CINFOS = new CDirection();

                    CINFOS.mDateCreation = DateTime.Now;
                    CINFOS.mDateLastModification = DateTime.Now;
                    CINFOS.mCodeDirection = txtCodeDirection.Text;//.Replace("'", "''");
                    CINFOS.mIntituleDirection = txtIntituleDirection.Text;//.Replace("'", "''");
                    CINFOS.mDescription = rTBDescription.Text;//.Replace("'", "''");

                    CINFOS.mUserCreation = Environment.UserDomainName + "\\" + Environment.UserName;
                    CINFOS.mUserLastModification = Environment.UserDomainName + "\\" + Environment.UserName;

                    res = mDao.addDirection(CINFOS, myChaine);

                    if (res)
                    {
                        MessageBox.Show("Direction créée avec succès!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Une erreur est survenue!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                #endregion

                #region Modification

                if (myObjectPoste != null)
                {
                    myObjectPoste.mCodeDirection = txtCodeDirection.Text;//.Replace("'", "''");
                    myObjectPoste.mIntituleDirection = txtIntituleDirection.Text;//.Replace("'", "''");
                    myObjectPoste.mDescription = rTBDescription.Text;//.Replace("'", "''");

                    myObjectPoste.mDateLastModification = DateTime.Now;
                    myObjectPoste.mUserLastModification = Environment.UserDomainName + "\\" + Environment.UserName;

                    res = mDao.updateDirection(myObjectPoste, myChaine);

                    if (res)
                    {
                        MessageBox.Show("Direction modifiée avec succès!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Une erreur est survenue lors de la modification d'une Direction!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

                #endregion

            }
            catch (Exception ex)
            {
                var msg = "AjoutDirection -> sBtnEnregistrer_Click-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
            }
        }

        private void sBtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
