using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class ServerController
{
   // Image location
  private static string server = "https://localhost/ser/images/";
    public static  void DownloadAndDisplayImage(string imageUrl, PictureBox pictureBox)
    {
        imageUrl = server + imageUrl;

        ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
        try
        {
            using (WebClient webClient = new WebClient())
            {
                // Download the image bytes from the URL
                byte[] imageBytes = webClient.DownloadData(imageUrl);

                // Create an Image object from the downloaded bytes
                using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(memoryStream);

                    // Set the Image property of the PictureBox
                    pictureBox.Image = image;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}");
        }
    }

}

