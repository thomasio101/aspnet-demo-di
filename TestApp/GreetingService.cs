﻿namespace TestApp
{
    public interface IGreetingService
    {
        string Greet(string name);
    }

    public class GreetingService : IGreetingService
    {
        public string Greet(string name) => $"Hello, {name}!";
    }
}
