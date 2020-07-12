### Factory Design Pattern

	A factory is an object for creating objects.
	
	- Simple Factory
	- Factory Method
	- Abstract Factory
	
#### Factory Pattern Characteristics
	
- **Client**
    - Asks for a created product
- **Creator**
    - Facilitates a creation			
- **Product**
    - The product of the creation

**The client no longer needs to know how to create an object or exactly what flavor of that class it will use.**
		
	
##### Factory Method Pattern
		
* Separate the client from instantiation.
		
* Makes the application flexible, extansible and reusable.
		
* Sub-classes of the base factory can override the factory method to change how an object is created.
		
* We can inject different factories for creating different types of objects.
		
* The concrete factory is most of the time determined based on user input or configuration during runtime.
	

##### Abstract Factory Pattern
	
* The abstract factory pattern provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes.

* Apply factory pattern if you have a group of objects with a common theme.
		
* Extract creation of mocked, faked or commonly used instances in tests
		
* Factory Provider 
	
  * A factory of factories (based on user input)
					
		
**The factory patterns will make it easier to test the parts that use them as you can inject fakes or mocked implementations**
		

		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		