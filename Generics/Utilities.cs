using System;

namespace Generics
{
    //IComparable is a constraint (restricción)
    //Here th five types of constraint
    // Where T : IComparable -> (Interface)
    // Where T : Product (or any of its children, any of product subclasses)
    // Where T : struct (Value type)
    // Where T : class (Reference type)
    // Where T : new() (An object that has a default construction)
    public class Utilities<T> where T : IComparable, new() //con este new podemos crear un objeto del tipo T como en DoSomething
    {
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }
    public class Utilities1
    {
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

}
