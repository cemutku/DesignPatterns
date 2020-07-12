### Chain of Responsibility Pattern

* This project contains two examples of Chain of Responsibility Pattern implementation
    1. Validation Handler
	2. Payment Handler	
	
#### Characteristics

- Sender
	- Invokes the Handler
	- Calls Logger.Log()
- Handler
	- Runs through the chain of receivers
	- Logger has a chain of ILoggers
	- The Handler will make sure that each receiver gets the request passed into it, the receiver then decides if it should act on that given request or not. if not request will still be passed along the chain to the next receiver in line.
- Receiver
	- Handles the given command
	- Console Logger, File Logger, Database Logger
    - Contains the logic to decide if it should act upon the request or not

* When we have if-else, if-else, if-else chainable code then we should consider using it.
- An object oriented way to express a chain of "if" "else if" and "else" statements.	

#### Features & Notes

	* Sender does not have to know about concrete implementation, and we can easily extend our chain of loggers with more ways to handle how we want to log our messages.
	* One or many handlers can process the request
	* The chain of handlers can be a linked list, collection or simple an array
	* Each concrete implementation of the Handler<T> will override the default Handler(T request)
	* Our concrete handlers are also our receivers
	* Decouples the sender and receiver	
	* Easily extend a chain to add additional handlers	
	* A more extensible, object oriented and dynamic implementation
	* Easily re-arrange in what order the handlers operate
	* Cleaner approach with single responsiblity in mind!
	* Decouple code and achieve a cleaner, more extensible code base!
	* The abstract handler takes care of the boilerplate code that each handler really should check before or after execution.
	* If we forget base.Handle() the chain breaks - override - if linked list is used
	* Even though the request passes through a receiver it does no mean it acted on the request
	* The receiver decides if it does anything with the request the request pass through the chain no matter what - instead of linked list - array	
	* The implementation of the logging handler has an array for receivers instead of a linked list (ILogger)	
	* ASP.NET Core Middlewares -> Request ... Middleware1, Middleware2, .. -> Response, chain middlewares	