    public class ArbolBinario
    {
        NodoArbol root;
        public static List<int> ListaNumeros = new List<int>();
        static List<int> valoresRecuperados = new List<int>();
        static int valorMaximo;

        public ArbolBinario()
        {
            root = null;        
        }

        public void Inserta(Object el)
        {
            this.Inserta(root, el);
        }

       
        private void Inserta(NodoArbol actual, Object el)
        {
            if (root == null)
                root = new NodoArbol(el);
            else
            {
                if ((int)actual.info >= (int)el)
                    if (actual.Left != null)
                        Inserta(actual.Left, el);
                    else
                        actual.Left = new NodoArbol(el);
                else
                    if (actual.Right != null)
                        Inserta(actual.Right, el);
                    else
                        actual.Right = new NodoArbol(el); 
            }
        }

        public void Busqueda(Object el) {
            if (root == null) {
                System.Console.WriteLine("El árbol esta vacío");
                return;
            }

            var nodoBuscado = this.Busqueda(root, el);

            if(nodoBuscado == null) {
                System.Console.WriteLine("El número no existe dentro del árbol");
            }

            else {
                System.Console.WriteLine("El número existe dentro del árbol");
            }
        }

        private NodoArbol Busqueda(NodoArbol actual, Object el) {
            if ((int)actual.info == (int)el)  {
                return actual;
            }

            if ((int)actual.info > (int)el)
                if (actual.Left != null)
                    return Busqueda(actual.Left, el);
                else {
                    return null;
                }
                        
            else
                if (actual.Right != null)
                    return Busqueda(actual.Right, el);
                else {
                    return null;
                }
        }

        // private Object EliminarBusqueda(NodoArbol actual, Object el) {
        //     if ((int)actual.info == (int)el) {
        //         NodoArbol tmp = actual;
        //         return tmp;
        //     }

        //     if ((int)actual.info > (int)el)
        //         if (actual.Left != null)
        //             return Busqueda(actual.Left, el);
        //         else {
        //             return null;
        //         }
                        
        //     else
        //         if (actual.Right != null)
        //             return Busqueda(actual.Right, el);
        //         else {
        //             return null;
        //         }
        // }

        public void ListarPreproceso() {
            if(root == null)    System.Console.WriteLine("El árbol esta vacío");

            else {
                this.ListarPreproceso(root);

                Console.Clear();
                foreach (var numero in ListaNumeros)
                {
                    System.Console.WriteLine(numero);
                }
            }
        }

        private void ListarPreproceso(NodoArbol nodoActual) {
            ListaNumeros.Add((int)nodoActual.info);

            if(nodoActual.Left != null) {
                ListarPreproceso(nodoActual.Left);
            }

            if(nodoActual.Right != null) {
                ListarPreproceso(nodoActual.Right);
            }
        }

        public void ListarInproceso() {
            if(root == null)    System.Console.WriteLine("El árbol esta vacío");

            else {
                this.ListarInproceso(root);

                Console.Clear();
                foreach (var numero in ListaNumeros)
                {
                    System.Console.WriteLine(numero);
                }
            }
        }

        private void ListarInproceso(NodoArbol nodoActual) {
            if(nodoActual.Left != null) {
                ListarInproceso(nodoActual.Left);
            }

            ListaNumeros.Add((int)nodoActual.info);

            if(nodoActual.Right != null) {
                ListarInproceso(nodoActual.Right);
            }
        }

        public void ListarPostproceso() {
            if(root == null)    System.Console.WriteLine("El árbol esta vacío");

            else {
                this.ListarPostproceso(root);

                Console.Clear();
                foreach (var numero in ListaNumeros)
                {
                    System.Console.WriteLine(numero);
                }
            }
        }

        private void ListarPostproceso(NodoArbol nodoActual) {
            if(nodoActual.Left != null) {
                ListarPostproceso(nodoActual.Left);
            }

            if(nodoActual.Right != null) {
                ListarInproceso(nodoActual.Right);
            }

            ListaNumeros.Add((int)nodoActual.info);
        }

        public void BorrarElemento(Object el) {
            if(root == null) {
                System.Console.WriteLine("El árbol esta vacío");
                return;
            }

            NodoArbol nodoBuscado = Busqueda(root, el);

            if(nodoBuscado != null) {
                ListaNumeros.Clear();
                ListarPreproceso(root);
                root = null;

                if(ListaNumeros.Count > 1) {
                    for(int i=0; i<ListaNumeros.Count; i++) // Reasignar de nuevo todos los valores del nodo eliminado omitiendo el del nodo a eliminar
                    {
                        if(ListaNumeros[i] != (int)nodoBuscado.info)
                            Inserta(ListaNumeros[i]);
                    }
                }

                System.Console.WriteLine("Número eliminado");
            }

            else{
                System.Console.WriteLine("El número no existe dentro del árbol");
            }
        }

        // Para almacenar los datos del nodo a eliminar
        // Preproceso para que el primer dato sea del nodo con el valor a eliminar y asi omitirlo
        // private void AlmacenDatosPerdidos(NodoArbol nodoActual) {
        //     valoresRecuperados.Add((int)nodoActual.info);

        //     if(nodoActual.Left != null) {
        //         AlmacenDatosPerdidos(nodoActual.Left);
        //     }

        //     if(nodoActual.Right != null) {
        //         AlmacenDatosPerdidos(nodoActual.Right);
        //     }   
        // }

        public void printArbol() {
            valorMaximo = 1;
            int altura = 1;
            if(root != null)
                getAltura(root, altura);

            
        }

        private void getAltura(NodoArbol nodoActual, int altura) {
            if(altura > valorMaximo)
                valorMaximo = altura;

            if(nodoActual.Left != null) {
                altura++;
                getAltura(nodoActual.Left,altura);
            }

            altura--;

            if(nodoActual.Right != null) {
                altura++;
                getAltura(nodoActual.Right,altura);
            }
        }

        public void ImprimirEnConsola()
        {
            ImprimirEnOrden(root, 0);
        }

        private void ImprimirEnOrden(NodoArbol nodo, int depth)
        {
            if (nodo != null)
            {
                ImprimirEnOrden(nodo.Right, depth + 1);

                for (int i = 0; i < depth; i++)
                {
                    Console.Write("    "); // Espacios en blanco para representar la profundidad
                }

                Console.WriteLine($"|-- {nodo.info}");

                ImprimirEnOrden(nodo.Left, depth + 1);
            }
        }
    }