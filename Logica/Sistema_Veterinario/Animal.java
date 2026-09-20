public abstract class Animal
{
    protected String nombre;
    protected int edad;
    protected double peso;
    protected Propietario propietario;

    public Animal(String nombre,
                  int edad,
                  double peso,
                  Propietario propietario)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.peso = peso;
        this.propietario = propietario;
    }

    public String getNombre()
    {
        return nombre;
    }

    public int getEdad()
    {
        return edad;
    }

    public double getPeso()
    {
        return peso;
    }

    public Propietario getPropietario()
    {
        return propietario;
    }

    public abstract void aplicarTratamiento();
}