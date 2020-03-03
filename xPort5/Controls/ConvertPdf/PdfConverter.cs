using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Web;
using System.IO;
using System.Collections;
using System.Diagnostics;

namespace xPort5.Controls.ConvertPdf
{
    class PdfConverter
    {
        private const string jobImageListName = "Product Image";

        public static void Convert(string input, string output)
        {
            input = input.Replace(" ", "_");
            output = output.Replace(" ", "_"); 

            // create the Jpeg file
            CreateJpegByGs(input);

            string imageFullName = Path.Combine(Snippet.GetGsWorkFolder(), Snippet.GetImageKey(Path.GetFileName(output)));
            string imageFileName = Snippet.GetImageKey(Path.GetFileName(output));

            // clean the Work Folder
            if (File.Exists(imageFullName))
            {
                File.Delete(imageFullName);
            }
        }

        private static void CreateJpegByGs(string fileName)
        {
            string args = String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11}",
                "-dSAFER",
                "-dBATCH",
                "-dNOPAUSE",
                "-sDEVICE=jpeg",
                "-dFirstPage=1",
                "-dLastPage=2",
                "-r72",
                "-dTestalphaBits=4",
                "-dGraphicsAlphaBits=4",
                "-dMaxStripSize=8192",
                String.Format("-sOutputFile={0}.jpg", fileName),
                fileName
            );

            try
            {
                Process p = new Process();

                p.StartInfo.WorkingDirectory = Snippet.GetGsWorkFolder();
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.FileName = "GsWin32c.exe";
                p.StartInfo.Arguments = args;

                p.Start();
                p.WaitForExit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void CreateJpegByFileCopy(string source)
        {
            string dest = source.Substring(0, source.Length - 3) + "pdf.jpg";
            File.Copy(source, dest);
        }
    }
}
