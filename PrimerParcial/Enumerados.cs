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
        public enum EPosiciones  //pertenece a la clase 'jugador'
        {
            Arquero,
            Defensor,
            Mediocampista,
            Delantero,
        }

        public enum ERol        //pertenece a la clase 'usuario'
        {
            Visitante,
            Admin,
        }

        public enum EResultado  //pertenece a la clase 'partido'
        {
            Local,
            Visitante,
            Empate,
        }



        //public static List<EPosiciones> GetAll()
        //{
        //    List<EPosiciones> list = new List<EPosiciones>();

        //    list.Add(EPosiciones.Arquero);
        //    list.Add(EPosiciones.Defensor);
        //    list.Add(EPosiciones.Mediocampista);
        //    list.Add(EPosiciones.Delantero);



        //    return list;
        //}
    }
}
