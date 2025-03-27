using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listaenlace
{
    class vagon
    {
        private int valor;

       
        public int Dato { get; set; }
        public vagon Sig {  get; set; }
        public vagon (int dato)
        {
            Dato = dato; 
        }

        public vagon()
        {
        }
    }
}
