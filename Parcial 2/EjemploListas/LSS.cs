using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigadaSimple
{
    public class LSS
    {
        protected LLSNodo inicio, final;
        public LSS() { inicio = final = null!; }
        public bool estaVacia() { return inicio == null; }
        
        public void insertarInicio(int el) 
        {
            inicio = new LLSNodo(el, inicio);
            if (final == null) 
            {
                final = inicio;
            }
        }
        public void insertarFinal(int el)
        {
            if (inicio == null) //si la lista esta vacía se utiliza insertarInicio
                insertarInicio(el);
            else  //si la lista no esta vacía, debemos posicionar un elemento en el último nodo
            {
                LLSNodo temp; //Nombre del nodo temporal que se posiciona en la última posición
                for (temp = inicio; temp.next != null; temp=temp.next) //Posiciona a temp en la última posición
                    continue;
                temp.next = new LLSNodo(el);
                
            }
        }
        public bool eliminarInicio() 
        {
            if (inicio == null) //si la lista esta vacía no es posible eliminar
                return false;
            else
                inicio = inicio.next;
            return true;
        }
        public bool eliminarFinal()
        {
            if (inicio == null) //si la lista esta vacía no es posible eliminar
                return false;
            if (inicio.next == null) //si la lista solo tiene un nodo utilizamos eliminarInicio
                return eliminarInicio();
            LLSNodo temp=encontrarPenultimo(); //Utiliza un método auxiliar para encontrar el penúltimo
            temp.next=null;
            return true;
        }
        public void mostrarLista() 
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía. Por favor, ingrese elementos antes de mostrar la lista.");
            }
            else
            {
                for (LLSNodo temp = inicio; temp != null; temp = temp.next)
                {
                    Console.Write(temp.info + "->");
                }
            }
        }

        public int numeroElementos() 
        {
            int elementos = 0;
            for (LLSNodo temp = inicio; temp != null; temp = temp.next, elementos++) ;
            return elementos;
        }
        public LLSNodo encontrarPenultimo() //método que sirve para devolver el penúltimo elemento de la lista
        {
            LLSNodo temp = inicio, ultimo;
            for (ultimo = inicio; ultimo.next != null; ultimo = ultimo.next)
                temp = ultimo;
            return temp;
        }
        public bool buscarElemento(int el)
        {
            LLSNodo temp= inicio;
            while (temp != null) //mientras no llegue al final
            {
                if(temp.info == el) //Si lo encuentra devuelve true
                    return true;
                temp = temp.next;
            }
            return false; //No lo encontro, devuelve false
        }
        public void borrarElemento(int el)
        { 
                if (inicio == null)
            {
                Console.WriteLine("La lista está vacía, no se puede eliminar ningún elemento.");
                return;
            }

            // Verificar si el elemento a eliminar está en el primer nodo
            if (inicio.info == el)
            {
                inicio = inicio.next;
                return;
            }

            LLSNodo temp = inicio;
            while (temp.next != null && temp.next.info != el)
            {
                temp = temp.next;
            }

            // Si se encuentra el elemento a eliminar
            if (temp.next != null)
            {
                temp.next = temp.next.next;
            }
            else
            {
                Console.WriteLine("Elemento no encontrado en la lista.");
            }
        }
        public void Burbuja()
        {
            int elementos = numeroElementos(); // Llama al método con "n" en minúscula
            if (elementos <= 1)
            {
                Console.WriteLine("La lista está vacía o solo contiene un elemento. Por favor, ingrese más elementos antes de ordenar.");
                return;
            }

            LLSNodo primero, segundo;
            bool seguir = true;

            while (seguir) 
            {
                seguir = false;
                for (primero = inicio, segundo = inicio.next; segundo != null; primero = primero.next, segundo = segundo.next) 
                {
                    if (primero.info > segundo.info) 
                    {
                        int intTemp = primero.info;
                        primero.info = segundo.info;
                        segundo.info = intTemp;
                        seguir = true;
                    }
                }
            }
        }

        public void Invertir()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía. Por favor, ingrese elementos antes de invertir.");
                return;
            }
            
            if (numeroElementos() > 1) //Si la lista tiene más de un elemento
            {
                LLSNodo frente = inicio, atras;
                for (atras = inicio; atras.next != null; atras = atras.next) ; //Coloca atras en la última posición
                while (frente != atras && atras.next != frente)
                {
                    int temp = frente.info;
                    frente.info = atras.info;
                    atras.info = temp;
                    frente = frente.next;
                    LLSNodo nodoTemp = atras;
                    for (atras = inicio; atras.next != nodoTemp; atras = atras.next) ;
                }
            }
        }

        public bool AgregarElemento(int el, int n)
        {
            if (inicio == null || n == 1) {
                insertarInicio(el);
                return false;
            } //si la lista esta vacía se utiliza insertarInicio
                
            else  //si la lista no esta vacía, debemos posicionar un elemento en el último nodo
            {
                int i = 1;
                LLSNodo temp = inicio;
                while (temp != null && i < n - 1)
                {
                    temp = temp.next;
                    i++;
                }

                if (temp != null)
                {
                    LLSNodo nuevoNodo = new LLSNodo(el);
                    nuevoNodo.next = temp.next;
                    temp.next = nuevoNodo;
                }
                else
                {
                    // La posición deseada es más allá del final de la lista, no se realiza la inserción
                    return false;
                }
            }

            return true;
        }

        public bool EliminarEnPosicion(int n)
        {
            if (n <= 0 || inicio == null)
            {
                // Posición no válida o la lista está vacía, no se realiza la eliminación
                return false;
            }

            if (n == 1)
            {
                // Si se elimina el primer nodo, simplemente actualiza la referencia al inicio
                inicio = inicio.next;
            }
            else
            {
                int i = 1;
                LLSNodo temp = inicio;
                while (temp != null && i < n - 1)
                {
                    temp = temp.next;
                    i++;
                }

                if (temp != null && temp.next != null)
                {
                    temp.next = temp.next.next; // Elimina el nodo en la posición deseada
                }

                else if (temp != null && temp.next == null)
                {
                    temp = null; // Elimina el nodo en la posición deseada
                }

                else 
                {
                    // La posición deseada está más allá del final de la lista, no se realiza la eliminación
                    return false;
                }
            }

            return true;
        }
    }
}
