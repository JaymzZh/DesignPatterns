namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            IFactory factory = new SqlserverFactory();
            IUser iu = factory.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            Department dept = new Department();
            IDepartment id = factory.CreateDepartment();
            id.Insert(dept);
            id.GetDepartment(1);
        }
    }
}
