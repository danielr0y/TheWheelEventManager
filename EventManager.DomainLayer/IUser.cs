namespace EventManager.DomainLayer;

public interface IUser
{
    int Id { get; }
    UserType Type { get; }
}