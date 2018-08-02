using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFameDocs.Models
{
    public class FAMEDocumentModel
    {

        public string FilePath { get; set; }            //Path where file is stored on J:\Farms
        public string FileName { get; set; }            //Actual name of the file
        public string FileNameFriendly { get; set; }    //Display name of the file *can include spaces and special characters*
        public string FileType { get; set; }            //Type of FAME document { ie ASR/WFP/etc. }
        public string FileSubType { get; set; }         //Subtype of FAME document { Revision/Cancellation/Renewal/etc. }
        public string FarmID { get; set; }              //FAME FarmID that this document is associated with
        public string FileSize { get; set; }               //Size of the file on disk
        public string FileUploader { get; set; }        //WAC personnel who uploaded this file
        public string FileUploadMethod { get; set; } = @"DocUploaderSvc";  //Method in which file was uploaded into FAME { DocumentUploaderSvc/AdminWeb/email/etc. }
        public string FileCreated { get; set; }       //Time the file was uploaded to FAME
        public bool DB { get; set; } = false;     //Checks for a matching Database record and compares document details.  This is intended to detect orphaned files or database entries.


    }
}