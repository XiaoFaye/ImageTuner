using System.Drawing.Imaging;

namespace ImageTuner;

public static class ImageExtensions
{
    static ImageExtensions()
    {
        JpgEncoder = GetEncoder(ImageFormat.Jpeg);
    }

    public static ImageCodecInfo JpgEncoder;
    public static ImageCodecInfo GetEncoder(ImageFormat format)
    {
        ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
        foreach (ImageCodecInfo codec in codecs)
        {
            if (codec.FormatID == format.Guid)
            {
                return codec;
            }
        }
        return null;
    }

    public static void ResizeImage2JPG(string path, float sizePercentage, long quality = 95, bool removeOriginalFile = false)
    {
        if (!File.Exists(path))
            return;

        if (sizePercentage < 1 && sizePercentage > 0.01)
        {
            Bitmap bmp = new Bitmap(path);
            var ratioX = (double)(bmp.Width * sizePercentage / bmp.Width);
            var ratioY = (double)(bmp.Height * sizePercentage / bmp.Height);
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(bmp.Width * ratio);
            var newHeight = (int)(bmp.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(bmp, 0, 0, newWidth, newHeight);

            /**  Image PropertyItem 274
             * 
                 if (Array.IndexOf(img.PropertyIdList, 274) > -1)
                {
                    var orientation = (int)img.GetPropertyItem(274).Value[0];
                    switch (orientation)
                    {
                        case 1:
                            // No rotation required.
                            break;
                        case 2:
                            img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                            break;
                        case 3:
                            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                            break;
                        case 4:
                            img.RotateFlip(RotateFlipType.Rotate180FlipX);
                            break;
                        case 5:
                            img.RotateFlip(RotateFlipType.Rotate90FlipX);
                            break;
                        case 6:
                            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            break;
                        case 7:
                            img.RotateFlip(RotateFlipType.Rotate270FlipX);
                            break;
                        case 8:
                            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                            break;
                    }
                    // This EXIF data is now invalid and should be removed.
                    img.RemovePropertyItem(274);
                }
            *
            **/

            foreach (var item in bmp.PropertyItems)
            {
                if (item.Id == 274)
                {
                    newImage.SetPropertyItem(item);
                    break;
                }
            }

            // Create an Encoder object based on the GUID  
            // for the Quality parameter category.  
            Encoder myEncoder = Encoder.Quality;

            // Create an EncoderParameters object.  
            // An EncoderParameters object has an array of EncoderParameter  
            // objects. In this case, there is only one  
            // EncoderParameter object in the array.  
            EncoderParameters myEncoderParameters = new(1);

            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, quality);
            myEncoderParameters.Param[0] = myEncoderParameter;


            var newPath = Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path) + "_Processed.jpg");
            newImage.Save(newPath, JpgEncoder, myEncoderParameters);
            newImage.Dispose();
            bmp.Dispose();

            if (removeOriginalFile)
            {
                File.Delete(path);
                File.Move(newPath, Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path) + ".jpg"));
            }
        }
    }

    public static void ResaveImage2JPG(string path, long quality = 95, bool ignoreDateCheck = false, bool removeOriginalFile = false)
    {
        var f = new FileInfo(path);
        if (f.LastWriteTime.Date != DateTime.Now.Date || ignoreDateCheck)
        {
            var bmp1 = new Bitmap(path);

            // Create an Encoder object based on the GUID  
            // for the Quality parameter category.  
            Encoder myEncoder = Encoder.Quality;

            // Create an EncoderParameters object.  
            // An EncoderParameters object has an array of EncoderParameter  
            // objects. In this case, there is only one  
            // EncoderParameter object in the array.  
            EncoderParameters myEncoderParameters = new EncoderParameters(1);

            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, quality);
            myEncoderParameters.Param[0] = myEncoderParameter;

            var newPath = Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path) + "_Processed.jpg");
            var newImage = new Bitmap(bmp1.Width, bmp1.Height);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(bmp1, 0, 0, bmp1.Width, bmp1.Height);

            foreach (var item in bmp1.PropertyItems)
            {
                if (item.Id == 274)
                {
                    newImage.SetPropertyItem(item);
                    break;
                }
            }

            newImage.Save(newPath, JpgEncoder, myEncoderParameters);
            newImage.Dispose();
            bmp1.Dispose();

            if (removeOriginalFile)
            {
                File.Delete(path);
                File.Move(newPath, Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path) + ".jpg"));
            }
        }
    }
}
