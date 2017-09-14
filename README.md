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
