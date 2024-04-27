using ListasDoblementeLigadas;

Lista MiLista = new Lista();
MiLista.Agregar(" CERO ");
MiLista.Agregar(" UNO ");
MiLista.Agregar(" DOS ");
MiLista.Agregar(" TRES ");
MiLista.Agregar(" CUATRO ");

string elementos = MiLista.Recorrer();
Console.WriteLine(elementos);

Console.WriteLine();
Nodo encontrado = MiLista.Buscar(" DOS ");
Console.WriteLine(encontrado.Valor);

Console.WriteLine();
MiLista.Borrar(" TRES ");
elementos = MiLista.Recorrer();
Console.WriteLine(elementos);

Console.WriteLine();
MiLista.Borrar(" UNO ");
elementos = MiLista.Recorrer();
Console.WriteLine(elementos);

Console.WriteLine();
MiLista.Vaciar();
elementos = MiLista.Recorrer();
Console.WriteLine(elementos);
