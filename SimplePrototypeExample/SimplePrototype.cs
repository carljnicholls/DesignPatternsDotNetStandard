namespace SimplePrototypeExample
{
    public abstract class SimplePrototype
    {
        private string Id;
        private string Name;

        public string _Id
        {
            get { return Id; }
            set { Id = value; }
        }

        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public SimplePrototype(string id)
        {
            Id = id;
            Name = string.Empty;
        }

        public SimplePrototype(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract SimplePrototype Clone();
    }
}
