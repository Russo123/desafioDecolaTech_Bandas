﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dio_Bandas.Classes
{
    class BandaRepositorio
    {
		private List<Banda> listaBanda = new List<Banda>();
		public void Atualiza(int id, Banda objeto)
		{
			listaBanda[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaBanda[id].Excluir();
		}

		public void Insere(Banda objeto)
		{
			listaBanda.Add(objeto);
		}

		public List<Banda> Lista()
		{
			return listaBanda;
		}

		public int ProximoId()
		{
			return listaBanda.Count;
		}

		public Banda RetornaPorId(int id)
		{
			return listaBanda[id];
		}
	}
}
