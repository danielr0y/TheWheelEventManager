namespace EventManager.DomainLayer;

public interface ICustomerRepository
{
    Customer GetCustomer(int id);
}