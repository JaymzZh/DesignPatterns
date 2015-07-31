namespace AbstractFactory
{
    public interface IDepartment
    {
        void Insert(Department department);

        Department GetDepartment(int id);
    }
}
