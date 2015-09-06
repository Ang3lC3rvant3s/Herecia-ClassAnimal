using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace Animales
{
    class Leon : Animal
    {
        public Leon(string nombre, Image imagen)
            : base(nombre, imagen)
        { }
        public override void sonido()
        {
            SoundPlayer soni = new SoundPlayer("Leon.wav");
            soni.Play();
        }
    }
}
