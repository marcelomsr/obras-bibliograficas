using NUnit.Framework;
using ObrasBibliotecariasApp.DataAccess;
using ObrasBibliotecariasApp.Utils;

namespace ObrasBibliotecariasAppTest
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test1()
		{
			Assert.AreEqual("GUIMARAES", AuthorNameFormatter.getFormatedAuthorName("guimaraes"));
			Assert.AreEqual("RIBEIRO, Marcelo da Silva", AuthorNameFormatter.getFormatedAuthorName("Marcelo da Silva Ribeiro"));
			Assert.AreEqual("RIBEIRO FILHO, Marcelo da Silva", AuthorNameFormatter.getFormatedAuthorName("Marcelo da Silva Ribeiro Filho"));
			Assert.AreEqual("SILVA, Joao", AuthorNameFormatter.getFormatedAuthorName("JOAO SILVA"));
			Assert.AreEqual("SILVA, Joao", AuthorNameFormatter.getFormatedAuthorName("joao silva"));
			Assert.AreEqual("SILVA, Joao da", AuthorNameFormatter.getFormatedAuthorName("joao da silva"));
			Assert.AreEqual("SILVA NETO, Joao da", AuthorNameFormatter.getFormatedAuthorName("joao da silva neto"));
			Assert.AreEqual("SILVA NETO, Joao", AuthorNameFormatter.getFormatedAuthorName("joao silva neto"));
			Assert.AreEqual("ASSIS, Machado de", AuthorNameFormatter.getFormatedAuthorName("machado de assis"));
			Assert.AreEqual("ANDRADE, Carlos Drummond de", AuthorNameFormatter.getFormatedAuthorName("carlos drummond de andrade"));
		}
	}
}