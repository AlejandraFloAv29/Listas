namespace ListasDoblementeLigadas
{
    public class Nodo
    {
        public string Valor { get; set;}
        public Nodo EnlaceAnterior { get; set; }
        public Nodo EnlaceSiguiente { get; set; }

        public Nodo (string valor = "", Nodo enlaceA = null, Nodo enlaceS = null)
        {
            Valor = valor;
            EnlaceAnterior = enlaceA;
            EnlaceSiguiente = enlaceS;
        }

            
    }
}
