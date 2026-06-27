Reflection

 1. Why did you use inheritance?

	I used inheritance because all of the transport types, such as Car, Airplane, Boat, and Helicopter, are considered vehicles. Instead of writing the same code over and over, they can inherit common features from the Vehicle class while still having their own way of moving.

2. Why did you use interfaces?

	I used interfaces because they describe what a vehicle can do. For example, a car can drive, an airplane can fly, and a boat can sail. Using interfaces makes the program more flexible since different vehicles can have different abilities.

 3. Could Helicopter inherit from both Vehicle and Airplane? Why or why not?

	No. In C#, a class can only inherit from one base class. Because of this, the Helicopter can inherit from Vehicle only. If it needs multiple abilities, it can implement multiple interfaces instead.

 4. Why can Helicopter implement both IFlyable and IDriveable?

	A class can implement more than one interface in C#. This allows the Helicopter to have both flying and driving capabilities at the same time, even though it only inherits from one base class.

 5. If a Submarine can both sail and dive, how would you design it?

	I would make the Submarine inherit from the `Vehicle` class and implement both the ISailable and IDiveable interfaces. This way, it can share common vehicle features while also having the ability to sail on the surface and dive underwater.
