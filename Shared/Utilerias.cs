using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.Cryptography;

namespace ScaGuerrero.Shared
{
    public static class Utilerias
    {
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new(byteArrayIn);
            ms.Seek(0, SeekOrigin.Begin);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static byte[] ImageTobyteArray(System.Drawing.Image imageIn, ImageFormat format)
        {
            MemoryStream ms = new();
            imageIn.Save(ms, format);
            return ms.ToArray();
        }

        public static string NumeroToPesos(string cadena)
        {
            string resultado = "";
            for (int i = 0; i < cadena.Length; i++)
            {
                resultado += cadena.Substring(i, 1);
            }
            return resultado;
        }
        public static string Codifica(string cadena)
        {         
            SHA256Managed sha = new();
            byte[] buffer = Encoding.Default.GetBytes(cadena);
            byte[] dataCifrada = sha.ComputeHash(buffer);
            string NewPassword = BitConverter.ToString(dataCifrada).Replace("-", "");
            return NewPassword;
        }
    }
}
