using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OrderManager
{
    class ExceptionCaptain
    {
        private const string LOG_PATH = "log";

        public static void Catch(string errMsg)
        {
            if (!Directory.Exists(LOG_PATH))
            {
                Directory.CreateDirectory(LOG_PATH);
            }
            string name = LOG_PATH + "/" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".txt";
            using (StreamWriter writer = new StreamWriter(name, true))
            {
                writer.WriteLine(errMsg);
                writer.Flush();
                writer.Close();
            }
        }
    }
}
