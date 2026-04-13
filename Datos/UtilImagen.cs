using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Datos
{
    public  class UtilImagen
    {
        public static byte[] ImagenABytes(Image imagen)
        {
            if (imagen == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap bmp = new Bitmap(imagen);
                bmp.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public static Image BytesAImagen(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

    }
}
