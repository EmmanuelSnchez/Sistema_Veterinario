namespace Sistema_Veterinario.Logica
{
    public class Mamifero : Animal
    {
        public Mamifero(string nombre,
                       int edad,
                       Propietario dueño)
            : base(nombre,
                  edad,
                  dueño)
        {
        }

        public override void AplicarTratamiento()
        {
            Console.WriteLine(
                "Tratamiento para mamíferos");
        }
    }
}