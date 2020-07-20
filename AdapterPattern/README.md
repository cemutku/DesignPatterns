### Adapter Pattern
	
* Structural design pattern.
* **Adapters** convert the interface of one class into an interface a client expects (they are also called "wrappers").
* **Problem** : Incompatible interfaces between a client and a service provider.
* An adapter converts an incompatible interface into a compatible one.
* In C#, the adapter pattern uses composition and is known as an object adapter.
	
#### Features & Notes
	
* Some principles suggest the use of an Adapter as the solution in certain cases.
		
  * **Polymorphism** : Avoid complext conditional logic by using polymorphism.
  * **Loose Coupling** : Prefer loose coupling to third party dependencies.
  * **Testability** : Introducing an Adapter can improve testability of the client.

* Small, focused interfaces are easiest to wrap with Adapters
* Once client depends on adapter abstraction, it no longer needs to be changed.


**Applicable SOLID Principles**
* Single Responsibility Principle
* Interface Segregation Principle
* Open/Closed Principle
	* We'd also like to be able to modify our client code's behavior, how it gets data from its service providers, without having to change its code.
      
		
##### Adapters
	
- **Object Adapters**
	* Hold an instance of the Adaptee class
	* Implement or Inherit the Adapter type
	* Use composition and single inheritance
			
- **Class Adapters**
	* Inherit from the Adaptee class
    * The adapter inherits interfaces from both objects at the same time
	* Instead of multiple inheritance we can implement the Adapter interface
														   
* We use object adapter in C#, C# does not support multiple inheritance (prefer composition over inheritance). For using class adapter, we can use interface and single inheritance

		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		