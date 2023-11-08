using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploColas
{
    public class NodoColas
    {
        public NodoColas next = null;
        public Object info;

        public NodoColas(object el) : this(el, null) { }
        public NodoColas(Object el, NodoColas sig)
        {
            info=el;
            next=sig;
        }
    }
}