namespace SingletonExample
{
    public class Singleton
    {
        private static Singleton Instance = null;
        //private int Count { get; set; }
        private int Count;

        public int _Count
        {
            get { return Count; }
            set { Count = value; }
        }

        private Singleton()
        {
            Count = 0; 
        }

        public static Singleton GetInstance()
        {
            if (Instance == null)
                Instance = new Singleton();

            return Instance; 
        }
    }
}
