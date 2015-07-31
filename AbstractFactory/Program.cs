namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            IUser iu = DataAccess.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            Department dept = new Department();
            IDepartment id = DataAccess.CreateDepartment();
            id.Insert(dept);
            id.GetDepartment(1);
        }
    }
}
