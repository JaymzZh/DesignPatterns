namespace Singleton
{
    /// <summary>
    /// 懒汉单例模式，需要双重锁这样的处理来保证线程安全
    /// </summary>
    public class Singleton
    {
        private static Singleton instance;

        private static readonly object suncRoot = new object();

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock (suncRoot)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }

            return instance;
        }
    }

    /// <summary>
    /// 饿汉单例模式，类在加载时就实例化对象，会提前占用系统资源
    /// </summary>
    public sealed class SingleTon
    {
        //readonly表示只能在静态初始化期间或在类构造函数中分配变量
        private static readonly SingleTon instance = new SingleTon();

        private SingleTon() { }

        public static SingleTon GetInstance()
        {
            return instance;
        }
    }
}
