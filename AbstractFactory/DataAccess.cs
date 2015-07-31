using System.Reflection;
using System.Configuration;

namespace AbstractFactory
{
    public class DataAccess
    {
        private static readonly string assemblyName = "AbstractFactory";
        private static readonly string db = ConfigurationManager.AppSettings["DB"];

        public static IUser CreateUser()
        {
            string className = assemblyName + "." + db + "User";
            return (IUser)Assembly.Load(assemblyName).CreateInstance(className);
        }

        public static IDepartment CreateDepartment()
        {
            string className = assemblyName + "." + db + "Department";
            return (IDepartment)Assembly.Load(assemblyName).CreateInstance(className);
        }
    }
}
