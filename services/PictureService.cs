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
            // Create an OpenFileDialog instance
            OpenFileDialog file = new OpenFileDialog();

            // Set the filter to display only image files with .jpg, .jpeg, and .png extensions
            file.Filter = "Image (*.jpg)(*.jpeg)(*.png)|*.jpg;*.jpeg;*.png*";

            // Set the title of the file dialog
            file.Title = "Please Select an Image";

            // If the user selects a file and clicks "OK" in the dialog
            if (file.ShowDialog() == DialogResult.OK)
            {
                // Create a new Bitmap object using the selected file stream
                return new Bitmap(file.OpenFile());
            }

            // Return null if no file is selected or the dialog is cancelled
            return null;
        }

        public static byte[] ConvertImgToBinary(Image img)
        {
            byte[] binaryPic; // Declaration of a byte array variable

            // Creating an instance of ImageConverter
            ImageConverter converter = new ImageConverter();

            // Converting the 'img' (Image object) to a byte array using the ImageConverter
            binaryPic = (byte[])converter.ConvertTo(img, typeof(byte[]));

            return binaryPic; // Returning the resulting byte array

            /*
            - `binaryPic` is a byte array variable declared to store the binary representation of the image.
            - An `ImageConverter` instance named `converter` is created.
            - The `ConvertTo` method of the `ImageConverter` is used to convert the `img` (an `Image` object) to a byte array (`byte[]`) using the `ConvertTo` method. It takes the `img` object and specifies the target type as `typeof(byte[])`.
            - The result of this conversion is stored in the `binaryPic` byte array.
            - Finally, the resulting byte array `binaryPic` is returned.

            This code snippet is responsible for the conversion of an `Image` object into its binary representation stored in a byte array.
            */

        }

        public static Image ConvertBinaryToImg(byte[] BinImg)
        {
            try
            {
                // Using a MemoryStream to read the binary image data
                using (MemoryStream ms = new MemoryStream(BinImg))
                {
                    // Creating an Image object from the binary data using FromStream method
                    return Image.FromStream(ms);
                }
            }
            catch
            {
                // If an exception occurs during the conversion process
                // Display an error message using MessageBox
                MessageBox.Show("Error trying to convert binary to Image!");

                // Return null as the conversion failed
                return null;
            }

        }
    }
}
