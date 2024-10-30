using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Parcial2
{
    internal class MetodosGenerales
    {
        // validar los input del textbox
        public void esDigito(TextBox input, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) || Char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == '-' && !input.Text.Contains('-'))
            {
                return;
            }
            e.Handled = true;
        }
        public void esDecimal(TextBox input, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) || Char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == '.' && !input.Text.Contains('.'))
            {
                return;
            }
            e.Handled = true;
        }
        public void soloNumero(TextBox input, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) || Char.IsDigit(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }
     // Cargar imagen al PictureBox desde Windows
        public void CargarImagen (PictureBox pb)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.PNG;*.JPG;*.GIF)|*.PNG;*.JPG;*.GIF|All files(*.*) | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb.Image = Image.FromFile(ofd.FileName);
            }
        }
    // Convertir la imagen a texto Base64
        public string ImageToBase64 (Image image, ImageFormat format)
        {
            if(image == null)
            {
                return "null";
            }
            MemoryStream ms = new MemoryStream();
            image.Save(ms, format);
            Byte[] imageByte= ms.ToArray();
            string base64String = Convert.ToBase64String(imageByte);    
            return base64String;
        }
    // Convertir Texto Base64 a Imagan
        public Image Base64ToImage (string base64)
        {
            if(String.IsNullOrEmpty(base64) || base64 == "null")
            {
                return null;
            }
            Byte[] bytes = Convert.FromBase64String(base64);
            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }
    }
}
