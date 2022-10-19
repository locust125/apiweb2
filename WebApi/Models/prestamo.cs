using WebApi.Models.Base;

namespace WebApi.Models;

public class prestamo: Model
{
    public int? IdLibro {get; set;}

    public int? cliente {get; set;}

    public DateTime prestamos {get; set;}

    public DateTime regreso {get; set;}

    public virtual cliente? clientes { get; set;} = default!;
}