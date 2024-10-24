# DesignPatterns
Exercise and describe design patterns
In this repository, I want to teach and practice the concepts of patterns in the form of examples.

# Creational Pattern
Creational Design Patterns focus on the process of object creation or problems related to object creation. They help in making a system independent of how its objects are created, composed, and represented. Creational patterns give a lot of flexibility in what gets created, who creates it, and how it gets created.
## Key Benefits:
* Decoupling: It decouples the code that uses the objects from the code that creates the objects.
* Flexibility: It makes it easier to introduce new types of objects without changing the code that uses them.
## Factory Method
The Factory Design Pattern defines an interface for creating objects but allows subclasses to alter the type of objects that will be created. This pattern delegates the responsibility of instantiating objects to a factory class, which makes the code more flexible and easier to manage.
## Abstract Factory
According to the Gang of Four Definition, The Abstract Factory Design Pattern provides a way to encapsulate a group of factories with a common theme without specifying their concrete classes.
Abstract means hiding some information, factory means which produces the products, and pattern means a design. So, the Abstract Factory Pattern is a software design pattern that provides a way to encapsulate a group of individual factories that have a common theme.

The Abstract Factory is a super factory that creates other factories. It is also called the Factory of Factories. The Abstract Factory design pattern provides an interface for creating families of related or dependent products but leaves the actual object creation to the concrete factory classes.
The Abstract Factory Design Pattern consists of the following components:

* AbstractFactory: Declares an interface for operations that create abstract products. This will be an interface for operations that will create Abstract Product objects.
* ConcreteFactory: Implements the operations to create concrete product objects. These classes implement the Abstract Factory interface and provide implementations for the interface methods. We can use these concrete classes to create concrete product objects.
* AbstractProduct: Declares an interface for a type of product object. These are going to be interfaces for creating abstract products. Here, we need to define the Operations a Product should have.
* ConcreteProduct: Implements the AbstractProduct interface. These are the classes that implement the Abstract Product interface.
* Client: Uses interfaces declared by AbstractFactory and AbstractProduct classes. This class will use our Abstract Factory and Abstract Product interfaces to create a family of products.
