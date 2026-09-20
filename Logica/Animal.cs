namespace Sistema_Veterinario.Logica
{
    public abstract class Animal
    {
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public Propietario Dueño { get; set; }

        protected Animal(string nombre,
                        int edad,
                        Propietario dueño)
        {
            Nombre = nombre;
            Edad = edad;
            Dueño = dueño;
        }

        public abstract void AplicarTratamiento();
    }
}