A Delivery Company named FastTrack Logistics manages deliveries of various package types. Packages are considered to be of two types: Regular Package, Fast Delivery Package. All the packages have an identifier, description, weight, charge, distance, cost and date. The regular packages have a fixed charge of 80tk per kg and  fast delivery packages have charge of 120tk per kg.
Depending on the delivery details, they need to calculate the delivery cost differently:
 
If only weight (kg) is given, calculate cost based on weight and charge.
If weight and distance (km) are given, calculate cost based on weight, charge and include a distance charge. If distance is more than 500km add 2tk per km otherwise 1.5tk per km.
 
Design a C# program using OOP concepts to handle these situations efficiently.
