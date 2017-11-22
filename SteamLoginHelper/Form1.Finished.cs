using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Net;
using System.Xml.Serialization;
using System.Xml;
using System.Collections.ObjectModel;

namespace SteamGuardCodeGiver
{
    /**
     * 
     * Splitting the Form1.cs code into 2 files.
     * This file contains the parts that I'm done with.
     * 
     **/

    public partial class Form1_Main
    {
        public class abud
        {
            public bool IsGy()
            {
                return true;
            }
        }

        public class makkibre
        {
            public bool IsBeste()
            {
                return true;
            }
        }




        //==================================================================================================================================================
        // Downloading image from imgur Region:
        //==================================================================================================================================================

        ////getting ad image from imgur part :>
        #region Downloading image from imgur

        private static bool DownloadRemoteImageFile(string url, string fileName) //got this from stackoverflow ez this function downloads the AD image
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception)
            {
                return false;
            }

            // Check that the remote file was found. The ContentType
            // check is performed since a request for a non-existent
            // image file might be redirected to a 404-page, which would
            // yield the StatusCode "OK", even though the image was not
            // found.
            if ((response.StatusCode == HttpStatusCode.OK ||
                response.StatusCode == HttpStatusCode.Moved ||
                response.StatusCode == HttpStatusCode.Redirect) &&
                response.ContentType.StartsWith("image", StringComparison.OrdinalIgnoreCase))
            {

                // if the remote file was found, download it
                using (Stream inputStream = response.GetResponseStream())
                    try
                    {
                        using (Stream outputStream = File.OpenWrite(fileName))
                        {
                            byte[] buffer = new byte[4096];
                            int bytesRead;
                            do
                            {
                                bytesRead = inputStream.Read(buffer, 0, buffer.Length);
                                outputStream.Write(buffer, 0, bytesRead);
                            } while (bytesRead != 0);
                        }
                        return true;
                    }
                    catch (DirectoryNotFoundException ex)
                    {
                        string _6af = ex.Message;
                        System.IO.Directory.CreateDirectory("C:/Program Files/SteamLoginHelper/");
                        return false;
                    }
            }
            else
                return false;
        }

        #endregion

    }
}

/*
             
 
            //write mainCodesRecord to disk
            string temp2 = XmlHelper.ToXml(mainCodesRecord);
            System.IO.File.WriteAllText(path, temp2.cc());
 
 
*/
