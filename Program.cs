using System;
using Biblioteca.Data;
using Biblioteca.Model;

public class Program
{
    public static void Main()
    {
        Livro NovoLivro = new Livro()
        {
            Titulo = "VAI CARARIO",
            Ano = "1988"
        };
        DALBiblioteca.AdicionarLivro(NovoLivro);
        Livro EditadoLivro = new Livro()
        {
            Titulo = "Black Myth: Wukong",
            Ano = "2024"
        };
        List<Livro> livros = DALBiblioteca.ObterTodosOsLivros();
        ExibirLivros(livros);

    }

    public static void ExibirLivros(List<Livro> livros)
    {
        foreach (var livro in livros)
        {
            Console.WriteLine($"{livro.Id} - {livro.Titulo} - ({livro.Ano})");
        }
    }
}
