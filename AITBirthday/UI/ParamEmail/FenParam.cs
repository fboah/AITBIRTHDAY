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

namespace AITBirthday.UI.ParamEmail
{
    public partial class FenParam : Form
    {
        private string myChaine;
        //Tester si on ajoute ou modif 
        private bool IsAjout;

        private string Appli = "AITBIRTHDAY";

        private List<CParams> ListeParams;

        private readonly DAOASS mDao = new DAOASS();


        public FenParam(string CH,List<CParams> LP,bool IA)
        {
            InitializeComponent();

            this.myChaine = CH;
            this.ListeParams = LP;
            this.IsAjout = IA;
        }

        private void FenParam_Load(object sender, EventArgs e)
        {
            try
            {
                if(!IsAjout)
                {
                    var CRet = ListeParams.FirstOrDefault();

                    txtMail.Text = CRet.mEmail;
                    txtSmtp.Text = CRet.mSmtp;
                    txtSmtpPassword.Text = CRet.mSmtpPassword;
                    sNumPort.EditValue = CRet.mPort;
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void sBtnEnregistrer_Click(object sender, EventArgs e)
        {
            //Enregistrer
            try
            {
                bool res = false;

                //Exiger un Code et Libelle Demandeur 

                if (txtMail.Text.Trim() == string.Empty || txtSmtp.Text.Trim() == string.Empty || txtSmtpPassword.Text.Trim() == string.Empty)
                {

                    MessageBox.Show("Veuillez renseigner tous les champs obligatoirement!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                #region Ajout Employe
                

                if ( IsAjout)
                {

                    CParams CINFOS = new CParams();
                    
                    CINFOS.mEmail = txtMail.Text;//.Replace("'", "''");
                    CINFOS.mSmtp = txtSmtp.Text;//.Replace("'", "''");
                    CINFOS.mSmtpPassword = txtSmtpPassword.Text;//.Replace("'", "''");
                    
                    CINFOS.mPort = Int32.Parse(sNumPort.EditValue.ToString());
                    
                    res = mDao.addParams(CINFOS, myChaine);

                    if (res)
                    {
                        MessageBox.Show("Paramètres Email créés avec succès!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Une erreur est survenue!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                #endregion

                #region Modification

                if (!IsAjout)
                {
                    var CP = ListeParams.FirstOrDefault();

                    CP.mSmtp = txtSmtp.Text;//.Replace("'", "''");
                    CP.mSmtpPassword = txtSmtpPassword.Text;//.Replace("'", "''");
                    CP.mEmail = txtMail.Text;//.Replace("'", "''");
                    
                    CP.mPort = Int32.Parse(sNumPort.EditValue.ToString());


                    res = mDao.updateParams(CP, myChaine);

                    if (res)
                    {
                        MessageBox.Show("Paramètres Email modifiés avec succès!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
