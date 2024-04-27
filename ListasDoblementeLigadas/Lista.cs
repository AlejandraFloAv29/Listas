namespace ListasDoblementeLigadas
{
    internal class Lista
    {
        private Nodo _nodoInicial;

        public Lista()
        {
            _nodoInicial = new Nodo();
        }

        public bool EstaVacio()
        {
            if (_nodoInicial.EnlaceSiguiente == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Vaciar()
        {
            _nodoInicial.EnlaceSiguiente = null;
            Console.WriteLine(" LISTA VACIA ");
        }

        public string Recorrer()
        {
            string elementos = string.Empty;
            Nodo nodoActual = _nodoInicial;
            while (nodoActual.EnlaceSiguiente != null)
            {
                nodoActual = nodoActual.EnlaceSiguiente;
                elementos += $"{nodoActual.Valor}\n";
            }
            return elementos;
        }

        public void Agregar(string valor)
        {
            Nodo nodoActual = _nodoInicial;
            while (nodoActual.EnlaceSiguiente != null)
            {
                nodoActual = nodoActual.EnlaceSiguiente;
            }

            Nodo nodoNuevo = new Nodo(valor);
            nodoActual.EnlaceSiguiente = nodoNuevo;
            nodoNuevo.EnlaceAnterior = nodoActual;
        }

        public Nodo Buscar(string valor)
        {
            if (EstaVacio() == false)
            {
                Nodo nodoActual = _nodoInicial;
                while (nodoActual.EnlaceSiguiente != null)
                {
                    nodoActual = nodoActual.EnlaceSiguiente;
                    if (nodoActual.Valor == valor)
                    {
                        return nodoActual;
                    }
                }
            }
            return null;
        }

        public void Borrar(string valor)
        {
            if (EstaVacio() == false)
            {
                Nodo nodoActual = Buscar(valor);
                if (nodoActual != null)
                {
                    Nodo nodoAnterior = nodoActual.EnlaceAnterior;
                    nodoAnterior.EnlaceSiguiente = nodoActual.EnlaceSiguiente;

                    Nodo nodoSiguiente = nodoActual.EnlaceSiguiente;
                    nodoSiguiente.EnlaceAnterior = nodoActual.EnlaceAnterior;

                    nodoActual.EnlaceSiguiente = null;
                    nodoActual.EnlaceAnterior = null;

                }
            }
        }

    }
}
