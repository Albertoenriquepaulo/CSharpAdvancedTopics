# LINQ

* Stand for: **L**anguaje **In**tegrated **Q**uery
* Give the capability to query objects

### You can query

* Objects in memory, eg collections (LINQ to Objects)
* Databases (LINQ to Entities)
* XML (LINQ to XML)
* ADO.NET Data Sets (LINQ to Data Sets)

#### There are two type of LINQ:

1. LINQ Extensions Methods, in term of power and flexibility this syntax is more powerful, because internally all the keywords of LINQ Query Operators are translated to this

```c#
var stringListOfcheapBooksOrderedByTitle = books
                                            .Where(b => b.Price < 10)
                                            .OrderBy(b => b.Title)
                                            .Select(b => b.Title);
```



2. LINQ Query Operators, this always start with "from" and always finish with the "select". In other scenarios when you are doing it GroupBy or Grouping lists this syntax is more friendly and cleaner

```c#
var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;
```


