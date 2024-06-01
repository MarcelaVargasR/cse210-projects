using System;

class Program
{
    static void Main(string[] args)
    {
        // First customer
        Customer customer = new Customer();
        Address address = new Address();
        address.SetAddress("720 Main St 2nd", "Columbos", "OH", "USA");
        customer.SetCustomer("Thomas Brown", address);


        // Second customer
        Customer customer2 = new Customer();
        Address address2 = new Address();
        address2.SetAddress("325 Main St 2nd", "Denver", "CL", "USA");
        customer2.SetCustomer("Dylan Miller", address2);

        // Create Products
        List<Product> products = new List<Product>();
        Product product1 = new Product();
        product1.setProduct("Mouse", "P001", 18.23, 1);
        products.Add(product1);

        Product product2 = new Product();
        product2.setProduct("Air Fryer", "P002", 240.50, 1);
        products.Add(product2);


        Product product3 = new Product();
        product3.setProduct("Bamboo Pillow", "P003", 69.34, 1);
        products.Add(product3);

        // Create Order
        Order order = new Order(products, customer);

        // Display Results
        order.DisplayResults();
    }
}
