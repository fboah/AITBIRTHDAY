using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITBirthday.Models
{
  public  class CDirection
    {
        public int mId { get; set; }
        public string mCodeDirection { get; set; }
        public string mIntituleDirection { get; set; }
        public string mDescription { get; set; }
        public int mIsDelete { get; set; }//1 = oui / 0=NON C'est pour savoir si c'est "supprimé" ou pas

        public string mUserCreation { get; set; }
        public string mUserLastModification { get; set; }

        public DateTime mDateCreation { get; set; }
        public DateTime mDateLastModification { get; set; }


        public CDirection()
        {
            mId = 0;
            mCodeDirection = string.Empty;
            mIntituleDirection = string.Empty;
            mDescription = string.Empty;
            mIsDelete = 0;

            mUserCreation = string.Empty;
            mUserLastModification = string.Empty;

            mDateCreation = new DateTime();
            mDateLastModification = new DateTime();
        }

    }
}
