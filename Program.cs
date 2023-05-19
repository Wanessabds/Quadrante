double x, y;
string local;

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("QUADRANTE CARTESIANA");

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Entre com o ponto desejado");

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Coordenada X:");
x = Convert.ToDouble(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("Coordenada y:");
y = Convert.ToDouble(Console.ReadLine());

if (x == 0 && y == 0) local = "A Origem";
else if (x == 0) local = "O eixo das ordenadas";
else if (y == 0) local = "O eixo das abscissas";
else if (y > 0)
{
    if (x > 0)
           local = "O quadrante 1";
    else
           local = "O quadrante 2";
}
else
{
    if (x < 0)
          local = "O quadrante 3";
    else
    
        local = "O quadrante 4";
    }      

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"O ponto ({x}, {y} fica no {local}).");

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("Clique para inserir outros pontos");
