namespace Fobos.Models;
using System.ComponentModel.DataAnnotations;

public class User
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Preencha o campo")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Preencha o campo")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Preencha o campo")]
    public string Telefone { get; set; }

    public User() { }

    public User(int id, string nome, string email, string telefone)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Telefone = telefone;
    }
}