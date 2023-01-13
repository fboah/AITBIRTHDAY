using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITBirthday.Models
{
   public class CEntiteAITEK
    {
        public int mId { get; set; }
        public string mLibelleEntiteAITEK { get; set; }

        public int mIdPays { get; set; }
        public string mLibellePays { get; set; }//Non stocké dans la table

        public int mIsDelete { get; set; }//1 = oui / 0=NON C'est pour savoir si c'est "supprimé" ou pas

        public string mUserCreation { get; set; }
        public string mUserLastModification { get; set; }

        public DateTime mDateCreation { get; set; }
        public DateTime mDateLastModification { get; set; }


        public CEntiteAITEK()
        {
            mId = 0;
            mLibelleEntiteAITEK = string.Empty;

            mIdPays = 0;
            mLibellePays = string.Empty;

            mUserCreation = string.Empty;
            mUserLastModification = string.Empty;

            mDateCreation = new DateTime();
            mDateLastModification = new DateTime();
        }

    }
}
