# Codetasy Console
Initialize a sample [Codetasy.Cli](https://github.com/codetasy/cli) .NET Core console application.

## Install pre-requisites
[.Net Core](https://www.microsoft.com/net/core) 

## How to Register a new command
Define a `public class` in your project with a `public method` declared as `[Command]`

```csharp
public class Action
{
    [Command("hello")]
    public void Hello(Dictionary<string, string> args)
    {
        Console.WriteLine($"Hello {args["name"]} {args["lastname"]}");
    }
}
```

## Run your command

```
dotnet run hello name="Eddard" lastname="Stark"
```

*Output:* 
```
Hello Eddard Stark
```

## Roadmap
Add full solution example:
- UI Layer (Console)
- Business Logic Layer (BAL)
- Data Access Layer (DAL)


## License
This software is licensed under the [MIT License](/LICENSE)

© Jorge Vera, 2017
