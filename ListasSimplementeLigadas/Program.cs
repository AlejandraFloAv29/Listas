using ListasSimplementeLigadas;

Lista MiLista = new Lista();
MiLista.Agregar(" CERO ");
MiLista.Agregar(" UNO ");
MiLista.Agregar(" DOS ");
MiLista.Agregar(" TRES ");
MiLista.Agregar(" CUATRO ");

string elementos = MiLista.Recorrer();
Console.WriteLine(elementos);

Console.WriteLine();
Nodo encontrado = MiLista.Buscar(" TRES ");
Console.WriteLine(encontrado.Valor);

Console.WriteLine();
Nodo encontrado2 = MiLista.BuscarNodoAnterior(" DOS ");
Console.WriteLine(encontrado2.Valor);

Console.WriteLine();
MiLista.Borrar(" DOS ");
elementos = MiLista.Recorrer();
Console.WriteLine(elementos);
