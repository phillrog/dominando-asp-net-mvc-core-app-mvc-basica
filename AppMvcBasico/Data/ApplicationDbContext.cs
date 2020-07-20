using System;
using System.Collections.Generic;
using System.Text;
using AppMvcBasico.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppMvcBasico.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Produto> Produtos { get; set; }
		public DbSet<Fornecedor> Fornecedores { get; set; }
		public DbSet<Endereco> Enderecos { get; set; }
	}
}
