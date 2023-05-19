using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Enumerados;

namespace BibliotecaDeClases.ManejadorCsv
{
    public class ManejadorCsvUsuarios : ManejadorCsvBase<Usuario>
    {
        public ManejadorCsvUsuarios(string csvFilePath) : base(csvFilePath)
        {
        }

        public override List<Usuario> LeerDatos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            DateTime fechaNacimiento;
            ERol rol;

            using (StreamReader reader = new StreamReader(_csvFilePath))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] partes = linea.Split(',');
                    fechaNacimiento = DateTime.Parse(partes[2]);
                    rol = Enum.Parse<ERol>(partes[6]);

                    usuarios.Add(new Usuario(partes[0], partes[1], fechaNacimiento, int.Parse(partes[3]), partes[4], partes[5], rol));
                }
            }
            return usuarios;
        }


        public override void AgregarDato(Usuario usuario)
        {
            using (var sw = new StreamWriter(_csvFilePath, true)) // el using sería como un try-finally en donde el finally tira un dispose al archivo 
            {
                sw.WriteLine($"{usuario.Nombre},{usuario.Apellido}, {usuario.FechaDeNacimiento}, {usuario.Dni},{usuario.User},{usuario.Contraseña},{usuario.Rol}");
            }
        }

        public override void ModificarDato(Usuario usuarioOriginal, Usuario usuarioModificado)
        {
            var usuarios = LeerDatos();
            int indice = Usuario.BuscarIndice(usuarios, usuarioOriginal);

            if (indice != -1)
            {
                usuarios[indice] = usuarioModificado;
                GuardarDatos(usuarios);
            }
        }


        public override void EliminarDato(Usuario usuario)
        {
            var usuarios = LeerDatos();
            foreach (var item in usuarios)
            {
                if (usuario == item)
                {
                    usuarios.Remove(item);
                }
            }
            GuardarDatos(usuarios);
        }

        public override void GuardarDatos(List<Usuario> usuarios)
        {
            using (var sw = new StreamWriter(_csvFilePath, false)) //el false sobrescribe el archivo, mientras que el true agrega contenido al archivo existente
            {
                //sw.WriteLine("Nombre,Apellido,FechaDeNacimiento,Dni,Posicion,Equipo");
                foreach (var usuario in usuarios)
                {
                    sw.WriteLine($"{usuario.Nombre},{usuario.Apellido}, {usuario.FechaDeNacimiento}, {usuario.Dni},{usuario.User},{usuario.Contraseña},{usuario.Rol}");
                }
            }
        }


    }
}
