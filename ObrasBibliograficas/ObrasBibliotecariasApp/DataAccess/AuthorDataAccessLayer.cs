using ObrasBibliotecariasApp.Interfaces;
using ObrasBibliotecariasApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObrasBibliotecariasApp.Utils;

namespace ObrasBibliotecariasApp.DataAccess
{
	public class AuthorDataAccessLayer : IAuthor
	{
		private myDBContext db;

		public AuthorDataAccessLayer(myDBContext _db)
		{
			db = _db;
		}

		public IEnumerable<TblAuthor> GetAllAuthors()
		{
			try
			{
				return db.TblAuthor.ToList().OrderBy(x => x.AuthorId);
			}
			catch
			{
				throw;
			}
		}

		public IList<string> GetAllAuthorsNames()
		{
			try
			{
				IList<string> authors = new List<string>();

				foreach (TblAuthor author in db.TblAuthor.ToList().OrderBy(x => x.AuthorId))
					authors.Add(AuthorNameFormatter.getFormatedAuthorName(author.Name));

				return authors;
			}
			catch
			{
				throw;
			}
		}
	}
}
