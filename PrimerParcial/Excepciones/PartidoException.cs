using System.Runtime.Serialization;

namespace BibliotecaDeClases.Excepciones
{
    [Serializable]
    internal class partidoException : Exception
    {
        public partidoException()
        {
        }

        public partidoException(string? message) : base(message)
        {
        }

        public partidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected partidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}