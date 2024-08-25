using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DVLD.Global_Classes
{
    public class clsUtil
    {
        static public string GenerateGuid()
        {
            Guid NewGuid = Guid.NewGuid();
            return NewGuid.ToString();
        }

        static public bool CreateFolderIsNotExist(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception Ex)
                {
                    clsEventLog.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                    return false;
                }

            }
            return true;
        }

        static public string ReplaceFileNameWithGuid(string SourceFile)
        {
            FileInfo fi = new FileInfo(SourceFile);
            string Ext = fi.Extension;
            return GenerateGuid() + Ext;
        }

        static public bool CopyImageToImagesPeopleFolder(ref string SourceFile)
        {
            string DestinationFolder = ConfigurationManager.AppSettings["ImagesPeopleFolder"];
            if (!CreateFolderIsNotExist(DestinationFolder))
                return false;
            string DestinationFile = DestinationFolder + ReplaceFileNameWithGuid(SourceFile);
            try
            {
                File.Copy(SourceFile, DestinationFile, true);
            }
            catch (Exception Ex)
            {
                clsEventLog.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                return false;
            }
            SourceFile = DestinationFile;
            return true;
        }

        static public bool CopyImageToImagesBookFolder(ref string SourceFile)
        {
            string DestinationFolder = ConfigurationManager.AppSettings["ImagesBookFolder"];
            if (!CreateFolderIsNotExist(DestinationFolder))
                return false;
            string DestinationFile = DestinationFolder + ReplaceFileNameWithGuid(SourceFile);
            try
            {
                File.Copy(SourceFile, DestinationFile, true);
            }
            catch (Exception Ex)
            {
                clsEventLog.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                return false;
            }
            SourceFile = DestinationFile;
            return true;
        }

        static public bool DeleteImageFromProjectImagesFolder(string SourceFile)
        {
            try
            {
                File.Delete(SourceFile);
            }
            catch (Exception Ex)
            {
                clsEventLog.WriteEvent($" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}", EventLogEntryType.Error);
                return false;
            }
            return true;
        }

        public static int GetMonthsDifference(DateTime startDate, DateTime endDate)
        {
            int monthsDifference = endDate.Month - startDate.Month;
            return monthsDifference;
        }
        public static int GetDaysDifference(DateTime startDate, DateTime endDate)
        {
            TimeSpan DaysDifference = endDate - startDate;
            return Convert.ToInt32(DaysDifference.TotalDays)-1;
        }

        

    }
}
