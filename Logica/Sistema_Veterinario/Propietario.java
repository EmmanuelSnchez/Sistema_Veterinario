import java.util.ArrayList;

public class Propietario
{
    private String nombre;
    private String telefono;
    private ArrayList<Animal> mascotas;

    public Propietario(String nombre,
                       String telefono)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        mascotas = new ArrayList<>();
    }

    public void agregarMascota(Animal animal)
    {
        mascotas.add(animal);
    }

    public String getNombre()
    {
        return nombre;
    }

    public void mostrarMascotas()
    {
        System.out.println("Mascotas de " + nombre);

        for(Animal a : mascotas)
        {
            System.out.println(a.getNombre());
        }
    }
}