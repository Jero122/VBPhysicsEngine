# 2D Physics Engine

A basic 2D Physics and Collision Engine written with VB for my A-Level project

![adfad](https://i.gyazo.com/a29cab213c8de0f5ab4b27d165515ca9.png9)

## Features
- **Circle to circle collisions**
	- Collision Detection
	- Static Resolution
	- Dynamic Resolution
	- Fixed(Static) Circles
- **Circle to rectangle colissions** 
	- Collision Detection
	- static & dynamic resolution (for circles only)
- **Variable gravity and coefficient of restitution**
- **Variable simulation speed**
- **Semi- Explicit Euler Integration implemented**
- **Sample project**

## Planned Features
- **AABB (rectangle) to AABB colission detection and resolution:**
Axis aligned bounding  collisions were not required by my project client hence they were not included in the engine. However, this is not too difficult to achieve and will be implemented once I have time.
- **Oriented  bounded box collisions:**
The same as rotating rectangles. I wanted to do this when writing the engine but I lacked both the mathematical knowledge and time.

## Sample Project

![](https://gyazo.com/626acb0a66cd4dd14cacc3030745615f.png)

The sample project included comes with a basic text tutorial on how to use it.

The sample project is able to simulate a variety of collisions with different settings of gravity, you can simulate the Earth or Moon for example.

It is also able to simulate the ideal gas laws, by setting the CoR to and gravity to 0. If you spawn some circle particles and then accelerate one of them, via left mouse drag.

## Using the Engine
### Creating a Rectangle:
```vbnet
Dim obj As RectangleParticle = New RectangleParticle(x, y, WIDTH, HEIGHT, MASS, ISFIXED, isSPAWNING, COLOR)
Simulator.particles.add(obj)
```
### Creating a Circle
```vbnet
Dim obj As CircleParticle =  Simulator.particles.Add(New CircleParticle(X, Y, RADIUS, MASS, ISFIXED, isSPAWNING, COLOR)
Simulator.particles.add(obj)
```
Unfortunately no constructor overloading exists currently as I did not know about this at the time.

``` isSPAWNING ``` is whether the particle is active or not, true = not active.

### Updating the Simulation
```vbnet 
Simulator.StepUp(PaintEventArgs)
```
By passing the PaintEventArgs to StepUp, you can draw the particles on anywindow of your choosing.

## Vector (2D coordinates)
The Engine comes with it's own Vector class, for 2D coordinates. Not to be confused 
The X and Y components can be accessed via the properties ``xCord`` and ``yCord``
### Manipulating Vectors
#### Overloaded Operators:
- '+' Adds two vectors together
- '-' Subtracts two vectors
- '*' Scalar Multiplication
- '/' Scalar Division
#### Functions
- **rotate(Vector, Theta)** : Rotates the vector by the amount specified by theta by applying the rotational matrix to the vector
-  **Magnitude (Vector)** : Finds the magnitude/ size of the vector
- **Magnitude (Vector, Vector)** : Finds the distance between the two Vectors (*Should have been called Distance*)
- **MagnitudeSquared(Vector)/(Vector, Vector)**: Returns the squared value of the magnitude (to calling the square root method too many times)
- **Normalise(Vector)** : Returns a vector with magnitude a magnitude of 1 while maintaining the same direction.


## Disclaimer
**This is by no means a production ready engine.** It was **only created for an A-Level Computer Science** project since I was interested in physics simulation. Using this for a scientific purpose or to create a game is not advised as the approach taken was quite **inefficient**, however it was acceptable for a pre-University computer science student. 
Having more than a few objects might start to create lag. The main issue is actually updating the table displaying the data of each object in the sample project.

My programming ability have vastly improved since I first created this engine almost 2 years ago. There are a lot of things that I question when I look at them right now. I am planning to port the engine to C# or Java when I have time next with an improved architecture and more efficient techniques. However, I am still proud of what I manged to accomplish  as an A-Level student at the time.
