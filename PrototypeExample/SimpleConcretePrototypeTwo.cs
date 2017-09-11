namespace PrototypeExample
{
    public class SimpleConcretePrototypeTwo : SimplePrototype
    {
        public SimpleConcretePrototypeTwo(string Id) : base(Id)
        {
            _Id = Id + "two";
        }

        public SimpleConcretePrototypeTwo(string Id, string name) : base(Id)
        {
        }

        public override SimplePrototype Clone()
        {
            return new SimpleConcretePrototypeTwo(_Id, _Name);
        }
    }
}
