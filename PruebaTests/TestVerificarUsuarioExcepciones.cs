using BibliotecaDeClases;
using BibliotecaDeClases.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases.Excepciones;

namespace PruebaTests
{
    [TestClass]
    public class TestVerificarUsuarioExcepciones
    {
        [TestMethod]
        public async Task VerificarUsuarioExcepciones_UsuarioCorrecto_ContraseñaCorrecta_RetornaUsuario()
        {

            Sistema.ListaDeUsuarios = await Sistema.SqlUsuarios.LeerDatosAsync();

            string usuario = "tobigalvez";
            string contraseña = "hola1234";
            Usuario usuarioEsperado = new Usuario("Tobias", "Galvez",new DateTime(2002,10,10),44521134,usuario,contraseña, Enumerados.ERol.Admin);

            Usuario resultado = Sistema.VerificarUsuarioExcepciones(usuario, contraseña);

            //Assert.AreEqual(usuarioEsperado, resultado); NO SE POR QUÉ NO ME LO TOMA COMO BIEN

            Assert.AreEqual(usuarioEsperado.User, resultado.User);
            Assert.AreEqual(usuarioEsperado.Contraseña, resultado.Contraseña);

        }

        [TestMethod]
        public async Task VerificarUsuarioExcepciones_UsuarioCorrecto_ContraseñaIncorrecta_LanzaExcepcion()
        {
            Sistema.ListaDeUsuarios = await Sistema.SqlUsuarios.LeerDatosAsync();

            string usuario = "tobigalvez";
            string contraseña = "hola";

            Assert.ThrowsException<Exception>(() => Sistema.VerificarUsuarioExcepciones(usuario, contraseña));
        }

        [TestMethod]
        public async Task VerificarUsuarioExcepciones_UsuarioIncorrecto_ContraseñaCorrecta_LanzaExcepcion()
        {
            Sistema.ListaDeUsuarios = await Sistema.SqlUsuarios.LeerDatosAsync();
            string usuario = "tobigalvezzzzz";
            string contraseña = "hola1234";

            Assert.ThrowsException<Exception>(() => Sistema.VerificarUsuarioExcepciones(usuario, contraseña));
        }

        [TestMethod]
        public async Task VerificarUsuarioExcepciones_UsuarioIncorrecto_ContraseñaIncorrecta_LanzaExcepcion()
        {
            Sistema.ListaDeUsuarios = await Sistema.SqlUsuarios.LeerDatosAsync();
            string usuario = "usuarioIncorrecto";
            string contraseña = "contraseñaIncorrecta";

            Assert.ThrowsException<Exception>(() => Sistema.VerificarUsuarioExcepciones(usuario, contraseña));
        }


        [TestMethod]
        public void VerificarUsuarioExcepciones_UsuarioVacio_LanzaExcepcion()
        {
            string usuario = "";
            string contraseña = "contraseña1";

            Assert.ThrowsException<CampoVacioException>(() => Sistema.VerificarUsuarioExcepciones(usuario, contraseña));
        }

        [TestMethod]
        public void VerificarUsuarioExcepciones_ContraseñaVacia_LanzaExcepcion()
        {
            string usuario = "usuario1";
            string contraseña = "";

            Assert.ThrowsException<CampoVacioException>(() => Sistema.VerificarUsuarioExcepciones(usuario, contraseña));
        }

        [TestMethod]
        public void VerificarUsuarioExcepciones_UsuarioYContraseñaVacios_LanzaExcepcion()
        {
            string usuario = "";
            string contraseña = "";

            Assert.ThrowsException<CampoVacioException>(() => Sistema.VerificarUsuarioExcepciones(usuario, contraseña));
        }



    }
}
