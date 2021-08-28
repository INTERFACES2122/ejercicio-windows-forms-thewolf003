using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Clase para almacenar los datos de una persona
namespace FormularioTarea
{
    public class Datos
    {
        private string nombre;
        private string primerAp;
        private string segundoAp;
        public Datos()
        {

        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string ApPaterno
        {
            get { return primerAp; }
            set { primerAp = value; }
        }
        public string ApMaterno
        {
            get { return segundoAp; }
            set { segundoAp = value; }
        }
    }
}
