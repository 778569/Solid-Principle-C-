# Solid Concept

When Applied properly it makes your code more extendable, logical and easier to read. When the developer builds a software following the bed design, the code can become inflexible and more brittle, small changes in thje software can result in bugs. For these reasons, we should follow SOLID Principles.

**S** - Single Responsibility Principle (SRP)<br>
**O** - Open-Closed Principle (OCP)<br>
**L** - Liskov Substitution Principle (LSP)<br>
**I** - Interface Segregation Principle (ISP)<br>
**D** - Dependency Inversion Principle (DIP)<br>

## **S** - Single Responsibility Principle (SRP)
A Class should have only one reason to change. meaning that a class should have one job.

## **O** - Open-Closed Principle (OCP)
Software entities(class,modules,functions ect.) should open extension, but closed for modification.

## **L** - Liskov Substitution Principle (LSP)
Let q(x) be a property provable about abjects of x of type T. Then q(y) should be provable fro objects y of type S where S is a subtype of T.

All this is string is that every subclass/derived class should be substitutable for their base/parent class.

## **I** - Interface Segregation Principle (ISP)

A client should never be forced to implement an interface that it doesn't user or clients shouldn't be forced to depend on methods they do not use.

