using BibliotecaDeClases.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Partido
    {
       // Dictionary<int, string> _partido; //string para ver quien ganó?
        //private static int _ultimoId = 0;
        //private int _idPartido;
        //private DateTime _fechaPartido;
        private Equipo _equipoLocal;
        private Equipo _equipoVisitante;
        private Enumerados.EResultado _resultado;
        private int _golesLocal;
        private int _golesVisitante;
        private int _tarjetasAmarillasLocal;
        private int _tarjetasAmarillasVisitante;
        private int _tarjetasRojasLocal;
        private int _tarjetasRojasVisitante;
        private List<string> _eventos;
        private string _torneo;
        private int _minutoActual;


        public Partido() 
        {
            //_ultimoId++;
            //_idPartido = _ultimoId;
            _eventos = new List<string>();
            //_equipoLocal = new Equipo();
            //_equipoVisitante = new Equipo();
        }

        //public Partido(/*DateTime fechaPartido,*/ Equipo equipoLocal, Equipo equipoVisitante, Enumerados.EResultado resultado, int golesLocal, int golesVisitante, string torneo) : this()
        //{
        //    //_fechaPartido = fechaPartido;
        //    _equipoLocal = equipoLocal;
        //    _equipoVisitante = equipoVisitante;
        //    _resultado = resultado;
        //    _golesLocal = golesLocal;
        //    _golesVisitante = golesVisitante;
        //    _torneo = torneo;
 
        //}


        public Partido(/*DateTime fechaPartido,*/ Equipo equipoLocal, Equipo equipoVisitante, Enumerados.EResultado resultado, int golesLocal, int golesVisitante, string torneo, int tarjetasAmarillasLocal, int tarjetasAmarillasVisitante, int tarjetasRojasLocal, int tarjetasRojasVisitante) : this()
        {
            //_fechaPartido = fechaPartido;
            _equipoLocal = equipoLocal;
            _equipoVisitante = equipoVisitante;
            _resultado = resultado;
            _golesLocal = golesLocal;
            _golesVisitante = golesVisitante;
            _torneo = torneo;
            _tarjetasAmarillasLocal = tarjetasAmarillasLocal;
            _tarjetasAmarillasVisitante = tarjetasAmarillasVisitante;
            _tarjetasRojasLocal = tarjetasRojasLocal;
            _tarjetasRojasVisitante = tarjetasRojasVisitante;
        }

        //public DateTime FechaPartido { get => _fechaPartido; set => _fechaPartido = value; }
        //public int IdPartido { get => _idPartido; private set => _idPartido = value; }
        public Equipo EquipoLocal { get => _equipoLocal; set => _equipoLocal = value; }
        public Equipo EquipoVisitante { get => _equipoVisitante; set => _equipoVisitante = value; }
        public Enumerados.EResultado Resultado { get => _resultado; set => _resultado = value; }
        public int GolesLocal { get => _golesLocal; set => _golesLocal = value; }
        public int GolesVisitante { get => _golesVisitante; set => _golesVisitante = value; }
        public List<string> Eventos { get => _eventos; set => _eventos = value; }
        public int MinutoActual { private get => _minutoActual; set => _minutoActual = value; }
        public string Torneo { get => _torneo; set => _torneo = value; }
        public int TarjetasAmarillasLocal { get => _tarjetasAmarillasLocal; set => _tarjetasAmarillasLocal = value; }
        public int TarjetasAmarillasVisitante { get => _tarjetasAmarillasVisitante; set => _tarjetasAmarillasVisitante = value; }
        public int TarjetasRojasLocal { get => _tarjetasRojasLocal; set => _tarjetasRojasLocal = value; }
        public int TarjetasRojasVisitante { get => _tarjetasRojasVisitante; set => _tarjetasRojasVisitante = value; }

        public static void ValidarEnfrentamiento(Equipo equipo1, Equipo equipo2)
        {
            if(equipo1 == equipo2)
            {
                throw new partidoException("Un equipo no puede jugar consigo mismo!!!");
            }
            //if (equipo1.ListaJugadores.Count < 11 || equipo2.ListaJugadores.Count < 11)
            //{
            //    throw new partidoException("Uno o dos equipos no tiene/n suficientes jugadores para jugar el partido (mínimo 11)!");
            //}
        }


        public static int BuscarIndice(List<Partido> partidos, Partido partido)
        {
            int indice = -1;
            for (int i = 0; i < partidos.Count; i++)
            {
                if (partidos[i] == partido)
                {
                    indice = i;
                }
            }

            return indice;
        }


        public void SimularPartido()
        {
            Random random = new Random();

            for (int i = 1; i <= 90; i++)
            {
                MinutoActual = i;
                int evento = random.Next(0, 100 + 1);//hasta 100

                // Simular un gol
                if (evento < 10)
                {
                    if (random.Next(0, 2) == 0)
                    {
                        EquipoLocal.Goles++;
                        Eventos.Add($"Minuto {MinutoActual}: Gol de {EquipoLocal.Nombre}");
                    }
                    else
                    {
                        EquipoVisitante.Goles++;
                        Eventos.Add($"Minuto {MinutoActual}: Gol de {EquipoVisitante.Nombre}");
                    }
                }
                // Simular una tarjeta amarilla
                else if (evento < 15)
                {
                    if (random.Next(0, 2) == 0)
                    {
                        EquipoLocal.TarjetasAmarillas++;
                        Eventos.Add($"Minuto {MinutoActual}: Tarjeta amarilla para {EquipoLocal.Nombre}");
                    }
                    else
                    {
                        EquipoVisitante.TarjetasAmarillas++;
                        Eventos.Add($"Minuto {MinutoActual}: Tarjeta amarilla para {EquipoVisitante.Nombre}");
                    }
                }
                // Simular una tarjeta roja
                else if (evento < 17)
                {
                    if (random.Next(0, 2) == 0)
                    {
                        EquipoLocal.TarjetasRojas++;
                        Eventos.Add($"Minuto {MinutoActual}: Tarjeta roja para {EquipoLocal.Nombre}");
                    }
                    else
                    {
                        EquipoVisitante.TarjetasRojas++;
                        Eventos.Add($"Minuto {MinutoActual}: Tarjeta roja para {EquipoVisitante.Nombre}");
                    }
                }
            }
        }

        public string ResumenPartido()
        {
            StringBuilder resumen = new StringBuilder();
            resumen.AppendLine($"Resultado final: {EquipoLocal.Nombre} {EquipoLocal.Goles} - {EquipoVisitante.Goles} {EquipoVisitante.Nombre}");
            GolesLocal = EquipoLocal.Goles;
            GolesVisitante = EquipoVisitante.Goles;
            TarjetasAmarillasLocal = EquipoLocal.TarjetasAmarillas;
            TarjetasRojasLocal = EquipoLocal.TarjetasRojas;
            TarjetasAmarillasVisitante = EquipoVisitante.TarjetasAmarillas;
            TarjetasRojasVisitante = EquipoVisitante.TarjetasRojas;


            //int hola = EquipoLocal.TarjetasAmarillas;
            //int hola2 = EquipoVisitante.TarjetasAmarillas;

            //ActualizarEstadisticas();

            resumen.AppendLine("Eventos importantes:");
            foreach (string evento in Eventos)
            {
                resumen.AppendLine(evento);
            }
            return resumen.ToString();
        }

        //private void ActualizarEstadisticas()
        //{
        //    if (GolesLocal < GolesVisitante)
        //    {
        //        Resultado = Enumerados.EResultado.Visitante;
        //        EquipoLocal.PartidosPerdidos++;
        //        EquipoVisitante.PartidosGanados++;
        //    }
        //    else if (GolesLocal == GolesVisitante)
        //    {
        //        Resultado = Enumerados.EResultado.Empate;
        //        EquipoLocal.PartidosEmpatados++;
        //        EquipoVisitante.PartidosEmpatados++;
        //    }
        //    else
        //    {
        //        EquipoLocal.PartidosGanados++;
        //        EquipoVisitante.PartidosPerdidos++;
        //    }
        //}



        public static bool operator !=(Partido p1, Partido p2)
        {
            return (p1.EquipoLocal != p2.EquipoLocal && p1.EquipoVisitante != p2.EquipoVisitante);
        }

        public static bool operator ==(Partido p1, Partido p2)
        {
            return (p1.EquipoLocal == p2.EquipoLocal && p1.EquipoVisitante == p2.EquipoVisitante);
        }
    }
}
