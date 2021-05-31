# Adapter
Allows objects with incompatible interfaces to collaborate.This is a special object that converts the interface of one object so that another object can understand it.

An adapter wraps one of the objects to hide the complexity of conversion happening behind the scenes. The wrapped object isn’t even aware of the adapter. For example, you can wrap an object that operates in meters and kilometers with an adapter that converts all of the data to imperial units such as feet and miles.

Adapters can not only convert data into various formats but can also help objects with different interfaces collaborate. Here’s how it works:

1. The adapter gets an interface, compatible with one of the existing objects.
2. Using this interface, the existing object can safely call the adapter’s methods.
3. Upon receiving a call, the adapter passes the request to the second object, but in a format and order that the second object expects.

Sometimes it’s even possible to create a two-way adapter that can convert the calls in both directions.

## Structure
### Object adapter
This implementation uses the object composition principle: the adapter implements the interface of one object and wraps the other one. It can be implemented in all popular programming languages.

### Class adapter
This implementation uses inheritance: the adapter inherits interfaces from both objects at the same time. Note that this approach can only be implemented in programming languages that support multiple inheritance, such as C++.

[[More info](https://refactoring.guru/design-patterns/adapter)]

## Code
- [Implementation](https://github.com/LadislavMargai/Design-Patterns/blob/main/DesignPatterns/Adapter/Adapter.cs)
- [Usage](https://github.com/LadislavMargai/Design-Patterns/blob/main/DesignPatterns.Tests/AdapterTests.cs)
