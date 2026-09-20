public class Cita
{
    private String fecha;
    private String tipo;
    private Animal animal;

    public Cita(String fecha,
                String tipo,
                Animal animal)
    {
        this.fecha = fecha;
        this.tipo = tipo;
        this.animal = animal;
    }

    public void confirmar()
    {
        System.out.println("Cita confirmada");
        System.out.println("Paciente: "
                           + animal.getNombre());
        System.out.println("Tipo: " + tipo);
    }
}