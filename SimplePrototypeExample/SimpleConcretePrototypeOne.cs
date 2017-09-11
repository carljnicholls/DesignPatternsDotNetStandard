namespace SimplePrototypeExample
{
    public class SimpleConcretePrototypeOne : SimplePrototype
    {
        public SimpleConcretePrototypeOne(string Id) : base(Id)
        {
            _Id = Id + "one";
        }

        public SimpleConcretePrototypeOne(string Id, string name) : base(Id)
        {
            //_Id = Id + "one";
            _Name = name + " one"; 
        }

        public override SimplePrototype Clone()
        {
            return new SimpleConcretePrototypeOne(_Id, _Name);
        }
    }
}
