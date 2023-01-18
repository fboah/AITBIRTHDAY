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
    public partial class AjoutPoste : Form
    {
        private string Appli = "AITBIRTHDAY";

        private string myChaine;

        private readonly DAOASS mDao = new DAOASS();
        

        private bool myIsAjout;
     
        private CPoste myObjectPoste;


        public AjoutPoste(bool IsAjout, CPoste ObjectPoste, string CH)
        {
            InitializeComponent();
            this.myChaine = CH;

            this.myIsAjout = IsAjout;

            this.myObjectPoste = ObjectPoste;
            
        }

    
        private void AjoutPoste_Load(object sender, EventArgs e)
        {
            try
            {
                if (!myIsAjout)//Modification
                {
                    #region Modification

                    txtCodePoste.Text = myObjectPoste.mCodePoste;
                    txtIntitulePoste.Text = myObjectPoste.mIntitulePoste;
                    rTBDescription.Text = myObjectPoste.mDescription;

                    #endregion
                }
            }
            catch (Exception ex)
            {
                var msg = "AjoutPoste -> AjoutPoste_Load-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
            }
        }

        private void sBtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }


      
        private void sBtnEnregistrer_Click(object sender, EventArgs e)
        {
            //Enregistrer
            try
            {
                bool res = false;

                //Exiger un Code et Libelle Demandeur 

                if (txtIntitulePoste.Text.Trim() == string.Empty || txtCodePoste.Text.Trim() == string.Empty)
                {

                    MessageBox.Show("Veuillez renseigner un Code Poste et Intitulé obligatoirement!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Récupérer la liste des Postes existants pour éviter les doublons
                var ListDem = mDao.getAllPoste(myChaine);

                var IsExist = ListDem.Exists(x => x.mCodePoste.ToUpper().Trim() == txtCodePoste.Text.ToUpper().Trim() && x.mIsDelete == 0);
               // var IsExistModif = ListDem.Exists(x => x.mCodePoste.ToUpper().Trim() == txtCodePoste.Text.ToUpper().Trim() && x.mIntitulePoste.ToUpper().Trim() == txtIntitulePoste.Text.ToUpper().Trim() && x.mDescription.ToUpper().Trim() == rTBDescription.Text.ToUpper().Trim() && x.mIsDelete == 0);


                if (myIsAjout && IsExist)
                {
                    MessageBox.Show("Un Poste avec un code similaire existe déjà!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                //if (IsExistModif)
                //{
                //    MessageBox.Show("Un Poste avec un code similaire existe déjà!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //    return;
                //}

                #region Ajout Poste

                if (myObjectPoste == null && myIsAjout)
                {

                    CPoste CINFOS = new CPoste();

                    CINFOS.mDateCreation = DateTime.Now;
                    CINFOS.mDateLastModification = DateTime.Now;
                    CINFOS.mCodePoste = txtCodePoste.Text;//.Replace("'", "''");
                    CINFOS.mIntitulePoste = txtIntitulePoste.Text;//.Replace("'", "''");
                    CINFOS.mDescription = rTBDescription.Text;//.Replace("'", "''");

                    CINFOS.mUserCreation = Environment.UserDomainName + "\\" + Environment.UserName;
                    CINFOS.mUserLastModification = Environment.UserDomainName + "\\" + Environment.UserName;

                    res = mDao.addPoste(CINFOS, myChaine);

                    if (res)
                    {
                        MessageBox.Show("Poste créé avec succès!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    myObjectPoste.mCodePoste = txtCodePoste.Text;//.Replace("'", "''");
                    myObjectPoste.mIntitulePoste = txtIntitulePoste.Text;//.Replace("'", "''");
                    myObjectPoste.mDescription = rTBDescription.Text;//.Replace("'", "''");

                    myObjectPoste.mDateLastModification = DateTime.Now;
                    myObjectPoste.mUserLastModification = Environment.UserDomainName + "\\" + Environment.UserName;

                    res = mDao.updatePoste(myObjectPoste, myChaine);

                    if (res)
                    {
                        MessageBox.Show("Poste modifié avec succès!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Une erreur est survenue lors de la modification du Poste!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

                #endregion

            }
            catch (Exception ex)
            {
                var msg = "AjoutPoste -> sBtnEnregistrer_Click-> TypeErreur: " + ex.Message;
                CLog.Log(msg);
            }
        }
    }
}
