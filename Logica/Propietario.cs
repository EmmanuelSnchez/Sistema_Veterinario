namespace Sistema_Veterinario.Logica
{
    public class Propietario
    {
        public string Nombre { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }

        public Propietario(string nombre,
                          string telefono,
                          string correo)
        {
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Teléfono: " + Telefono);
            Console.WriteLine("Correo: " + Correo);
        }
    }
}