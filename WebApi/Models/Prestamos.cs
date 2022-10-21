using WebApi.Models.Base;

namespace WebApi.Models;

public class Prestamos:Model
{
    
    public int BookId {get;set;}

    public virtual Book? Book {get;set;} = default!;

    public int UsuarioId {get;set;}

    public virtual Usuario? Usuario {get;set;} = default;
}