using AITBirthday.Models;
using AITBirthday.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace AITBirthday.Services
{
    public class ServiceAITBIR
    {
        //Anniversaire===============================================================

        public string getEmailBody(CEmploye LCINF)
        {
            string ret = string.Empty;

            try
            {
                ret = @" " +
                     "<html xmlns=\"http://www.w3.org/1999/xhtml\">" +
                     "<head>" +
                     "<title>Email</title>" +
                     "</head>" +
                    "<body style=\"font-family:'Calibri'\">" +

                       "<p>🎶 Joyeux aanniversaire, 🎶 Joyeux aanniversaire, </p>" +
                     " <p> 🎶 Joyeux aaaaaanniversaaaire  " + LCINF.mNom + " " + LCINF.mPrenoms + " , </p>" +
                     "<p>En ce jour spécial qui célèbre la naissance du guerrier, Toute la famille AITEK d'une seule voix te </p>" +
                     "<p>chante un joyeux anniversaire et te souhaite tous les meilleurs vœux.</p>" +
                     "<p>Passion Discipline Victoire 💪🏽🥂</p>";


                return ret;
            }
            catch (Exception ex)
            {
                return ret;
            }
        }


        private AlternateView Mail_Body1(CEmploye LCINF)
        {
            string path = @"D:\A\HBD1.gif";
            LinkedResource Img = new LinkedResource(path, MediaTypeNames.Image.Gif);
            Img.ContentId = "MyImage";
            


            string ret = @" " +
                     "<html xmlns=\"http://www.w3.org/1999/xhtml\">" +
                     "<head>" +
                     "<title>Email</title>" +
                     "</head>" +
                    "<body style=\"font-family:'Calibri'\">" +

                       "<p>🎶 Joyeux aanniversaire, 🎶 Joyeux aanniversaire, </p>" +
                     " <p> 🎶 Joyeux aaaaaanniversaaaire  " + LCINF.mNom + " " + LCINF.mPrenoms + " , </p>" +
                     "<p>En ce jour spécial qui célèbre la naissance du guerrier, Toute la famille AITEK d'une seule voix te </p>" +
                     "<p>chante un joyeux anniversaire et te souhaite tous les meilleurs vœux.</p>" +
                     "<p>Passion Discipline Victoire 💪🏽🥂</p>";
            

            string str = @"  
             
                <tr>  
                    <td> " + ret + @"  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
                      <img src=cid:MyImage  id='img' alt='' width='10px' height='10px'/>   
                    </td>  
                   
                </tr>
            ";


            AlternateView AV =
            AlternateView.CreateAlternateViewFromString(str, null, MediaTypeNames.Text.Html);
            AV.LinkedResources.Add(Img);
            return AV;
        }

        private AlternateView Mail_Body2(CEmploye LCINF)
        {
            string path = @"D:\A\HBD2.gif";
            LinkedResource Img = new LinkedResource(path, MediaTypeNames.Image.Gif);
            Img.ContentId = "MyImage";



            string ret = @" " +
                     "<html xmlns=\"http://www.w3.org/1999/xhtml\">" +
                     "<head>" +
                     "<title>Email</title>" +
                     "</head>" +
                    "<body style=\"font-family:'Calibri'\">" +

                       "<p>🎶 Joyeux aanniversaire, 🎶 Joyeux aanniversaire, </p>" +
                     " <p> 🎶 Joyeux aaaaaanniversaaaire  " + LCINF.mNom + " " + LCINF.mPrenoms + " , </p>" +
                     "<p>En ce jour spécial qui célèbre la naissance du guerrier, Toute la famille AITEK d'une seule voix te </p>" +
                     "<p>chante un joyeux anniversaire et te souhaite tous les meilleurs vœux.</p>" +
                     "<p>Passion Discipline Victoire 💪🏽🥂</p>";


            string str = @"  
             
                <tr>  
                    <td> " + ret + @"  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
                      <img src=cid:MyImage  id='img' alt='' width='10px' height='10px'/>   
                    </td>  
                   
                </tr>
            ";


            AlternateView AV =
            AlternateView.CreateAlternateViewFromString(str, null, MediaTypeNames.Text.Html);
            AV.LinkedResources.Add(Img);
            return AV;
        }

        private AlternateView Mail_Body3(CEmploye LCINF)
        {
            string path = @"D:\A\HBD3.gif";
            LinkedResource Img = new LinkedResource(path, MediaTypeNames.Image.Gif);
            Img.ContentId = "MyImage";



            string ret = @" " +
                     "<html xmlns=\"http://www.w3.org/1999/xhtml\">" +
                     "<head>" +
                     "<title>Email</title>" +
                     "</head>" +
                    "<body style=\"font-family:'Calibri'\">" +

                       "<p>🎶 Joyeux aanniversaire, 🎶 Joyeux aanniversaire, </p>" +
                     " <p> 🎶 Joyeux aaaaaanniversaaaire  " + LCINF.mNom + " " + LCINF.mPrenoms + " , </p>" +
                     "<p>En ce jour spécial qui célèbre la naissance du guerrier, Toute la famille AITEK d'une seule voix te </p>" +
                     "<p>chante un joyeux anniversaire et te souhaite tous les meilleurs vœux.</p>" +
                     "<p>Passion Discipline Victoire 💪🏽🥂</p>";


            string str = @"  
             
                <tr>  
                    <td> " + ret + @"  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
                      <img src=cid:MyImage  id='img' alt='' width='10px' height='10px'/>   
                    </td>  
                   
                </tr>
            ";


            AlternateView AV =
            AlternateView.CreateAlternateViewFromString(str, null, MediaTypeNames.Text.Html);
            AV.LinkedResources.Add(Img);
            return AV;
        }

        private AlternateView Mail_Body4(CEmploye LCINF)
        {
            string path = @"D:\A\HBD4.gif";
            LinkedResource Img = new LinkedResource(path, MediaTypeNames.Image.Gif);
            Img.ContentId = "MyImage";



            string ret = @" " +
                     "<html xmlns=\"http://www.w3.org/1999/xhtml\">" +
                     "<head>" +
                     "<title>Email</title>" +
                     "</head>" +
                    "<body style=\"font-family:'Calibri'\">" +

                       "<p>🎶 Joyeux aanniversaire, 🎶 Joyeux aanniversaire, </p>" +
                     " <p> 🎶 Joyeux aaaaaanniversaaaire  " + LCINF.mNom + " " + LCINF.mPrenoms + " , </p>" +
                     "<p>En ce jour spécial qui célèbre la naissance du guerrier, Toute la famille AITEK d'une seule voix te </p>" +
                     "<p>chante un joyeux anniversaire et te souhaite tous les meilleurs vœux.</p>" +
                     "<p>Passion Discipline Victoire 💪🏽🥂</p>";


            string str = @"  
             
                <tr>  
                    <td> " + ret + @"  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
                      <img src=cid:MyImage  id='img' alt='' width='10px' height='10px'/>   
                    </td>  
                   
                </tr>
            ";


            AlternateView AV =
            AlternateView.CreateAlternateViewFromString(str, null, MediaTypeNames.Text.Html);
            AV.LinkedResources.Add(Img);
            return AV;
        }


        public bool sendMailAnniv(CParams ParamEmail, CEmploye CAFS)
        {
            bool ret = false;
            try
            {
                if (ParamEmail.mEmail != string.Empty && ParamEmail.mSmtp != string.Empty && ParamEmail.mSmtpPassword != string.Empty && ParamEmail.mPort > 0)
                {
                    //Si on a pas de mail renseigné,on n'envoie pas de mail

                    MailMessage mail = new MailMessage
                    {
                        From = new MailAddress(ParamEmail.mEmail),
                        Subject = "JOYEUX ANNIVERSAIRE "+CAFS.mNom+" "+CAFS.mPrenoms,
                      //  Body = getEmailBody(CAFS),
                      
                        IsBodyHtml = true

                    };

                    //Destinataire
                    mail.To.Add(CAFS.mEmail);

                    //Choisir l'image du mail en random

                    Random random = new Random();
                    int randomImage = random.Next(1,4);

                    switch (randomImage)
                    {
                        case 1:
                            //Add the Image to the Alternate view
                            mail.AlternateViews.Add(Mail_Body1(CAFS));
                            break;
                        case 2:
                            //Add the Image to the Alternate view
                            mail.AlternateViews.Add(Mail_Body2(CAFS));
                            break;
                        case 3:
                            //Add the Image to the Alternate view
                            mail.AlternateViews.Add(Mail_Body3(CAFS));
                            break;
                        case 4:
                            //Add the Image to the Alternate view
                            mail.AlternateViews.Add(Mail_Body4(CAFS));
                            break;
                       
                    }
                    

                    var smtpClient = new SmtpClient
                    {
                        Host = ParamEmail.mSmtp,
                        Port = ParamEmail.mPort,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        Credentials = new NetworkCredential(ParamEmail.mEmail, ParamEmail.mSmtpPassword),
                        EnableSsl = true,

                    };

                    smtpClient.Send(mail);

                    ret = true;

                }

                return ret;
            }
            catch (Exception ex)
            {
                var msg = "ServiceAITASS -> sendMailAnniv-> TypeErreur: " + ex.Message;
                CLog.Log(msg);

                ret = false;

                return ret;
            }

        }


   


    }
}
