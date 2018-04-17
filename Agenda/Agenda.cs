using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Agenda
    {
        Contacto[] personas = new Contacto[15];
        private int i = 0;
        public Agenda()
        {

        }
        public void Agregar(Contacto contacto)
        {
            personas[i] = contacto;
            i++;
        }

        public string Buscar(int telefono)
        {
            string contacto = "";
            int contador = 0;
            while (contador < personas.Length - 1 && personas[contador].Telefono != telefono)
            {
                contador++;
            }
            if (contador > personas.Length-1)
            {
            }
            else
            {
                return contacto = personas[contador].ToString();
            }
            return null;
        }

        public void Eliminar(int telefono)
        {
            int contador1 = 0;
            while (contador1 < personas.Length-1 && personas[contador1].Telefono != telefono)
            {
                contador1++;
            }
            if (contador1 > personas.Length-1)
            {
            }
            else
            {
                for (int contador2 = contador1; contador2 < personas.Length-2; contador2++)
                {
                    personas[contador2] = personas[contador2 + 1];
                }
                i--;
            }
        }
        public void Insertar(int posicion, Contacto contacto)
        {
           
            for (int contador = personas.Length-2; contador >= posicion; contador--)
            {
               personas[contador+1] = personas[contador];
            }
            personas[posicion] = contacto;
            i++;
        }
        public override string ToString()
        {
            string cadena = "";
            int contador = 0;
            while(personas[contador] != null)
            {
                cadena += personas[contador].ToString();
                contador++;
            }
            return cadena;
        }
    }
}
