using System;
using System.Collections.Generic;
using System.Text;

namespace Archivos
{
    public interface IArchivo<T>
    {
        string RutaArchivo();
        bool Guardar(T datos);
        bool Leer(out T datos);
    }
}
