using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITBirthday.Models
{
  public  class CPoste
    {
        public int mId { get; set; }
        public string mCodePoste { get; set; }
        public string mIntitulePoste { get; set; }
        public string mDescription { get; set; }
        public int mIsDelete { get; set; }//1 = oui / 0=NON C'est pour savoir si c'est "supprimé" ou pas

        public string mUserCreation { get; set; }
        public string mUserLastModification { get; set; }

        public DateTime mDateCreation { get; set; }
        public DateTime mDateLastModification { get; set; }


        public CPoste()
        {
            mId = 0;
            mCodePoste = string.Empty;
            mIntitulePoste = string.Empty;
            mDescription = string.Empty;
            mIsDelete = 0;

            mDescription = string.Empty;
            mDescription = string.Empty;

            mDateCreation = new DateTime();
            mDateLastModification = new DateTime();
        }
    }
}
