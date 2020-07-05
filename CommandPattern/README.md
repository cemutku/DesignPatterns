### Design Patterns : Command

- A command contains all the data to process the request now or at a later time
- The command pattern can easily be leveraged to allow undo or redo functionality		
- The command pattern will add complexity, but we can introduce new commands instead of modifying existing ones to avoid the risk of breaking other usages of the pre-existing command.

#### Command Pattern Elements
- Command  -> Holds instructions 										 (AddToCartCommand)
- Receiver -> What the command will execute								 (ShoppingCart)
- Invoker  -> To use execute the commands (keep track of the commands)   (CommandManager)
- Client   -> Decide what command to schedule for execution 		     (AddToCartButton in UI)		
		


		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		