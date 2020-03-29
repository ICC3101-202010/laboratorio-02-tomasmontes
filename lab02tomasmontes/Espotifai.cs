using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02tomasmontes
{
    public class Espotifai
    {
        List<cancion> canciones = new List<cancion>();

        public bool agregarcancion(cancion nuevacancion)
        {
            foreach (cancion cancion in canciones)
            {
                if (cancion.Nombre == nuevacancion.Nombre && cancion.Album == nuevacancion.Album && cancion.Artista == nuevacancion.Artista)
                {
                    return false;
                }
                    
            }
            canciones.Add(nuevacancion);
            return true;
        }
    }
}
