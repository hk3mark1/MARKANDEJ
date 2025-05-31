README.txt
===========



RPG Battle 


members:EJ Zaragoza
	Mark Lester Malbog




2. Mark_Marksman  
   A quick and agile ranged attacker. Grecee excels at dealing high damage from a distance but has lower health compared to others.

3.	ej_Assassin  
   A stealthy and deadly assassin. Prins deals burst damage and has a chance to critically strike, but sacrifices defense for offense.



✅ Encapsulation  
- Each character’s health, damage, and actions are managed within their own class using methods like `Attack()` and `TakeDamage()`, hiding the internal logic from the main form.



✅ Polymorphism  
-Different character subclasses can override the `Attack()` method and behave differently during battle because the simulator handles all players using the base `Character` type.

✅ Abstraction  
-Simple method calls (`Attack`, `TakeDamage`) are used by the form to interact with characters; internal implementation specifics are not necessary.

✅ Exception Handling  
To ensure that the program continues to function properly even in the event of an error, we include try-catch blocks to handle runtime problems, missing photos, and incorrect inputs.



--------------------------------


