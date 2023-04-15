namespace EventManager.DomainLayer;

public class CustomerService : IWebAppCustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
    }

    public Customer GetCustomer(int id) => _customerRepository.GetCustomer(id);
}