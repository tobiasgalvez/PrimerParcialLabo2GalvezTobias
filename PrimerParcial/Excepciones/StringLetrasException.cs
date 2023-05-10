using System.Runtime.Serialization;

namespace BibliotecaDeClases.Excepciones
{
    [Serializable]
    internal class StringLetrasException : Exception
    {
        public StringLetrasException()
        {
        }

        public StringLetrasException(string? message) : base(message)
        {
        }

        public StringLetrasException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected StringLetrasException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}