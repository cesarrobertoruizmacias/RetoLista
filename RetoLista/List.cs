using System;
using System.Collections.Generic;
using System.Text;


namespace Reto
{
    public interface List<T>
    {
        void add(T data);
        T get(int index);
        void delete(int index);
        int getSize();
        Iterator<T> getIterator();
        Iterator<T> getReverseIterator();
    }
}