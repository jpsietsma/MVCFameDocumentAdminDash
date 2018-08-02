using MVCFameDocs.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFameDocs.Controllers
{
    public class DocumentsController : Controller
    {
        // GET: Documents
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListDocuments()
        {
            List<FAMEDocumentModel> FinalFameDocuments = new List<FAMEDocumentModel>();

            //Connect to SQL database and retrieve list of files picked up by automation
            using (SqlConnection conn = new SqlConnection(@"Data Source=POTOKTEST;Initial Catalog=wacTest;User Id=sa;Password=WacAttack9;"))
            {

                SqlDataReader rdr = null;

                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Select * from testFameUploads", conn);

                    cmd.ExecuteNonQuery();
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {

                        //create and add new FameDocumentModel to the final list
                        FinalFameDocuments.Add(new FAMEDocumentModel {
                                                                       FilePath = rdr["fileDirectoryPath"].ToString(),
                                                                       FileName = rdr["fileName"].ToString(),
                                                                       FarmID = rdr["fk_fileFarmID"].ToString(),
                                                                       DB = true,
                                                                       FileCreated = rdr["fileTimestamp"].ToString(),
                                                                       FileUploader = rdr["fk_fileUploader"].ToString(),
                                                                       FileSize = rdr["fileSize"].ToString(),
                                                                       FileType = rdr["fk_fileType"].ToString(),
                                                                     });

                    }
                }
                finally
                {
                    
                    if (rdr != null)
                    {
                        rdr.Close();
                    }

                    if (conn != null)
                    {
                        rdr.Close();
                    }
                    
                }
            }

            return View(FinalFameDocuments);

        }

    }
}