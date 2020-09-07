using System;

namespace Generics
{
    // A value type can not be null, like integer
    // We can use thys class to give oir value types the ability to be Nullable
    public class Nullable<T> where T : struct
    {
        private object _value;
        public Nullable()
        {
            //default constructor in case the value is not set
        }
        public Nullable(object value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                return (T)_value;
            }
            return default;
        }

    }

}
