namespace Sistema_Veterinario.Logica
{
    public class Reptil : Animal
    {
        public Reptil(string nombre,
                     int edad,
                     Propietario dueño)
            : base(nombre, edad, dueño)
        {
        }

        public override void AplicarTratamiento()
        {
            Console.WriteLine(
                "Tratamiento para reptiles");
        }
    }
}