# Nullable Types

* Value Types can not be null

  ```c#
  bool hasAccess = true; // or false
  ```

If we are working with a database and we have a table called Customer which has a Column called Birthdate. Birthdate can be nullable because not everyone wants to put in their birthdate, In this case if we want to map that table to a C# class, that's one of the cases where you use a nullable type.

```sql
Customers.Birthday (datetime NULL)
```
For Example
```c#
DateTime date = null; //goes to an error because DateTime is a value type and as a result can not be set to null
```

We can solve that issue by using Nullable. Nullable is a generic structure that is defined in the System namespace

```C#
Nullable<DateTime> date = null;
```

We can define it using a shorter way, the shorthand of defining nullables is to type

```C#
DateTime? date = null;
```

#### Null Coalescing Operator

```C#
DateTime? date = null;
DateTime? date2 = date ?? DateTime.Today;
```

The normal way to do the above is

```C#
 DateTime? date = null;
 DateTime? date2;

if (date != null)
{
	date2 = date.GetValueOrDefault();
}
else
{
	date2 = DateTime.Today;
}
```

Other way is using **Tertiary Operator**

```C#
DateTime? date = null;
DateTime? date2 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;
```





