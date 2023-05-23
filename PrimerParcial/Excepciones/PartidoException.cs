using System.Runtime.Serialization;

namespace BibliotecaDeClases.Excepciones
{
    [Serializable]
    public class PartidoException : Exception
    {
        public PartidoException()
        {
        }

        public PartidoException(string? message) : base(message)
        {
        }

        public PartidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected PartidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}