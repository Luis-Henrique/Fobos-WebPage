namespace Fobos.Models;
using System.ComponentModel.DataAnnotations;

public class Post
{
    public int Id { get; set; }

    public string Titulo { get; set; }

    public string Linkimagem { get; set; }

    public string Subtitulo1 { get; set; }

    public string Conteudo1 { get; set; }

    public string Subtitulo2 { get; set; }

    public string Conteudo2 { get; set; }

    public string Categoria { get; set; }

    public string Data { get; set; }

    public string Descricao { get; set; }

    public string Autor { get; set; }

    public string Autorimg { get; set; }

    public string Apoio { get; set; }

    public Post() { }

    public Post(int id, string titulo, string linkimagem, string subtitulo1, string conteudo1, string subtitulo2, string conteudo2, string categoria, string data, string descricao, string autor, string autorimg, string apoio)
    {
        Id = id;
        Titulo = titulo;
        Linkimagem = linkimagem;
        Subtitulo1 = subtitulo1;
        Conteudo1 = conteudo1;
        Subtitulo2 = subtitulo2;
        Conteudo2 = conteudo2;
        Categoria = categoria;
        Data = data;
        Descricao = descricao;
        Autor = autor;
        Autorimg = autorimg;
        Apoio = apoio;
    }
}