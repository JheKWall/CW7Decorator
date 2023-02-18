# CW7Decorator
AKA The assignment that I somehow messed up:
1. I am unsure whether this is a fault within the Main method, or within the call logic of the classes themselves; but when calling the top decorator, it skips the print statements of the decorators inbetween itself and the TextField. Instead, it exclusively utilizes the abstract Decorator class's draw method for the inbetween instances. I have no clue how this is happening and I think I've spent an hour trying to fix it to no avail.
2. A warning, Visual Studio says that the decorator draw() methods hide the abstract Decorator's draw() method and that if that was intended, to give the decorator draw() methods the 'new' keyword. No clue what is going on there.
3. TECHNICALLY, the program still works although the logic behind it is very suspect.
