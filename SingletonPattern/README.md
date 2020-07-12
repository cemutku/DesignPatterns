### Singleton Pattern

* A singleton is a class designed to only ever have one instance.
* For example; Some kind of shared resource like access file system, access shared network resource, etc...
* We'll implement this pattern using `Lazy<T>`
	
#### Singleton Structure

	- Singleton _instance;
	- Static void Instance(): Singleton	

* It is just a single class with a private instance and a public static method that provides the only way to reference that instance.

#### Features

* At any time, only 0 or 1 instance of the Singleton class can exist in the application
* Singleton classes are created wihtout parameters
* Assume lazy instantiation as the default, they are not created until something request them (performance reasons!).
	
* Singleton classes should have a single private and parameterless constructor,
* Subclassing is not allowed to further enforce this intent and to help optimize the JIT compiler, singleton classes should be marked as sealed.
* The only reference to  the singleton should be private static field holds the only reference to the instance
* A public static methof provides access to this field

* In multi-threaded environment we have to prevent multiple constructor function calls
```
// This is not a thread safe code
// In multi-threaded environment, this if block can be reached by multiple threads concurrently, 
// resulting in multiple instantiations of Singleton
get 
{
	if (_instance == null)
	{
		_instance = new Singleton();
	}
}
```

##### Adding Thread Safety with Locks

- lock instances must be private and readonly not public shared!  (private static readonly object padlock = new Object())
- lock instances should be paired one for one with their locks statements
- check the instance is null and then put the lock
- `lock(padlock){... instance creation}`


```
// Threads enter this method one by one, prevents creating the instance at the same time. 
// This works, but it has negative performance impacts because every use of the instance property will now incur the overhead of this lock!

if (_instance == null)
{
	lock(padlock)
	{
		if (_instance == null)
		{
			_instance = new Singleton();
		}
	}
}
```

##### `Lazy<T>`

* Provides build-in supoort for lazy initialization
* Specify a Type
* Specify a means of creating the Type
* Can be used to implement Singleton


##### Singleton Behavior Using Containers

- .Net Core has built-in support for IOC/DI Containers
- Classes request dependencies via constructor
- Classes should follow Explicit Dependencies Principle
- Container manages abstraction-implementation mapping
- Container manages instance lifetime
- Manage lifetime using container, not class design

- Easily manage and modify individual class lifetimes using an IOC container, can also be used by any service, console app, etc..

```
services.AddTransient<>
services.AddScoped<>
services.AddSingleton<>  // add new instance during the application startup
```

- IOC/DI containers are usually a better place to manage instance lifetime in .NET applications