namespace AbstractFactory
{
    public interface IFactory
    {
        IUser CreateUser();

        IDepartment CreateDepartment();
    }
}
