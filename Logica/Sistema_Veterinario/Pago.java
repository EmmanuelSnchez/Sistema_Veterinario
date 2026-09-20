public class Pago
{
    private double monto;

    public Pago(double monto)
    {
        this.monto = monto;
    }

    public void efectivo()
    {
        System.out.println("Pago en efectivo Q"
                           + monto);
    }

    public void tarjeta()
    {
        System.out.println("Pago con tarjeta Q"
                           + monto);
    }

    public void transferencia()
    {
        System.out.println("Pago por transferencia Q"
                           + monto);
    }
}