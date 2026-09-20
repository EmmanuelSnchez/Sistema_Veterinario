namespace Sistema_Veterinario.Logica
{
    public class Cita
    {
        public string Fecha { get; set; }

        public Cita(string fecha)
        {
            Fecha = fecha;
        }

        public void Mostrar()
        {
            Console.WriteLine(
                "Fecha: " + Fecha);
        }
    }
}