using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Npgsql;

namespace Modulo_IV
{
    internal class conexionDB: IDisposable
    {
        private string servidor="";
        private string baseDatos = "";
        private string usuario = "";
        private string password = "";
        private string puerto = "";
        private NpgsqlConnection socket;

        public NpgsqlConnection getSocket()
        {
            return socket;
        }
        public void conectar()
        {
            string cadenaConexion = "";
        }
        public void lecturaXML()   
        {
            string rutaXML = "../../config/configDB.xml";
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root;
            try
            {
                xmlDocument.Load(rutaXML);
                root = xmlDocument.DocumentElement;
                servidor = decode64(root.SelectSingleNode("host").InnerText);
                baseDatos = decode64(root.SelectSingleNode("dbname").InnerText);
                usuario = decode64(root.SelectSingleNode("usuario").InnerText);
                password = decode64(root.SelectSingleNode("password").InnerText);
                puerto = decode64(root.SelectSingleNode("puerto").InnerText);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
        private string decode64(string str)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(str));
        }

        public void Dispose() 
        {
        }
    }
}
