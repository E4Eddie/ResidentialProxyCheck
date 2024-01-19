<h1 align="center">
  <br>
  ResidentialProxyCheck
  <br>
</h1>

<h4 align="center">Residential proxy checking lib</h4>

## Example usage


```csharp
            ResidentialProxyChecker residentialProxyChecker = new ResidentialProxyChecker();

            Console.WriteLine("Type in a given proxy to check if its residential or not.");
            Console.Write("-->");
            string proxy = Console.ReadLine();

            try
            {
                // ("127.0.0.1:8888", 2000) <- 2seconds
                // PROXY, TIMEOUT IN MS.
                if (residentialProxyChecker.IsResidentialProxy(proxy, 2000))
                { Console.WriteLine("That is a Residential Proxy"); }else
                { Console.WriteLine("That is NOT a Residential Proxy"); }} catch
                (Exception ex) { Console.WriteLine("Proxy failed, bad proxy."); 
            }
            Console.ReadKey();
```
Example project can be found at [Examples](ResidentialProxyCheck/Example/Program.cs)

## License

MIT

---

> GitHub [@E4Eddie](https://github.com/E4Eddie) &nbsp;&middot;&nbsp;

