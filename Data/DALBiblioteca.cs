using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;
using Microsoft.EntityFrameworkCore;



namespace Biblioteca.Data
{
    internal class DALBiblioteca : DbContext
    {
        public DbSet<Livro> Livros { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Biblioteca.db");
        }


        public static void AdicionarLivro(Livro novoLivro)
        {
            using (var contexto = new DALBiblioteca())
            {
                contexto.Livros.Add(novoLivro);
                contexto.SaveChanges();
            }
        }

        public Livro ObterLivroPorId(int id)
        {
            using (var contexto = new DALBiblioteca())
            {
                return contexto.Livros.Find(id); 
            }
        }

        public static List<Livro> ObterTodosOsLivros()
        {
            using (var contexto = new DALBiblioteca())
            {
                return contexto.Livros.ToList(); 
            }
        }
        public static void AtualizarLivro(Livro livroAtualizado, int id)
        {
            using (var contexto = new DALBiblioteca())
            {
                
                var livroExistente = contexto.Livros.Find(id);

                if (livroExistente != null)
                {
                    
                    livroExistente.Titulo = livroAtualizado.Titulo;
                    livroExistente.Ano = livroAtualizado.Ano;

                  
                    contexto.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Livro não encontrado.");
                }
            }
        }

        public static void DeletarLivro(int id)
    {
        using (var contexto = new DALBiblioteca())
        {
            var livro = contexto.Livros.Find(id);
            if (livro != null)
            {
                contexto.Livros.Remove(livro);
                contexto.SaveChanges();
            }
        }
    }
    }
}
