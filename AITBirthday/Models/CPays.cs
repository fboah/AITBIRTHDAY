using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITBirthday.Models
{
  public  class CPays
    {
        public int mId { get; set; }
        public string mCodePays { get; set; }
        public string mLibellePays { get; set; }


        public CPays()
        {
            mId = 0;
            mCodePays = string.Empty;
            mLibellePays = string.Empty;

        }
    }
}
