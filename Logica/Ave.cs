namespace Sistema_Veterinario.Logica
{
    public class Ave : Animal
    {
        public Ave(string nombre,
                  int edad,
                  Propietario dueño)
            : base(nombre, edad, dueño)
        {
        }

        public override void AplicarTratamiento()
        {
            Console.WriteLine(
                "Tratamiento para aves");
        }
    }
}