namespace Sistema_Veterinario.Logica
{
    public class RegistroMedico
    {
        public int Codigo { get; set; }

        public RegistroMedico(int codigo)
        {
            Codigo = codigo;
        }

        public void Mostrar()
        {
            Console.WriteLine(
                "Código Registro: " + Codigo);
        }
    }
}