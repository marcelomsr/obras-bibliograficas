using ObrasBibliotecariasApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObrasBibliotecariasApp.Interfaces
{
    public interface IAuthor
    {
        IEnumerable<TblAuthor> GetAllAuthors();
        IList<string> GetAllAuthorsNames();
    }
}
