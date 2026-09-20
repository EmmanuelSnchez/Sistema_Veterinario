namespace Sistema_Veterinario.Logica
{
    public class Tratamiento
    {
        public string Descripcion { get; set; }

        public Tratamiento(string descripcion)
        {
            Descripcion = descripcion;
        }

        public void Mostrar()
        {
            Console.WriteLine(
                "Tratamiento: " +
                Descripcion);
        }
    }
}