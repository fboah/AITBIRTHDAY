using AITBirthday.DAO;
using AITBirthday.Models;
using AITBirthday.Utils;
using DevExpress.XtraEditors;
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
    public partial class AjoutAnniversaire : Form
    {
        private string Appli = "AITBIRTHDAY";

        private string myChaine;

        private readonly DAOASS mDao = new DAOASS();

        private bool myIsAjout;

        private CEmploye myObjectPoste;

        private List<CPoste> myListePoste;
        private List<CEntiteAITEK> myListeEntiteAITEK;
        private List<CDirection> myListeDirection;

        public AjoutAnniversaire(bool IsAj, CEmploye Cemp,string CH, List<CDirection> LDIR, List<CEntiteAITEK> LEA , List<CPoste> LP)
        {
            InitializeComponent();

            this.myChaine = CH;
            this.myListeDirection = LDIR;
            this.myListeEntiteAITEK = LEA;
            this.myListePoste = LP;
            this.myIsAjout = IsAj;
            this.myObjectPoste = Cemp;
        }


        public void FillComboListPoste(LookUpEdit cmb, List<CPoste> LP)
        {
            try
            {
                cmb.Properties.DataSource = LP;

                cmb.Properties.ValueMember = "mId";

                cmb.Properties.DisplayMember = "mIntitulePoste";
                
                 cmb.ItemIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                var msg = "AjoutEntiteAITEK -> FillComboListPoste-> TypeErreur: " + ex.Message;
                CLog.Log(msg);

            }

        }

        public void FillComboListDirection(LookUpEdit cmb, List<CDirection> LP)
        {
            try
            {
                cmb.Properties.DataSource = LP;

                cmb.Properties.ValueMember = "mId";

                cmb.Properties.DisplayMember = "mIntituleDirection";
                
                 cmb.ItemIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                var msg = "AjoutEntiteAITEK -> FillComboListPoste-> TypeErreur: " + ex.Message;
                CLog.Log(msg);

            }

        }

        public void FillComboListEntiteAITEK(LookUpEdit cmb, List<CEntiteAITEK> LP)
        {
            try
            {
                cmb.Properties.DataSource = LP;

                cmb.Properties.ValueMember = "mId";

                cmb.Properties.DisplayMember = "mLibelleEntiteAITEK";
            
                 cmb.ItemIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                var msg = "AjoutEntiteAITEK -> FillComboListPoste-> TypeErreur: " + ex.Message;
                CLog.Log(msg);

            }

        }


        private void AjoutAnniversaire_Load(object sender, EventArgs e)
        {
            try
            {

                var datedefautlt = DateTime.Parse("01/01/1900");

                var ListePays = mDao.getAllPays(myChaine);

                var ListePoste = mDao.getAllPoste(myChaine);

                var ListeEntiteAITEK = mDao.getAllEntiteAITEK(myChaine, ListePays);

                var ListeDirection = mDao.getAllDirection(myChaine);
                
                FillComboListPoste(CmbPoste, ListePoste.OrderBy(c=>c.mIntitulePoste).ToList());
                FillComboListDirection(CmbDirection, ListeDirection.OrderBy(c => c.mIntituleDirection).ToList());
                FillComboListEntiteAITEK(CmbEntiteAITEK, ListeEntiteAITEK.OrderBy(c => c.mLibelleEntiteAITEK).ToList());

                dateNaissance.EditValue = datedefautlt;

                //CmbPays.EditValue = 52;

                if (!myIsAjout)//Modification
                {
                    #region Modification

                    txtNom.Text = myObjectPoste.mNom;
                    txtPrenom.Text = myObjectPoste.mPrenoms;
                    txtEmail.Text = myObjectPoste.mEmail;
                    CmbPoste.EditValue = myObjectPoste.mIdPoste;
                    CmbDirection.EditValue = myObjectPoste.mIdDirection;
                    CmbEntiteAITEK.EditValue = myObjectPoste.mIdEntiteAITEK;
                    dateNaissance.EditValue = myObjectPoste.mDateNaissance;

                    #endregion
                }
            }
            catch (Exception ex)
            {
                var msg = "AjoutAnniversaire -> AjoutAnniversaire_Load-> TypeErreur: " + ex.Message;
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

                //if (txtNom.Text.Trim() == string.Empty || txtPrenom.Text.Trim() == string.Empty || txtEmail.Text.Trim() == string.Empty)
                if (txtNom.Text.Trim() == string.Empty || txtPrenom.Text.Trim() == string.Empty )
                {

                    MessageBox.Show("Veuillez renseigner le Nom,Prénom et Email obligatoirement!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Récupérer la liste des Postes existants pour éviter les doublons
                var ListDem = mDao.getAllEmploye(myChaine);

                var IsExist = ListDem.Exists(x => x.mEmail.ToUpper().Trim() == txtEmail.Text.ToUpper().Trim() && x.mIsDelete == 0 && x.mNom.ToUpper().Trim() == txtNom.Text.ToUpper().Trim() && x.mPrenoms.ToUpper().Trim() == txtPrenom.Text.ToUpper().Trim());
                //var IsExistModif = ListDem.Exists(x => x.mNom.ToUpper().Trim() == txtNom.Text.ToUpper().Trim() && x.mPrenoms.ToUpper().Trim() == txtPrenom.Text.ToUpper().Trim() && x.mEmail.ToUpper().Trim() == txtEmail.Text.ToUpper().Trim() && x.mIsDelete == 0);


                if (myIsAjout && IsExist)
                {
                    MessageBox.Show("Un Employé avec un Email similaire existe déjà!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                //if (IsExistModif)
                //{
                //    MessageBox.Show("Un Employé avec un Email similaire existe déjà!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //    return;
                //}

                #region Ajout Employe

                if (myObjectPoste == null && myIsAjout)
                {

                    CEmploye CINFOS = new CEmploye();

                    CINFOS.mDateCreation = DateTime.Now;
                    CINFOS.mDateLastModification = DateTime.Now;
                    CINFOS.mNom = txtNom.Text;//.Replace("'", "''");
                    CINFOS.mPrenoms = txtPrenom.Text;//.Replace("'", "''");
                    CINFOS.mEmail = txtEmail.Text;//.Replace("'", "''");

                    CINFOS.mDateNaissance =DateTime.Parse( dateNaissance.EditValue.ToString());
                    CINFOS.mIdDirection = Int32.Parse(CmbDirection.EditValue.ToString());
                    CINFOS.mIdPoste = Int32.Parse(CmbPoste.EditValue.ToString());
                    CINFOS.mIdEntiteAITEK = Int32.Parse(CmbEntiteAITEK.EditValue.ToString());

                    CINFOS.mUserCreation = Environment.UserDomainName + "\\" + Environment.UserName;
                    CINFOS.mUserLastModification = Environment.UserDomainName + "\\" + Environment.UserName;

                    res = mDao.addEmploye(CINFOS, myChaine);

                    if (res)
                    {
                        MessageBox.Show("Anniversaire créé avec succès!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    myObjectPoste.mNom = txtNom.Text;//.Replace("'", "''");
                    myObjectPoste.mPrenoms = txtPrenom.Text;//.Replace("'", "''");
                    myObjectPoste.mEmail = txtEmail.Text;//.Replace("'", "''");

                    myObjectPoste.mDateLastModification = DateTime.Now;
                    myObjectPoste.mUserLastModification = Environment.UserDomainName + "\\" + Environment.UserName;
                    
                    myObjectPoste.mDateNaissance = DateTime.Parse(dateNaissance.EditValue.ToString());
                    myObjectPoste.mIdDirection = Int32.Parse(CmbDirection.EditValue.ToString());
                    myObjectPoste.mIdPoste = Int32.Parse(CmbPoste.EditValue.ToString());
                    myObjectPoste.mIdEntiteAITEK = Int32.Parse(CmbEntiteAITEK.EditValue.ToString());


                    res = mDao.updateEmploye(myObjectPoste, myChaine);

                    if (res)
                    {
                        MessageBox.Show("Anniversaire modifié avec succès!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Une erreur est survenue lors de la modification de l'Anniversaire!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void sBtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
