using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Npgsql;

namespace Parcial2.Clases
{
    internal class ConexionDB : IDisposable
    {
        private string _host;
        private string _db;
        private string _user;
        private string _password;
        private string _port;
        private NpgsqlConnection myCnnection;

        public NpgsqlConnection GetConnection()
        {
            return myCnnection;
        }
        public void Conectar ()
        {
            LeerXML();
            string cadenaConeccion = 
                $"Host={_host};" +
                $"Port={_port};" +
                $"Database={_db};" +
                $"Username={_user};" +
                $"Password={_password}";
            myCnnection = new NpgsqlConnection (cadenaConeccion);
            myCnnection.Open ();    
        }

        public void LeerXML()
        {
            string path = "../../Config/Config.xml";
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root;
            try
            {
                xmlDocument.Load(path);
                root = xmlDocument.DocumentElement;
                _host = root.SelectSingleNode("host").InnerText;
                _port = root.SelectSingleNode("port").InnerText;
                _db = root.SelectSingleNode("dbname").InnerText;
                _user = root.SelectSingleNode("user").InnerText;
                _password = root.SelectSingleNode("password").InnerText;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Dispose()
        {
            CerrarConexion();   
        }
        public void CerrarConexion()
        {
            if (myCnnection != null && myCnnection.State != System.Data.ConnectionState.Closed)
            {
                myCnnection.Close ();
            }
        }
        
    }
}
