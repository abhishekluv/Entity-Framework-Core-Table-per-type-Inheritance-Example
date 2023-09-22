# Entity Framework Core Table Per Type Inheritance (TPT).

Table-per-type (TPT) is a mapping strategy used in the object-relational mapping (ORM) to represent inheritance in a relational database. 

![](https://i.imgur.com/8tpwWQn.jpeg)

![](https://i.imgur.com/OpVWe9f.jpeg)

![](https://i.imgur.com/xmWDmUY.jpeg)

In TPT, each subtype of an inheritance hierarchy is represented as its table in the database, and the base type is represented as a separate table.

![](https://i.imgur.com/rypZC0h.jpeg)

A separate table is used to represent each type in the inheritance chain, including abstract types. 

Tables that represent derived types like Cars and Motorcycles are related to their base type via foreign keys.

![](https://i.imgur.com/6bTepx6.jpeg)

![](https://i.imgur.com/24BpANX.jpeg)

![](https://i.imgur.com/7sdBQ2W.jpeg)