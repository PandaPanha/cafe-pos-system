using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace cafe_pos_system.services
{
    public static class PictureService
    {
        public static Bitmap BrowsePicture()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image (*.jpg)(*.jpeg)(*.png)|*.jpg;*.jpeg;*.png*";
            file.Title = "Please Select an Image";

            if (file.ShowDialog() == DialogResult.OK)
            {
                return new Bitmap(file.OpenFile());
            }
            return null;
        }

        public static byte[] ConvertImgToBinary(Image img)
        {
            byte[] binaryPic;
            ImageConverter converter = new ImageConverter();
            binaryPic = (byte[])converter.ConvertTo(img, typeof(byte[]));
            return binaryPic;
        }

        public static Image ConvertBinaryToImg(byte[] BinImg)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(BinImg))
                {
                    return Image.FromStream(ms);
                }
            }
            catch
            {
                MessageBox.Show("Error trying to convert binary to Image!");
                return null;
            }

        }
    }
}
