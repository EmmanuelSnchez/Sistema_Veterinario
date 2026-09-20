public class RegistroMedico
{
    private int codigo;
    private Animal animal;

    public RegistroMedico(int codigo,
                          Animal animal)
    {
        this.codigo = codigo;
        this.animal = animal;
    }

    public void mostrarRegistro()
    {
        System.out.println("Registro: " + codigo);
        System.out.println("Paciente: "
                           + animal.getNombre());
    }
}