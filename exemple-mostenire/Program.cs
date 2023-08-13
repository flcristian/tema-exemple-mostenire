using exemple_mostenire.product;
using exemple_mostenire.product.service;
using exemple_mostenire.vehicle.service;

internal class Program
{
    private static void Main(string[] args)
    {
        ProductService service1 = new ProductService();
        service1.Afisare();

        /*VehicleService service2 = new VehicleService();
        service2.Afisare();*/
    }
}