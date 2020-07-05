### Unit of Work Pattern

- Characteristics
	- References multiple repositories
	- Reduce the communication with the database

#### Features
		
- We are using multiple instances of the DbContext, this means that the different repositories will not be able reference each others entities.
- Tied things are done in the same transaction.
- It encapsulates our different repositories, that is part of this unit of work. It also allows us to save the changes for all of the different repositories that we've made changes too.
- If we leverage the multiple entities and repositories, we can use the unit of work to make operations in a single transaction.

#### Caveats
- When writing a test for a controller leveraging the unit of work we will no longer know which repositories it really uses.	
- One of the problems with the unit of work is that from an outside perspective, we might not know which of the repositories in our unit of work that our controller or action or method that we are calling is leveraging in really large solution. We might break it up and have multiple different unit of works with only the repositories that makes sense to be changed together.	
- In high performant environments limiting the communication can be crucial.
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	