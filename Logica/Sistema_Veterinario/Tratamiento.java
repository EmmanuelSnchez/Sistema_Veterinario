public class Tratamiento
{
    private String descripcion;
    private Animal animal;

    public Tratamiento(String descripcion,
                       Animal animal)
    {
        this.descripcion = descripcion;
        this.animal = animal;
    }

    public void aplicar()
    {
        System.out.println("Tratamiento: "
                           + descripcion);

        animal.aplicarTratamiento();
    }
}