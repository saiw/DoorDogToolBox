

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftTool
{
    public class FileTool
    {

        #region  TEXT FILE READ / WRITE /APPENCH
        //TO DO WRITE APPENCH

        /// <summary>
        /// Write the txt Log under the CurrentAppDomin File
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="filepath"></param>
        /// <remarks>if exits ,delete</remarks>
        public static void WriteLogwithTxt(String exception, string filepath)
        {
            if (File.Exists(filepath))
            { File.Delete(filepath); }

            TextWriter tw = new StreamWriter(filepath);
            {
                tw.WriteLine(exception);
                tw.Close();
                tw.Flush();
            }
        }

        #endregion

        
    }


}
