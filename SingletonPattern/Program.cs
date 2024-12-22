namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }



    // 懒汉模式 （线程不安全）
    public sealed class Singleton1
    {
        private static Singleton1 instance;

        private Singleton1() { }

        public static Singleton1 getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton1();
            }
            return instance;
        }
        // 参数 ...
    }


    // 双重锁（线程安全）
    public sealed class Singleton2
    {
        private static Singleton2 instance;
        // 使用了readonly的属性，只能在定义时，或者构造函数中初始化，其他的地方都不能再修改其值
        private static readonly object locker = new object();
        private Singleton2() { }

        public static Singleton2 getInstance()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Singleton2();
                    }
                }
            }
            return instance;
        }

        // 参数 ...
    }

    // 饿汉模式
    public sealed class Singleton3
    {
        private static readonly Singleton3 instance = new Singleton3();
        private Singleton3()
        {

        }
        public static Singleton3 getInstance()
        {
            return instance;
        }

        // 参数 ...
    }

    // 使用 Lazy<T>（线程安全）
    public sealed class Singleton4
    {
        private static Lazy<Singleton4> lazy = new Lazy<Singleton4>(() => new Singleton4());
        public static Singleton4 instance = lazy.Value;

        private Singleton4()
        {

        }

        // 参数
    }
}
