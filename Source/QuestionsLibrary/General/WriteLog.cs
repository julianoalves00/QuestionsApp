using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsLibrary.General
{
    public class WriteLog
    {
        public static void AddEventLogEntry(Exception ex)
        {
            AddEventLogEntry(string.Format("{0} : {1}", ex.Message, ex.StackTrace));
        }
        public static void AddEventLogEntry(string message)
        {
            try
            {
                // Write in windows EventLog
                string applicationName = Assembly.GetCallingAssembly().GetName().Name;

                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = "Application";
                    eventLog.WriteEntry(string.Format("{0}=>{1}", applicationName, message), EventLogEntryType.Error); //, 101, 1);
                }
            }
            catch { }
        }
    }
}
