= Célia JOSSO - ANSWERS : Task 3 – Excellent

=== 1. Look for the same or similar solutions to generics in .NET in other technologies, briefly compare them, and create a random list from task 2 in the selected technology.

- *Java* _(source: https://www.baeldung.com/java-generics + https://hackernoon.com/how-generics-differ-in-java-and-c)_

Java also supports generics with a really similar syntax and type safety. The main difference is about how type information is handled during compilation and runtime. Furthermore, Java requires explicit casting in some cases.

Here is an example to create a random list with Java Generics.

```Java
public class RandomizedList<T> {
    private List<T> list;
    private Random random;
    
    public RandomizedList() {
        list = new ArrayList<>();
        random = new Random();
    }
    
    public void add(T element) {
        if (random.nextBoolean()) {
            list.add(0, element);
        } else {
            list.add(element);
        }
    }
}
```

- *C++ Templates* _(source: https://www.geeksforgeeks.org/templates-cpp/ + https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/differences-between-cpp-templates-and-csharp-generics)_

C++ uses templates to do so. They provide a way to define generic functions or classes. They are more powerful than .NET generics in terms of flexibility but they come with additionnal complexity.

Here is an example to create a random list with C++ Templates.

```cpp
#include <iostream>
#include <vector>
#include <random>

template <typename T>
class RandomizedList {
    std::vector<T> list;
    std::random_device rd;
    std::mt19937 gen;
public:
    RandomizedList() : gen(rd()) {}
    
    void add(T element) {
        if (gen() % 2 == 0) {
            list.insert(list.begin(), element); 
        } else {
            list.push_back(element);
        }
    }
};

```

=== 2. Do you know about any other query language similar to LINQ? Propose a solution with at least one of the queries from Task 1 in the language.

I know SQL as a query language similar to LINQ.

We can take the LINQ query for retrieving the highest `n` prices from the list of `GoldPrice` objects as an example to write a query in SQL.

```SQL
SELECT * 
FROM GoldPrices 
ORDER BY Price DESC
LIMIT n;
```