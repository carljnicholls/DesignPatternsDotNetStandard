using System;
using System.Collections.Generic;

namespace CompositeExample
{
    /// <summary>
    /// Composite Object 
    /// </summary>
    public class CompositeCallPool : ICallPool
    {
        private readonly List<ICallPool> callPool;

        public CompositeCallPool()
        {
            callPool = new List<ICallPool>(); 
        }

        public void Add(ICallPool callPool)
        {
            this.callPool.Add(callPool);
        }

        public void AddRange(IEnumerable<CallPool> callPools)
        {
            this.callPool.AddRange(callPools); 
        }

        public void Delete(ICallPool callPool)
        {
            this.callPool.Remove(callPool); 
        }

        public IEnumerable<string> CallBack()
        {
            List<string> callPoolList = new List<string>(); 

            foreach (var item in callPool)
            {
                var strings = (List<string>) item.CallBack(); 
                callPoolList.Add(strings[0]);
            }

            return callPoolList; 
        }
    }
}
