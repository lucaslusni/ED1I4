using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05
{
	internal class Livros
	{
		
		private List<Livro> acervo;

		
		public Livros()
		{
			this.acervo = new List<Livro>();
		}

		public List<Livro> Acervo { get => acervo; set => acervo = value; }

		public void Adicionar(Livro livro)
		{
			this.acervo.Add(livro);
		}

		public Livro Pesquisar(Livro livro)
		{
			foreach (Livro l in this.acervo)
			{
				if (l.Isbn == livro.Isbn)
				{
					return l;
				}
			}
			return null;
		}

	}
}
