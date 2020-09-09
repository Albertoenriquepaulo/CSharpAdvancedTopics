# Extension Methods

Allow us to add a method to an existing class without

* Changing its source code or
* Creating a new class that inherits from it

To create an extension method we need 

* To create am static class, that's the convention we need to follow

* A good name for the class is to start with the name of the class and then add the postfix extension

* The first argument of this method should always be "this ClassWeAreExtending name", for example

  ```C#
  namespace ExtensionMethods
  {
      public static class StringExtensions
      {
          public static string Shorten(this String str, int numberOfWords) //this ClassWeAreExtending name
          {
              if (numberOfWords < 0)
              {
                  throw new ArgumentOutOfRangeException("numberOfWords should be grater or equal to 0.");
              }
              if (numberOfWords == 0)
              {
                  return string.Empty;
              }
              var words = str.Split(' ');
  
              if (words.Length <= numberOfWords)
              {
                  return str;
              }
              return string.Join(" ", words.Take(numberOfWords)) + "...";
          }
      }
  }
  ```




### Important

* The extension method is valid or exist when the class that create them is in the same scope. This have to be with the _namespace_, if the class where the extension method is in a different namespace, will not work, at least we add an using to that namespace. So a trick to avoid having too much using directive, we can make the extension class to belong to the system namespace, see below, compare the name space of the two codes

  ```c#
  namespace System //HERE
  {
      public static class StringExtensions
      {
          public static string Shorten(this String str, int numberOfWords)
          {
              if (numberOfWords < 0)
              {
                  throw new ArgumentOutOfRangeException("numberOfWords should be grater or equal to 0.");
              }
              if (numberOfWords == 0)
              {
                  return string.Empty;
              }
              var words = str.Split(' ');
  
              if (words.Length <= numberOfWords)
              {
                  return str;
              }
  
              return string.Join(" ", words.Take(numberOfWords)) + "...";
          }
      }
  
  }
  ```
* Microsoft suggest avoiding the use of extension methods, Use them when you really have to. If we have the source code of the original class, is better to go and change it there. Otherwise, create a new type that derives from that class and add your new method there. If those do not work we can create an extension method.