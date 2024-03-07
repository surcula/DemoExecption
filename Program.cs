using DemoExecption;

try
{
	int x = 42;
	x = int.Parse(Console.ReadLine());
	if (x % 2 == 0) throw new PairException();

    Console.WriteLine(x/0);
}
catch (FormatException ex)
{
    Console.WriteLine("Entrez un nombre s'il vous plait");
   
}
catch(DivideByZeroException) 
{ 
	Console.WriteLine("Erreur de division"); 
}

catch(PairException pe)
{
    Console.WriteLine(pe.Message);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
