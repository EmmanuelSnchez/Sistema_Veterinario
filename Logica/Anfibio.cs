namespace Sistema_Veterinario.Logica
{
    public class Anfibio : Animal
    {
        public Anfibio(string nombre,
                      int edad,
                      Propietario dueño)
            : base(nombre, edad, dueño)
        {
        }

        public override void AplicarTratamiento()
        {
            Console.WriteLine(
                "Tratamiento para anfibios");
        }
    }
}