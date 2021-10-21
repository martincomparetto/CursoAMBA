public class Vehiculo
{
    public string Color = "";
    public string Marca = "";
    public short CantidadRuedas = 0;
    public short Año = 0;

    private bool EnUso = false;

    public Vehiculo()
    {
        Marca = "Sin definir";
    }

    public Vehiculo(string color, string marca, short año, short cantidaRuedas)
    {
        Color = color;
        Marca = marca;
        Año = año;
        CantidadRuedas = cantidaRuedas;
    }

    public void Acelerar() { }

    public void Acelerar(bool rapido) { }

    public void Frenar() { }

    public void Arrancar()
    {
        EnUso = true;
    }

    public void Apagar()
    {
        EnUso = false;
    }

    public string ObtenerEstado()
    {
        string estado;
        if (EnUso)
        {
            estado = $"El vehiculo color {Color} esta en uso y prendido";
        }
        else
        {
            estado = $"El vehiculo color {Color} esta libre y apagado";
        }
        return estado;
    }
}

public class Motocicletas : Vehiculo
{}

public class Automoviles : Vehiculo
{
    public int CantidadPuertas = 0;
}

public class Camiones : Vehiculo
{
    public int Altura;
}

public class Tractores : Camiones
{
    public float Fuerza;
}

public class Semi : Camiones
{
    public float Largo;
}
