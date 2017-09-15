using System;

namespace FactoryExample
{
    public abstract class Tree : ITree
    {
        private double Height;

        private Species Species;

        private DateTime DatePlanted;

        public Tree(double height, DateTime datePlanted)
        {
            Height = height;
            DatePlanted = datePlanted;
        }

        public double _Height
        {
            get { return Height; }
            set { Height = value; }
        }

        public DateTime _DatePlanted { get => DatePlanted; set => DatePlanted = value; }
        public Species _Species { get => Species; set => Species = value; }

        public int GetNumberOfRings()
        {
            return DateTime.Now.Year - DatePlanted.Year; 
        }
    }
}
