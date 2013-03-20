using System;

namespace Productify.Domain.Repositories
{
    public class InstanceAddedEventArgs<T> : EventArgs
    {
        public InstanceAddedEventArgs(T newInstance)
        {
            this.NewInstance = newInstance;
        }

        public T NewInstance { get; private set; }
    }
}