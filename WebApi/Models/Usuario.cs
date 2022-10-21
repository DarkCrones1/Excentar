using WebApi.Models.Base;

namespace WebApi.Models;

public class Usuario:Model
{
    public string? Name {get; set;}

    public string? LastName {get; set;}

    public string? Address {get; set;}
}