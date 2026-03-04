# EntityModelBinder 🚀

Simplify database entity retrieval in ASP.NET Core.

## Usage

Define your model end inherit from IEntity

```C#
public class Product : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
```

Then just call it from your api

```C#
[HttpGet("products/{product}")]
public IActionResult Get([FromRoute] Product product)
    => Ok(product);
```

### Before

```C#
[HttpGet("products/{id}")]
public async Task<IActionResult> Get(int id) {
    var product = await _context.Products.FindAsync(id);
    if (product == null) return NotFound();
    return Ok(product);
}
```

### After

```C#
[HttpGet("products/{product}")]
public IActionResult Get([FromRoute] Product product)
    => Ok(product);
```
