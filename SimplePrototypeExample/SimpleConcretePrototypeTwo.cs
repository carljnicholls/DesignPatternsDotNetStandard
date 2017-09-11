namespace SimplePrototypeExample
{
    public class SimpleConcretePrototypeTwo : SimplePrototype
    {
        public SimpleConcretePrototypeTwo(string Id) : base(Id)
        {
            _Id = Id + "two";
        }

        public SimpleConcretePrototypeTwo(string Id, string Name) : base(Id)
        {
            _Id = Id + "two";
            _Name = Name + " two";
        }

        public override SimplePrototype Clone()
        {
            return new SimpleConcretePrototypeTwo(_Id, _Name);
        }
    }
}
