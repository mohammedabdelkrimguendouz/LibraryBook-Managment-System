
using System.Diagnostics;


namespace LibraryBook_DataAccess
{
    public class clsEventLogData
    {
        public static void WriteEvent(string Message, EventLogEntryType eventLogEntryType)
        {

            string SourceName = "LibraryBook";

            try
            {
                if (!EventLog.SourceExists(SourceName))
                {
                    EventLog.CreateEventSource(SourceName, "Application");
                }

                EventLog.WriteEntry(SourceName, Message, eventLogEntryType);
            }
            catch
            {

            }
            
        }
    }
}
