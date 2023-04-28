using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Enumerados
    {
        public enum EPosiciones
        {
            Arquero,
            Defensor,
            Mediocampista,
            Delantero,
        }

        public static List<EPosiciones> GetAll()
        {
            List<EPosiciones> list = new List<EPosiciones>();

            list.Add(EPosiciones.Arquero);
            list.Add(EPosiciones.Defensor);
            list.Add(EPosiciones.Mediocampista);
            list.Add(EPosiciones.Delantero);

            return list;
        }
    }
}
