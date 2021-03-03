using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObrasBibliotecariasApp.Utils
{
	public class AuthorNameFormatter
	{
		public static string getFormatedAuthorName(string fullName)
		{
			List<string> namesTmp = fullName.ToLower().Split(" ").ToList<string>();
			List<string> names = new List<string>();

			foreach (string name in namesTmp)
				names.Add(name.ToUpper().First() + name.Substring(1).ToLower().Trim());

			if (names.Count == 1)
				return names[0].ToUpper();

			string[] agnomes = { "FILHO", "FILHA", "NETO", "NETA", "SOBRINHO", "SOBRINHA", "JUNIOR" };

			string surname = names[names.Count - 1].ToUpper();
			names.Remove(names[names.Count - 1]);

			foreach (string agnome in agnomes)
				if (surname.ToUpper().Contains(agnome))
				{
					surname = $"{names[names.Count - 1].ToUpper()} {agnome}";
					names.Remove(names[names.Count - 1]);
				}

			string[] prepositions = { "Da", "De", "Do", "Das", "Dos" };

			string firstName = String.Join(' ', names);

			foreach (string preposition in prepositions)
				if (names.Contains(preposition))
					firstName = firstName.Replace(preposition, preposition.ToLower());

			return $"{surname}, {firstName}";
		}
	}
}
