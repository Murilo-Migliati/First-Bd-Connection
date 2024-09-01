using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Data;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Model
{
    public class Livro
    {
        
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Ano {  get; set; }
        public Livro() { }
    }
}
