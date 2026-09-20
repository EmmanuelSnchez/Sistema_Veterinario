public class Venta
{
    private Producto producto;

    public Venta(Producto producto)
    {
        this.producto = producto;
    }

    public double calcularTotal()
    {
        return producto.getPrecio();
    }

    public void realizarVenta()
    {
        System.out.println("Producto: "
                           + producto.getNombre());

        System.out.println("Total: Q"
                           + calcularTotal());
    }
}