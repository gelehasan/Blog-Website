using System;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
	public class DataDbContext : DbContext
	{


		public DataDbContext(DbContextOptions options): base (options)
		{

		}

		//Many to many relationship
		public DbSet<BlogPost> BlogTable { get; set; }

		public DbSet<Tag> TagTable { get; set; }
	}

}


