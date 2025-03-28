# Solución al Bonus Challenge: Validación de `TipoLicencia` en la clase `Chofer`

## Solución inicial de Grok

Para validar `TipoLicencia` cada vez que se modifica, usa un setter personalizado en la propiedad. Agrega un campo privado `_tipoLicencia` y valida contra `Edad` en el setter, lanzando excepciones si las reglas fallan (por ejemplo, "M" para menores de 18, "C" solo para mayores de 25). Esto asegura consistencia sin métodos adicionales.

```csharp
internal class Chofer : IPiloto
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    private string _tipoLicencia;
    public string TipoLicencia
    {
        get => _tipoLicencia;
        set
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentException("Licencia no puede estar vacía.");
            if (Edad < 18 && value != "M") throw new ArgumentException("Menores de 18 solo licencia 'M'.");
            if (Edad >= 18 && Edad < 25 && value == "C") throw new ArgumentException("Licencia 'C' requiere 25 años.");
            _tipoLicencia = value;
        }
    }

    public Chofer(string nombre, int edad, string tipoLicencia)
    {
        Nombre = nombre;
        Edad = edad;
        TipoLicencia = tipoLicencia;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("El piloto es: " + Nombre);
        Console.WriteLine("Tipo de licencia {0}", TipoLicencia);
    }
}
```


## Promt utilizado
En una clase Chofer en C#, el constructor asigna un TipoLicencia basado en Edad, pero no hay forma de validar cambios posteriores a TipoLicencia. dame un método en C# para validar TipoLicencia manualmente después de cada cambio, incluyendo reglas como solo 'M' para menores de 18, y explica si es la mejor práctica o si hay una alternativa superior.

## Solución de Claude

```csharp
using System;

public interface IPiloto
{
    string Nombre { get; set; }
    int Edad { get; set; }
    string TipoLicencia { get; set; }
    void MostrarInformacion();
}

public class Chofer : IPiloto
{
    private string _tipoLicencia;

    public string Nombre { get; set; }
    public int Edad { get; set; }

    public string TipoLicencia
    {
        get => _tipoLicencia;
        set
        {
            ValidarTipoLicencia(value);
            _tipoLicencia = value;
        }
    }

    public Chofer(string nombre, int edad, string tipoLicencia)
    {
        Nombre = nombre;
        Edad = edad;
        ValidarTipoLicencia(tipoLicencia);
        _tipoLicencia = tipoLicencia;
    }

    private void ValidarTipoLicencia(string tipoLicencia)
    {
        // Validación de tipos de licencia según edad
        switch (tipoLicencia.ToUpper())
        {
            case "A":
                if (Edad < 18)
                    throw new ArgumentException("Licencia A requiere ser mayor de 18 años");
                break;
            case "B":
                if (Edad < 21)
                    throw new ArgumentException("Licencia B requiere ser mayor de 21 años");
                break;
            case "C":
                if (Edad < 25)
                    throw new ArgumentException("Licencia C requiere ser mayor de 25 años");
                break;
            default:
                throw new ArgumentException("Tipo de licencia inválido. Debe ser A, B o C.");
        }
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"El piloto es: {Nombre}");
        Console.WriteLine($"Tipo de licencia: {TipoLicencia}");
        Console.WriteLine($"Edad: {Edad}");
    }
}

// Ejemplo de uso
public class Program
{
    public static void Main()
    {
        try
        {
            // Ejemplo de creación correcta
            Chofer chofer1 = new Chofer("Juan Pérez", 25, "B");
            chofer1.MostrarInformacion();

            // Ejemplo de cambio de licencia
            chofer1.TipoLicencia = "C";
            chofer1.MostrarInformacion();

            // Ejemplo que lanzaría una excepción
            // Chofer chofer2 = new Chofer("Pedro", 17, "A"); // Lanzaría excepción
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
```
## Promt utilizado
"En la clase Chofer en C#, que implementa IPiloto y tiene propiedades Nombre (string), Edad (int) y TipoLicencia (string), el constructor valida TipoLicencia según Edad (por ejemplo, 'M' para menores de 18, 'C' solo para mayores de 25). Sin embargo, cambiar TipoLicencia después del constructor no valida el nuevo valor. Diseña una solución en C# para validar TipoLicencia cada vez que se modifica, usando las reglas mencionadas. Explica la mejor práctica y proporciona el código corregido de la clase Chofer."
