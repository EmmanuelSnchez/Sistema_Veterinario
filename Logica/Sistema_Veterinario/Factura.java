public class Factura
{
    private double subtotal;
    private double descuento;

    public Factura(double subtotal,
                   double descuento)
    {
        this.subtotal = subtotal;
        this.descuento = descuento;
    }

    public void generarFactura()
    {
        double total =
            subtotal - descuento;

        System.out.println("FACTURA");
        System.out.println("Subtotal: Q"
                           + subtotal);

        System.out.println("Descuento: Q"
                           + descuento);

        System.out.println("Total: Q"
                           + total);
    }
}