# nif-spain-modules
A set of little self-tested modules for check spanish nif strings in several languages

In the different modules you can see the basic operation of some of the best known frameworks xUnit

## Usage
### Java
```java
NifSpain nifSpain = new NifSpain();

nifSpain.getLetter(12332358); // return B
nifSpain.getLetter("12332358"); // return B 

nifSpain.check("12332358B") // return true
nifSpain.check("123323584") // return false
```

### PHP
```php
$nifSpain = new NifSpain();

$nifSpain->getLetter(12332358) // return B
$nifSpain->getLetter("12332358") // return B

$nifSpain->check("12332358B") // return true
$nifSpain->check("123323584") // return false
```

### Python
```python
nif_spain = nifspain.NifSpain()

nif_spain.get_letter(12332358) # return B
nif_spain.get_letter("12332358") # return B

nif_spain.check("12332358B") # return true
nif_spain.check("123323584") # return false
```

### C# .NET
```csharp
NifSpain nifSpain = new NifSpain();

nifSpain.GetLetter(12332358); // return B
nifSpain.GetLetter("12332358"); // return B 

nifSpain.Check("12332358B") // return true
nifSpain.Check("123323584") // return false
```

### JavaScript
```javascript
var nif = nifSpain();

nif.getLetter(12332358); // return B
nif.getLetter("12332358") // return B 

nif.check("12332358B") // return true
nif.check("123323584") // return false
```

## License

jjsg is released under the Unlicense. See LICENSE for details.
