// Inicio
int id = 0;
int cont;
int p = 1;
cont = 0;
while (cont <= 10)
{
    Console.WriteLine("Informe a idade: ");
    id = Convert.ToInt32(Console.ReadLine());
   
    if (id > 18)
    {
        p++;
    }
    cont++;
}id++;
Console.WriteLine("Foram inseridas " + p + " pessoas maiores de idade.");









Console.ReadKey();
//Fim