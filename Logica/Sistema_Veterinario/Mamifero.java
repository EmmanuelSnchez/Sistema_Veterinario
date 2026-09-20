public class Mamifero extends Animal
{
    public Mamifero(String nombre,
                    int edad,
                    double peso,
                    Propietario propietario)
    {
        super(nombre, edad, peso, propietario);
    }

    @Override
    public void aplicarTratamiento()
    {
        System.out.println("Aplicando tratamiento para mamifero.");
    }
}