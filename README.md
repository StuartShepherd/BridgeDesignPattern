# Bridge Example
Bridge is a structural design pattern that divides business logic or huge class into separate class hierarchies that can be developed independently.

One of these hierarchies (often called the Abstraction) will get a reference to an object of the second hierarchy (Implementation). 
The abstraction will be able to delegate some (sometimes, most) of its calls to the implementations object. 
Since all implementations will have a common interface, they’d be interchangeable inside the abstraction.

## Usage examples
The Bridge pattern is especially useful when dealing with cross-platform apps, supporting multiple types of database servers or working with several API providers of a certain kind (for example, cloud platforms, social networks, etc.)

## Identification
Bridge can be recognized by a clear distinction between some controlling entity and several different platforms that it relies on.

## Applicability
Use the Bridge pattern when you want to divide and organize a monolithic class that has several variants of some functionality (for example, if the class can work with various database servers).

Use the pattern when you need to extend a class in several orthogonal (independent) dimensions.

Use the Bridge if you need to be able to switch implementations at runtime.

## Getting Started

### Prerequisites

[.NET Core 3.1 SDK or later](https://dotnet.microsoft.com/download/dotnet-core/3.1)