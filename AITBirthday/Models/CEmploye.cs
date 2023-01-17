using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITBirthday.Models
{
  public  class CEmploye
    {
        public int mId { get; set; }
        public string mNom { get; set; }
        public string mPrenoms { get; set; }

        public int mIdPoste { get; set; }
        public string mLibellePoste { get; set; }//Non stocké dans la table

        public int mIdDirection { get; set; }
        public string mLibelleDirection { get; set; }//Non stocké dans la table

        public int mIdEntiteAITEK { get; set; }
        public string mLibelleEntiteAITEK { get; set; }//Non stocké dans la table

        public DateTime mDateNaissance { get; set; }

        public int mIsDelete { get; set; }//1 = oui / 0=NON C'est pour savoir si c'est "supprimé" ou pas

        public string mUserCreation { get; set; }
        public string mUserLastModification { get; set; }

        public DateTime mDateCreation { get; set; }
        public DateTime mDateLastModification { get; set; }

        public string mDateAnniversaire { get; set; }//Mois-Jour--NON STOCKE

        public string mEmail { get; set; }


        public CEmploye()
        {
            mId = 0;
            mNom = string.Empty;
            mPrenoms = string.Empty;

            mIdPoste = 0;
            mLibellePoste = string.Empty;

            mIdDirection = 0;
            mLibelleDirection = string.Empty;
            mIdEntiteAITEK = 0;
            mLibelleEntiteAITEK = string.Empty;

            mDateNaissance = new DateTime();

            mIsDelete = 0;

            mUserCreation = string.Empty;
            mUserLastModification = string.Empty;

            mDateCreation = new DateTime();
            mDateLastModification = new DateTime();

            mDateAnniversaire = string.Empty;

            mEmail = string.Empty;
        }

    }
}
