using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Helper
{
    public static class Logger
    {
        private static string m_exePath = string.Empty;

        /// <summary>
        /// This method is used to log the information.
        /// </summary>
        /// <param name="logMessage"></param>
        public static void LogInformation(string logMessage)
        {
            m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            using (StreamWriter w = File.AppendText(m_exePath + "\\" + "log.txt"))
            {
                Log(logMessage, w);
            }
        }

        /// <summary>
        /// This method is used to log the information.
        /// </summary>
        /// <param name="logMessage"></param>
        /// <param name="txtWriter"></param>
        public static void Log(string logMessage, TextWriter txtWriter)
        {
            txtWriter.Write("\r\nLog Entry : ");
            txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            txtWriter.WriteLine("  :");
            txtWriter.WriteLine("  :{0}", logMessage);
            txtWriter.WriteLine("-------------------------------");
        }
    }
}
    