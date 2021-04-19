using System;
using System.Collections.Generic;
using System.Text;

namespace Reto
{
    public interface Iterator<T>
    {
        bool hasNext();
        T next();
    }
}