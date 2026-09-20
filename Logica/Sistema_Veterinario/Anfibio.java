public class Anfibio extends Animal
{
    public Anfibio(String nombre,
                   int edad,
                   double peso,
                   Propietario propietario)
    {
        super(nombre, edad, peso, propietario);
    }

    @Override
    public void aplicarTratamiento()
    {
        System.out.println("Aplicando tratamiento para anfibio.");
    }
}