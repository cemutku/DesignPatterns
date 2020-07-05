### Design Patterns : State

State is the condition of something variable.

**The State Design Pattern minimizes conditional complexity (Without boolean fields and a lot of if statements).**

- Design challenges:
	- How can an object change its behavior when its internal state changes?
	- How can state specific behaviors be defined so that states can be added without altering the behavior of existing states?	

##### State Pattern
	
	Context(-current state, SetState()) 
		-> Abstract State(... Notify()) 
			-> Concrete State (... Notify()) (derived from abstract state)
		
	
##### Elements of the State Pattern
- Context
	* Maintains an instance of a concrete state as the current state 
		
- Abstract State
	* Defines an interface which encapsulates all state-specific behaviors
	
- Concrete State (any number of ...)
	* Implements behaviors specific to a particular state of context
		

##### Pattern Approach
- A list of possible states
- The conditions for transitioning between those states
- The state its in when initialized, or its initial state
- Each state has its own concrete class

