using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

using Google.GData.Documents;
using Google.GData.Client;
using Google.GData.Extensions;


namespace xPort5.Controls.GData
{
    public class GDocs
    {
        public static Hashtable GDocumentsAllowedTypes;

        public static DocumentsService GetService()
        {
            GDocumentsAllowedTypes = new Hashtable();
            GDocumentsAllowedTypes.Add("CSV", "text/csv");
            GDocumentsAllowedTypes.Add("TAB", "text/tab-separated-values");
            GDocumentsAllowedTypes.Add("TSV", "text/tab-separated-values");
            GDocumentsAllowedTypes.Add("TXT", "text/plain");
            GDocumentsAllowedTypes.Add("HTML", "text/html");
            GDocumentsAllowedTypes.Add("HTM", "text/html");
            GDocumentsAllowedTypes.Add("DOC", "application/msword");
            GDocumentsAllowedTypes.Add("ODS", "application/x-vnd.oasis.opendocument.spreadsheet");
            GDocumentsAllowedTypes.Add("ODT", "application/vnd.oasis.opendocument.text");
            GDocumentsAllowedTypes.Add("RTF", "application/rtf");
            GDocumentsAllowedTypes.Add("SXW", "application/vnd.sun.xml.writer");
            GDocumentsAllowedTypes.Add("XLS", "application/vnd.ms-excel");
            GDocumentsAllowedTypes.Add("PPT", "application/vnd.ms-powerpoint");
            GDocumentsAllowedTypes.Add("PPS", "application/vnd.ms-powerpoint");
            GDocumentsAllowedTypes.Add("PDF", "application/pdf");

            DocumentsService docService = new DocumentsService("xPort5");

            Utility.SysInfo sysInfo = Utility.SysInfo.Load();
            docService.setUserCredentials(sysInfo.FactoryGDocsAccount, sysInfo.FactoryGDocsPassword);

            return docService;
        }

        public static DocumentsFeed GetDocsInFolder(string folder)
        {
            Utility.SysInfo sysInfo = Utility.SysInfo.Load();

            return GetDocsInFolder(GetService(), folder, sysInfo.FactoryGDocsAccount);
        }

        public static DocumentsFeed GetDocsInFolder(DocumentsService service, string folder, string email)
        {
            AtomCategory folderCategory = new AtomCategory(folder, new AtomUri("http://schemas.google.com/docs/2007/folders/" + email));
            QueryCategory folderQueryCategory = new QueryCategory(folderCategory);
            DocumentsListQuery query = new DocumentsListQuery();
            query.Categories.Add(folderQueryCategory);

            return service.Query(query);
        }

        public static DocumentEntry UploadFile(string filePath, string fileName)
        {
            DocumentsService service = GetService();
            DocumentEntry newEntry = service.UploadDocument(filePath, fileName);

            return newEntry;
        }

        // API version 2: PDF is unsupported
        public static DocumentEntry UploadFile(string filePath, string fileName, string folderUri)
        {
            DocumentsService service = GetService();

            FileInfo fileInfo = new FileInfo(filePath);
            FileStream stream = fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            Uri postUri = new Uri(folderUri);

            if (fileName == null)
            {
                fileName = fileInfo.Name;
            }

            //convert the extension to caps and strip the "." off the front
            string ext = fileInfo.Extension.ToUpper().Substring(1);

            String contentType = (String)GDocumentsAllowedTypes[ext];

            if (contentType == null)
            {
                throw new ArgumentException("File extension '" + ext + "' is not recognized as valid.");
            }

            DocumentEntry entry = service.Insert(postUri, stream, contentType, fileName) as DocumentEntry;

            stream.Close();

            return entry;
        }

        // 由於 API v3.0 未 release, 暫時抄用它的代碼
        // API version 3: 沒有指定 Folder 位置
        public static DocumentEntry UploadFile3(string filePath, string fileName)
        {
            DocumentsService service = GetService();
            service.ProtocolMajor = 3;

            FileInfo fileInfo = new FileInfo(filePath);
            FileStream stream = fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            //Uri postUri = new Uri("http://docs.google.com/feeds/default/private/full");
            Uri postUri = new Uri("https://docs.google.com/feeds/default/private/full?convert=false");

            if (fileName == null)
            {
                fileName = fileInfo.Name;
            }

            //convert the extension to caps and strip the "." off the front
            string ext = fileInfo.Extension.ToUpper().Substring(1);

            String contentType = (String)GDocumentsAllowedTypes[ext];

            if (contentType == null)
            {
                throw new ArgumentException("File extension '" + ext + "' is not recognized as valid.");
            }

            DocumentEntry entry = service.Insert(postUri, stream, contentType, fileName) as DocumentEntry;

            stream.Close();

            return entry;
        }

        // API version 3: 指定 Foler 位置
        public static DocumentEntry UploadFile3(string filePath, string fileName, string folderUri)
        {
            DocumentsService service = GetService();
            service.ProtocolMajor = 3;

            FileInfo fileInfo = new FileInfo(filePath);
            FileStream stream = fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            //Uri postUri = new Uri(folderUri.Replace("folders", "default") + @"/contents");
            Uri postUri = new Uri("https://docs.google.com/feeds/default/private/full?convert=false");

            if (fileName == null)
            {
                fileName = fileInfo.Name;
            }

            //convert the extension to caps and strip the "." off the front
            string ext = fileInfo.Extension.ToUpper().Substring(1);

            String contentType = (String)GDocumentsAllowedTypes[ext];

            if (contentType == null)
            {
                throw new ArgumentException("File extension '" + ext + "' is not recognized as valid.");
            }

            DocumentEntry entry = service.Insert(postUri, stream, contentType, fileName) as DocumentEntry;

            stream.Close();

            return entry;
        }

        public static string CreateFolder3(String folderName, String destFolderId)
        {
            DocumentsService service = GetService();
            service.ProtocolMajor = 3;

            AtomCategory category = new AtomCategory("http://schemas.google.com/docs/2007#folder", new AtomUri("http://schemas.google.com/g/2005#kind"));
            category.Label = "folder";

            AtomEntry folder = new AtomEntry();
            folder.Categories.Add(category);
            folder.Title = new AtomTextConstruct(AtomTextConstructElementType.Title, folderName);

            Uri feedUri;
            AtomEntry newFolderEntry;
            if (destFolderId.Equals(""))
            {
                feedUri = new Uri("http://docs.google.com/feeds/default/private/full");
                newFolderEntry = service.Insert(feedUri, folder);             // send request
            }
            else
            {
                feedUri = new Uri("http://docs.google.com/feeds/default/private/full/folder" + "%3A" + destFolderId + "/contents");

                //                feedUri = new Uri(destFolderId.Replace("folders", "default") + @"/contents");

                //                Console.WriteLine(feedUri.ToString());
                //                AtomFeed feed = new AtomFeed(feedUri, service);
                newFolderEntry = service.Insert(feedUri, folder);            // send request
            }

            //Console.WriteLine(FolderQuery.DocumentId(newFolderEntry.Id.AbsoluteUri));
            String folderId = "";       // HACK: 2020.02.28 paulus FolderQuery.DocumentId(newFolderEntry.Id.AbsoluteUri);
            //            Console.WriteLine(folderId);
            return folderId;
        }

        public static bool DownloadFile(string fileName)
        {
            bool result = false;

            DocumentsService service = GetService();
            DocumentsListQuery query = new DocumentsListQuery();

            query.Title = fileName;
            query.TitleExact = true;
            DocumentsFeed feed = service.Query(query);

            foreach (DocumentEntry entry in feed.Entries)
            {
                string filePath = Path.Combine(DAL.Common.Config.OutBox, entry.Title.Text);
                string uri = entry.Content.Src.ToString();
                Uri sourceUri = new Uri(uri);

                Stream sourceContent = service.Query(sourceUri);

                using (FileStream outFile = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[8192];
                    int bytesRead;

                    while ((bytesRead = sourceContent.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        outFile.Write(buffer, 0, bytesRead);
                    }
                    outFile.Close();
                }
                result = true;
            }

            return result;
        }

        public static bool DeleteFile(string fileName)
        {
            bool result = false;

            DocumentsService service = GetService();
            DocumentsListQuery query = new DocumentsListQuery();

            query.Title = fileName;
            query.TitleExact = true;
            DocumentsFeed feed = service.Query(query);

            foreach (DocumentEntry entry in feed.Entries)
            {
                entry.Delete();
            }

            return result;
        }

        public static bool IsFileExist(string fileName)
        {
            bool result = false;

            DocumentsService service = GetService();
            DocumentsListQuery query = new DocumentsListQuery();

            query.Title = fileName;
            query.TitleExact = true;
            DocumentsFeed feed = service.Query(query);

            if (feed.Entries.Count > 0)
            {
                result = true;
            }

            return result;
        }
    }
}
