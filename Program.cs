Console.Clear();
    
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("......SEQUENCIA PARES......\n");


    
    Console.WriteLine("......Números pares entre 0 e ?...:");
    int NumeroInformado = Convert .ToInt32(Console.ReadLine());

    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.DarkGreen;
    if (NumeroInformado > 1 )
{
    int  numeroPar = 0;


while (numeroPar <= NumeroInformado )
{
    Console.Write($"{ numeroPar} ");
    numeroPar += 2;


}

    Console.ResetColor();


    
}
    

    else {
    

    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write( $"......... O número { NumeroInformado } não é inteiro positivo....... " );

};

Console.ResetColor();
