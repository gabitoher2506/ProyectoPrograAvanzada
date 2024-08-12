namespace ProgramacionAvanzada1.Models;
using Microsoft.AspNetCore.Identity;

  public class ApplicationUser : IdentityUser
{
    public string Nombre { get; set; }
    public string Rol { get; set; }
}

