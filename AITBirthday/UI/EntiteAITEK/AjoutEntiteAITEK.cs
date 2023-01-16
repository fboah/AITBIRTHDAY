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

namespace AITBirthday.UI.EntiteAITEK
{
    public partial class AjoutEntiteAITEK : Form
    {
        private string Appli = "AITBIRTHDAY";

        private string myChaine;

        private readonly DAOASS mDao = new DAOASS();

        private bool myIsAjout;

        private CEntiteAITEK myObjectPoste;

        private List<CPays> myListePays;


        public AjoutEntiteAITEK(bool IsAjout, CEntiteAITEK ObjectPoste, string CH,  List<CPays> LP)
        {
            InitializeComponent();

            this.myChaine = CH;

            this.myIsAjout = IsAjout;

            this.myObjectPoste = ObjectPoste;
            this.myListePays = LP;
        }


        public void FillComboListPAYS(LookUpEdit cmb, List<CPays> LPAYS)
        {
            try
            {
                cmb.Properties.DataSource = LPAYS;

                cmb.Properties.ValueMember = "mId";

                cmb.Properties.DisplayMember = "mLibellePays";

                cmb.ItemIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                var msg = "AjoutEntiteAITEK -> FillComboListPAYS-> TypeErreur: " + ex.Message;
                CLog.Log(msg);

            }

        }



        private void AjoutEntiteAITEK_Load(object sender, EventArgs e)
        {
            try
            {

                FillComboListPAYS(CmbPays, myListePays);

                CmbPays.EditValue = 52;

                if (!myIsAjout)//Modification
                {
                    #region Modification

                    txtLibelleEntiteAITEK.Text = myObjectPoste.mLibelleEntiteAITEK;
                    CmbPays.EditValue = myObjectPoste.mIdPays;
                    
                    #endregion
                }
            }
            catch (Exception ex)
            {
                var msg = "AjoutPoste -> AjoutDemandeur_Load-> TypeErreur: " + ex.Message;
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

                if ( txtLibelleEntiteAITEK.Text.Trim() == string.Empty)
                {

                    MessageBox.Show("Veuillez renseigner un Intitulé obligatoirement!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Récupérer la liste des Postes existants pour éviter les doublons
                var ListDem = mDao.getAllEntiteAITEK(myChaine,myListePays);

                var IsExist = ListDem.Exists(x => x.mLibelleEntiteAITEK.ToUpper().Trim() == txtLibelleEntiteAITEK.Text.ToUpper().Trim() && x.mIsDelete == 0);
                var IsExistModif = ListDem.Exists(x => x.mLibelleEntiteAITEK.ToUpper().Trim() == txtLibelleEntiteAITEK.Text.ToUpper().Trim() && x.mIdPays ==Int32.Parse( CmbPays.EditValue.ToString())  && x.mIsDelete == 0);


                if (myIsAjout && IsExist)
                {
                    MessageBox.Show("Une Entité AITEK avec un libelle et un pays similaires existe déjà!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                if (IsExistModif)
                {
                    MessageBox.Show("Une Entité AITEK avec un libelle et un pays similaires existe déjà!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                #region Ajout Entité AITEK

                if (myObjectPoste == null && myIsAjout)
                {

                    CEntiteAITEK CINFOS = new CEntiteAITEK();

                    CINFOS.mDateCreation = DateTime.Now;
                    CINFOS.mDateLastModification = DateTime.Now;
                    CINFOS.mLibelleEntiteAITEK = txtLibelleEntiteAITEK.Text;//.Replace("'", "''");

                    CINFOS.mIdPays = Int32.Parse(CmbPays.EditValue.ToString());
                    CINFOS.mUserCreation = Environment.UserDomainName + "\\" + Environment.UserName;
                    CINFOS.mUserLastModification = Environment.UserDomainName + "\\" + Environment.UserName;

                    res = mDao.addEntiteAITEK(CINFOS, myChaine);

                    if (res)
                    {
                        MessageBox.Show("Entité AITEK créée avec succès!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    myObjectPoste.mLibelleEntiteAITEK = txtLibelleEntiteAITEK.Text;//.Replace("'", "''");
                    myObjectPoste.mIdPays = Int32.Parse(CmbPays.EditValue.ToString());

                    myObjectPoste.mDateLastModification = DateTime.Now;
                    myObjectPoste.mUserLastModification = Environment.UserDomainName + "\\" + Environment.UserName;

                    res = mDao.updateEntiteAITEK(myObjectPoste, myChaine);

                    if (res)
                    {
                        MessageBox.Show("Entité AITEK modifiée avec succès!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
