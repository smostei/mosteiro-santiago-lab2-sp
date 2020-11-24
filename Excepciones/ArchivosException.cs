using System;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        public ArchivosException() : base() { }
        public ArchivosException(string mensaje) : base(mensaje) { }
    }
}
