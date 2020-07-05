### Strategy Design Pattern

* The Strategy pattern is sometimes also called policy pattern
	
#### Strategy Structure

- Context : Has a reference to a strategy and invokes it
	* Calls -> `IStrategy.SendMessage(message)`
			
- IStrategy : Defines the interface for the given strategy
	* Defines the contract : `SendMessage(Message message);`
			
- Strategy : A concrete implementation of the strategy
    * `EmailStrategy`
    * `SmsStrategy	`

#### Features
			
* Select an implementation at runtime, based on user input without having to extend the class	
* The context should not know about the concrete implementations of a strategy as it will only be using the strategy interface
* The strategy pattern is a behavioral design pattern and the idea is that you choose a suitable strategy based on user input	 
* Easily add new strategies without affecting existing ones
* Cleaner approach with single responsibility in mind
		
		
		
	
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		