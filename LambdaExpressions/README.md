# Lambda Expressions

An anonymous method

* No access modifier
* No name
* No return statement

### Existing delegate

Instead of creating a custom delegate we could use one of the existing Delegates that come in .NET framework. In .Net we have two delegates that are generic and they are **Action and Func**.

**Action** has 16 overloads, so this Action can point to a method that takes any parameters between 1 and 16

**Func** has 16 overloads as well, but returns a value.

**The difference between Action and Func** is Func points to a method that returns a value, rather Action point to a method that returns void

### Conclusions

* *Delegate* is an object that knows how to call a method or a group of methods.

* We use delegate to achieve flexibility and extensibility.

* If we are designing an application where flexibility or extensibility is a concern we can use delegates for that.

* Alternatively, we can use interfaces.

* MSDN suggests to use Delegates when we have some kind of eventing design pattern or the caller does not need to access other properties, methods, or interfaces on the object implementing the method. 

  Imagine if our Photo Processor needed to access other properties or methods, obviously a delegate wouldn't work and we have to use an interface.

