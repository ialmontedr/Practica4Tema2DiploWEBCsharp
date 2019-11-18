using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace ProyectoRegistroPersonasMVCCap2.Models
{
    public class LibroVisitas
    {
        public void Grabar(string nombre, string cedula, string telefonos, string correo)
        {
            StreamWriter archivo = new StreamWriter(HostingEnvironment.MapPath("~") + "/App_data/datos.txt", true);
            archivo.WriteLine("Nombre:" + nombre + "<br>Cedula:" + cedula + "<br>Telefono:" + telefonos + "<br>Email:" + correo + "<hr>");
            archivo.Close();
        }      
        public string Leer()
        {
            StreamReader archivo = new StreamReader(HostingEnvironment.MapPath("~") + "/App_Data/datos.txt");
            string todo = archivo.ReadToEnd();
            archivo.Close();
            return todo;
        }
    }
}