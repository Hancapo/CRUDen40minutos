using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinguinPapu
{
    public class MetodosPinguino
    {
        public bool AgregarPenguino(Pinguino pe, List<Pinguino> ListaPinguino)
        {
            bool encontrado = ListaPinguino.Exists(x => x.Nombre == pe.Nombre);

            if (!encontrado)
            {
                ListaPinguino.Add(pe);  
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ImprimirPinguinos(List<Pinguino> pinguinos)
        {
            StringBuilder sb = new();
            sb.AppendLine("====================");
            pinguinos.ForEach(x => sb.AppendLine($"\nNombre pingüino: {x.Nombre}\nColor pingüino: {x.Color}\nAltura pingüina: {x.Altura}"));
            sb.AppendLine("====================");
            Console.Write(sb.ToString());

        }

        public bool EditarPinguino(string nombreViejo, Pinguino pe, List<Pinguino> pinguinos)
        {
            bool encontrado = pinguinos.Exists(x => x.Nombre == nombreViejo);
            if (encontrado)
            {
                var indice = pinguinos.FindIndex(x => x.Nombre == nombreViejo);
                pinguinos[indice] = pe; 
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool EliminarPinguino(Pinguino pe, List<Pinguino> ListaPinguino)
        {
            bool encontrado = ListaPinguino.Exists(x => x.Nombre == pe.Nombre);

            if (encontrado)
            {
                 
                ListaPinguino.Remove(ListaPinguino.First(x => x.Nombre == pe.Nombre));
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
