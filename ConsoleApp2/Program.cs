//Ejercicio1


Console.WriteLine("Ejercicio 1, Ingresa los datos solicitados!");
Console.WriteLine("Nombre");
string? name = Console.ReadLine();
Console.WriteLine("Apellido");
string? lastname = Console.ReadLine();
Console.WriteLine("edad");
int age= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sabes progamar si o no ?");
string? programer = Console.ReadLine();
Console.WriteLine("Nombre: "+name+" "+lastname+" edad: "+age+" progamdor: "+programer);

//Ejercicio 2
Console.WriteLine("Ejercicio 2, complete los datos del auto");
Console.WriteLine ("Modelo de auto");
string? carModel = Console.ReadLine();
Console.WriteLine("Cantidad de puertas");
int doors = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ruedas cantidad");
int wheels = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Marca");
string? brand = Console.ReadLine();
Console.WriteLine("Itv True or False");
bool itv = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Cuantos kg Pesa");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine("Cuantos metros de largo?");
float largo = float.Parse(Console.ReadLine());
Console.WriteLine("Que material esta hecho?");
string? material = Console.ReadLine();
Console.WriteLine("Que color es ?");
string? color = Console.ReadLine();

Console.WriteLine("Por fin hemos terminado tienes un " + brand + " " + carModel + " " + color + " de " + doors + " puertas " + wheels + " ruedas pesa " + peso + " Kg " + largo + " metros de largo de " + material);

//Ejercicio 3
Console.WriteLine("Ejercicio 3 operadores");
Console.WriteLine("Ingresa un numero a validar que es mayor o igual que 18");

int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num >= 18);
Console.WriteLine("ingrese un char a validar que es a");

char c = Convert.ToChar(Console.ReadLine());
Console.WriteLine(c == 'a');

Console.WriteLine("Validaciones de AND y OR  de las anteriores condiciones");

Console.WriteLine(num >= 18 && c == 'a');
Console.WriteLine(num >= 18 || c == 'a');
