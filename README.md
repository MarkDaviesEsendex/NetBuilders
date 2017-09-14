# NetBuilders

In the .Net language there are a few builder that allow method chaining such as the string builder:

```
var sb = new StringBuilder()
            .Append("String1")
            .Apeend("String2");
```
This repository is attempting to add more "builders" to the language such as a list builder:

```
var list = new ListBuilder<Item>()
            .Add(new Item())
            .Add(new Item());
```
Or an Array builder
```
var array = new ArrayBuilder<Item>(10)
                .Add(new Item())
                .Add(new Itme());
```

## Builder Pattern
Calling these builders is a bit of a lie, they do "build" an object for us but it is not an implementation of the builder pattern and I am aware of this, the reason I am calling these "builers" is that I am following the .Net StringBuilder pattern, so I thought that I would keep that naming convention consistent.

## Functional .Net?
Sort of. Maybe?
The goal here is not to make .Net functional, F# does a pretty good job of that, it is to introduce builders to more objects and more things can be chained, because chaining methods is awesome.

## Goal
I am attempting to make method chaining available for appropriate classes in .Net.

## Contributing 
1. Raise and issue
2. Get issue categorized
3. Fork repository
4. Fix issue (prefrably under a branch)
5. Submit pull request
6. ???
7. Profit?
