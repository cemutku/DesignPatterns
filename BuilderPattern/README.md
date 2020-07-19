### Builder Pattern

* Creational design pattern	
* Separate the construction of a complex object from its representation so that the same construction process can create different representations.
	
	
#### Characteristics

* **Product** 			: It is the complex object we're trying to construct 
		
* **Builder** 			: It is the interface that defines how the pieces of the complex object are created
		
* **ConcreteBuilder** 	: ConcreteBuilder instances construct the complex object according to the builder interface blueprint. Each concrete builder is in charge of keeping track of the representation of the complex object it creates, and retrieving that object when queried.
		
* **Director Class** 	: Director class handles the actual call to construct the complex object using the concrete builder. Its job is execute the object's build steps in a predetermined sequence or we can call those build steps directly from any concrete builder class.	
		

#### Features & Notes
* **Abstracts out initialization code**
	- Builder Pattern removes any and all construction or initialization code from an object class and abstracts it out to an interface.
* **Representations created as concrete classes**
	- Constructed from interface blueprint.
* **Director class handles actual object creation**
	- Concrete classes don't deal with instantiating themselves.
	- Controls where & what data is used.

* Builder is useful when creating complex objects
* When object creation needs to be separate from its assembly
* When different representations need to be created with finer control

	