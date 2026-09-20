public class Membresia
{
    private String tipo;
    private double descuento;

    public Membresia(String tipo,
                     double descuento)
    {
        this.tipo = tipo;
        this.descuento = descuento;
    }

    public String getTipo()
    {
        return tipo;
    }

    public double getDescuento()
    {
        return descuento;
    }
}