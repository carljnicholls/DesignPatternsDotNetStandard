using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeExample
{
    /// <summary>
    /// Component Object 
    /// </summary>
    public class CallPool : ICallPool
    {
        private int Id;

        public CallPool()
        {
            Random rdm = new Random();
            _Id = rdm.Next() * rdm.Next();
            rdm.Next(); 
        }

        protected int _Id
        {
            get { return Id; }
            set { Id = value; }
        }

        public IEnumerable<string> CallBack()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Callback").Append(_Id.ToString());
            return new List<string>() { sb.ToString() }; 
        }
    }
}
