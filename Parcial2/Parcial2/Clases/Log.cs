using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace Parcial2.Clases
{
    
    internal class Log
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private string mensaje;
        

        public Log () 
        { 
            LogManager.ThrowExceptions = true;
        }
        public void setMensaje( string mensaje)
        {
            this.mensaje = mensaje;
        }
        public void informacion()
        {
            logger.Info(mensaje);
        }
        public void informacion(Exception ex)
        {
            logger.Error(ex, "mensaje");
        }
    }
}
