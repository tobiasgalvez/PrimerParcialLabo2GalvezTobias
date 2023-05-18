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
        private static int _ultimoId = 0;
        private int _idPartido;
        //private DateTime _fechaPartido;
        private Equipo _equipoLocal;
        private Equipo _equipoVisitante;
        private Enumerados.EResultado _resultado;
        private int _golesLocal;
        private int _golesVisitante;
        private List<string> _eventos;
        private int _minutoActual;

        public Partido() 
        {
            _ultimoId++;
            _idPartido = _ultimoId;
            _eventos = new List<string>();
        }


        public Partido(/*DateTime fechaPartido,*/ Equipo equipoLocal, Equipo equipoVisitante, Enumerados.EResultado resultado, int golesLocal, int golesVisitante):this()
        {
            //_fechaPartido = fechaPartido;
            _equipoLocal = equipoLocal;
            _equipoVisitante = equipoVisitante;
            _resultado = resultado;
            _golesLocal = golesLocal;
            _golesVisitante = golesVisitante;
        }

        //public DateTime FechaPartido { get => _fechaPartido; set => _fechaPartido = value; }
        public int IdPartido { get => _idPartido; private set => _idPartido = value; }
        public Equipo EquipoLocal { get => _equipoLocal; set => _equipoLocal = value; }
        public Equipo EquipoVisitante { get => _equipoVisitante; set => _equipoVisitante = value; }
        public Enumerados.EResultado Resultado { get => _resultado; set => _resultado = value; }
        public int GolesLocal { get => _golesLocal; set => _golesLocal = value; }
        public int GolesVisitante { get => _golesVisitante; set => _golesVisitante = value; }
        public List<string> Eventos { get => _eventos; set => _eventos = value; }
        public int MinutoActual { private get => _minutoActual; set => _minutoActual = value; }

        public static void ValidarEnfrentamiento(string equipo1, string equipo2)
        {
            if(equipo1 == equipo2)
            {
                throw new Exception("Un equipo no puede jugar consigo mismo!!!");
            }
        }


        public void SimularPartido()
        {
            Random random = new Random();
            for (int i = 1; i <= 90; i++)
            {
                MinutoActual = i;
                int evento = random.Next(0, 100+1);

                // Simular un gol
                if (evento < 10)
                {
                    Equipo equipoGol;
                    if (random.Next(0, 2 + 1) == 0)
                        equipoGol = EquipoLocal;
                    else
                        equipoGol = EquipoVisitante;
                        equipoGol.Goles++;
                    Eventos.Add($"Minuto {MinutoActual}: Gol de {equipoGol.Nombre}");
                }
                // Simular una tarjeta amarilla
                else if (evento < 15)
                {
                    Equipo equipoTarjeta;
                    if (random.Next(0, 2 + 1) == 0)
                        equipoTarjeta = EquipoLocal;
                    else
                        equipoTarjeta = EquipoVisitante;
                    equipoTarjeta.TarjetasAmarillas++;
                    Eventos.Add($"Minuto {MinutoActual}: Tarjeta amarilla para {equipoTarjeta.Nombre}");
                }
                // Simular una tarjeta roja
                else if (evento < 17)
                {
                    Equipo equipoTarjeta;
                    if (random.Next(0, 2 + 1) == 0)
                        equipoTarjeta = EquipoLocal;
                    else
                        equipoTarjeta = EquipoVisitante;
                    equipoTarjeta.TarjetasRojas++;
                    Eventos.Add($"Minuto {MinutoActual}: Tarjeta roja para {equipoTarjeta.Nombre}");
                }
            }
        }

        public string ResumenPartido()
        {
            StringBuilder resumen = new StringBuilder();
            resumen.AppendLine($"Resultado final: {EquipoLocal.Nombre} {EquipoLocal.Goles} - {EquipoVisitante.Goles} {EquipoVisitante.Nombre}");
            GolesLocal = EquipoLocal.Goles;
            GolesVisitante = EquipoVisitante.Goles;
            if (GolesLocal < GolesVisitante)
            {
                Resultado = Enumerados.EResultado.Visitante;
                EquipoLocal.PartidosPerdidos++;
                EquipoVisitante.PartidosGanados++;

            }
            else if (GolesLocal == GolesVisitante)
            {
                Resultado = Enumerados.EResultado.Empate;
                EquipoLocal.PartidosEmpatados++;
                EquipoVisitante.PartidosEmpatados++;
            }
            else
            {
                EquipoLocal.PartidosGanados++;
                EquipoVisitante.PartidosPerdidos++;
            }
            resumen.AppendLine("Eventos importantes:");
            foreach (string evento in Eventos)
            {
                resumen.AppendLine(evento);
            }
            return resumen.ToString();
        }




        public static bool operator !=(Partido p1, Partido p2)
        {
            return (p1.EquipoLocal != p2._equipoLocal && p1.EquipoVisitante != p2.EquipoVisitante);
        }

        public static bool operator ==(Partido p1, Partido p2)
        {
            return (p1.EquipoLocal == p2._equipoLocal && p1.EquipoVisitante == p2.EquipoVisitante);
        }

    }
}
