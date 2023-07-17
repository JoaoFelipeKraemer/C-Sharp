using JsonFlatFileDataStore;
using Microsoft.AspNetCore.Mvc;

namespace RecipeApi.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class RecipeController : ControllerBase
{
    private readonly IDataStore _db;

    public RecipeController(IDataStore db)
    {
        _db = db;
    }
}
