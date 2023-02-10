
Console.WriteLine("Metodo For :");

string[] sobrenome = { "P", "PU", "PUP", "PUPO" };
for (int i = 0; i < sobrenome.Length; ++i)
{
    Console.WriteLine(sobrenome[i]);
}
 // Mesmo resultado, utilizando menos comandos
Console.WriteLine("");
Console.WriteLine( "Metodo Foreach :");

string[] rodrigo = { "R", "RO", "ROD", "RODR", "RODRI", "RODRIG", "RODRIGO" };
foreach (string nome in rodrigo)
{
    Console.WriteLine(nome);
}