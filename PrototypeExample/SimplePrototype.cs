namespace PrototypeExample
{
    public abstract class SimplePrototype
    {
        private string Id;
        private string Name;

        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public string _Id
        {
            get { return Id; }
            set { Id = value; }
        }

        public SimplePrototype(string Id, string name)
        {
            this.Id = Id;
            this.Name = name;
        }

        public SimplePrototype(string id)
        {
            Id = id;
            Name = string.Empty; 
        }

        public abstract SimplePrototype Clone(); 
    }
}
