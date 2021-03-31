# Csharp.Strings

string es un alias de String
```csharp
string y = "bill";
String x = "hola";
```

String interpolation: para saltar de una variable a una cadena estatica sin necesidad de castear y usar + 
```csharp 
$”hola: {variable}”
```

Para cortar a la izq, derecha y a ambos lados, mayormente se usa para espacios
```csharp
TrimStart() 
TrimEnd()
Trim()
```

Para dividir un string por espacios, comas o puntos y comas. En realidad se puede separar desde cualquier caracter
```csharp
string [] result = string.Split(“,”);
```

Para no copiar y/o apuntar a la variable original se usa: 
```csharp
string[] strArray3 = (string[])strArray.Clone();
```

scape characters: @ => evita muestra caracteres especiales (enter) como tal menos las comillas dobles
```csharp
Console.WriteLine(@"hola como 
estas \si");
```

Armar un string de un array de caracteres
```csharp
char[] letters = { 'a', 'b', 'c' };string alphabet = new string(letters);
```

Iterar un string como si fuera un array
```csharp
var esternocleidomastoideo = "esternocleidomastoideo";
foreach (var est in esternocleidomastoideo)
{
    Console.WriteLine(est);
}
```

Saber si una cadena esta vacia o es nula:
```csharp
string.IsNullOrEmpty({var})
```

manejo de strings es mejor manejar stringBuilder
```csharp
var sb = new StringBuilder(var123);
var var123withSB = sb.Append("hola como estas");
```
