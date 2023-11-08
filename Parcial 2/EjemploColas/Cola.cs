using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploColas
{
    public class Cola
    {
        private NodoColas head, tail;
        public Cola()
        {
            head = tail = null;
        }
        public void vaciarCola()
        {
            head = tail = null;
        }
        public void Enqueue()
        {
            System.Console.Write("Ingrese el valor: "); Object el = Console.ReadLine();

            if (head == null)
            {
                tail = head = new NodoColas(el, head);
            }

            else
            {
                NodoColas tmp;
                for (tmp = head; tmp.next != null; tmp=tmp.next) //Posiciona a temp en la última posición
                    continue;
                tmp.next = new NodoColas(el);
                // tail = head;
            }
        }
        public Object Dequeue()
        {
            if (head == null)
            {
                return "Cola Vacia";
            }

            else
            {
                Object temp = null;
                NodoColas temp2 = null;

                if (head == tail)
                {
                    temp = head.info;
                    head = tail = null;
                }

                else
                {
                    temp = head.info;
                    head = head.next;
                }

                return temp;
            }
        }

        public void ElemEncima() {
            if (head == null)   System.Console.WriteLine("La cola esta vacía");

            else {
                System.Console.WriteLine($"El elemento que esta encima es: {head.info}");
            }
        }
        public bool Vacio()
        {
            return head == null;
        }

        public void Imprime(){
        NodoColas tmp;

            if (Vacio())
            {
                System.Console.WriteLine("NO hay elementos en la pila");
            }
            
            else
            {
                tmp = head;
                do{
                    System.Console.WriteLine("************** "+tmp.info+" **************");                
                    tmp = tmp.next;
                } while ( tmp != null );
            }
        }

        public bool Buscar(object el)
        {
            NodoColas temp = head;
            while (temp != null) //mientras no llegue al final
            {
                if(temp.info.ToString() == el.ToString()) //Si lo encuentra devuelve true
                    return true;
                temp = temp.next;
            }
            return false; //No lo encontro, devuelve false
        }
    }
}