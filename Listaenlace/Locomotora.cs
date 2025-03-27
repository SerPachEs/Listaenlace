using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listaenlace
{
    class Locomotora
    {
        vagon Primero {  get; set; }
        public void AgregarPrimero(int valor) 
        {
          
        }
        
        public void AgregaFinal(int valor )
        {
            vagon nuevo = new vagon(valor);
            if (this.Primero == null)
            {
                this.Primero = nuevo;
            }
            else
            {
                vagon tmp = this.Primero;
                while (tmp.Sig != null)
                {
                    tmp = tmp.Sig;

                }
                tmp.Sig = nuevo;
            }
            }

                
        
        public string VerVagones()
        {
            string ListaVag = "";
            vagon tmp= this.Primero;
            while (tmp != null) { 
            ListaVag += tmp.Dato+",";
                tmp = tmp.Sig;
            }
            return ListaVag;

        }
    }
}
