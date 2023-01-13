using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITBirthday.Utils
{
   public class CLog
    {
        //Ecrire les logs
        public static void Log(string msgToWrite)
        {
            var retourLigne = Environment.NewLine;
            const string space = "-------------------------------------------------------------------------------";
            var dateErreur = @"Erreur survenue le " + DateTime.Now.ToString(CultureInfo.InvariantCulture) + "   du poste " + Environment.UserDomainName + "\\" + Environment.UserName;
            //var dateErreur = "";
            var typeErreur = msgToWrite;

            if (!Directory.Exists(@"C:\Report_Log"))
            {
                Directory.CreateDirectory(@"C:\Report_Log");
            }

            // string[] msgfinal = { space , dateErreur , typeErreur , space };
            string msgfinal = space + retourLigne + dateErreur + retourLigne + typeErreur + retourLigne + space;

            var fs = new FileStream(@"C:\Report_Log\AITBIRTHDAY_Log.txt", FileMode.Append, FileAccess.Write, FileShare.None);

            var swFromFileStream = new StreamWriter(fs, Encoding.Default);

            swFromFileStream.Write(msgfinal);
            swFromFileStream.Flush();
            swFromFileStream.Close();


        }

    }
}
