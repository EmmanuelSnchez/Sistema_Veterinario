using Sistema_Veterinario.Logica;

namespace Sistema_Veterinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "===== SISTEMA VETERINARIO =====");

            Console.Write("Nombre del dueño: ");
            string nombreDueño =
                Console.ReadLine() ??"";

            Console.Write("Teléfono: ");
            string telefono =
                Console.ReadLine() ??"";

            Console.Write("Correo: ");
            string correo =
                Console.ReadLine() ??"";

            Propietario dueño =
                new Propietario(
                    nombreDueño,
                    telefono,
                    correo);

            Console.WriteLine();

            Console.Write("Nombre mascota: ");
            string nombreMascota =
                Console.ReadLine() ??"";

            Console.Write("Edad mascota: ");
            int edad =
                Convert.ToInt32(
                    Console.ReadLine() ?? "0");

            Animal mascota;

            Console.WriteLine();
            Console.WriteLine("Tipo de animal");
            Console.WriteLine("1. Mamífero");
            Console.WriteLine("2. Ave");
            Console.WriteLine("3. Reptil");
            Console.WriteLine("4. Anfibio");

            int tipo =
                Convert.ToInt32(
                    Console.ReadLine() ?? "0");

            switch (tipo)
            {
                case 1:
                    mascota =
                        new Mamifero(
                            nombreMascota,
                            edad,
                            dueño);
                    break;

                case 2:
                    mascota =
                        new Ave(
                            nombreMascota,
                            edad,
                            dueño);
                    break;

                case 3:
                    mascota =
                        new Reptil(
                            nombreMascota,
                            edad,
                            dueño);
                    break;

                default:
                    mascota =
                        new Anfibio(
                            nombreMascota,
                            edad,
                            dueño);
                    break;
            }

            Console.Write("Código registro médico: ");

            RegistroMedico registro =
                new RegistroMedico(
                    Convert.ToInt32(
                        Console.ReadLine() ?? "0"));

            Console.Write("Fecha cita: ");

            Cita cita =
                new Cita(
                    Console.ReadLine() ?? "");

            Console.Write("Descripción tratamiento: ");

            Tratamiento tratamiento =
                new Tratamiento(
                    Console.ReadLine() ?? "");

            Console.Clear();

            Console.WriteLine(
                "===== DATOS DEL PROPIETARIO =====");

            dueño.MostrarInformacion();

            Console.WriteLine();

            Console.WriteLine(
                "===== DATOS DE LA MASCOTA =====");

            Console.WriteLine(
                "Nombre: " +
                mascota.Nombre);

            Console.WriteLine(
                "Edad: " +
                mascota.Edad);

            Console.WriteLine();

            registro.Mostrar();

            Console.WriteLine();

            cita.Mostrar();

            Console.WriteLine();

            tratamiento.Mostrar();

            Console.WriteLine();

            mascota.AplicarTratamiento();

            Console.ReadKey();
        }
    }
}