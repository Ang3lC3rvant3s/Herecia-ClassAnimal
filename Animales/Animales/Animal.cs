using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Animales
{
    class Animal 
    {
        public string nombre { set; get; }
        public Image imagen { set; get; }

        public Animal(string nombre, Image imagen) 
        {
            this.nombre = nombre;
            this.imagen = imagen;
        }

        public virtual void sonido() { }
        
    }
}
