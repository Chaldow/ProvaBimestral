using TimePolitico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace TimePolitico.Repositories
{
    public class PoliticoRepository
    {
        private IList<Politico> listaPoliticos = new List<Politico>();
        public PoliticoRepository()
        {
            listaPoliticos.Add(new Politico() { id = 1, nomeCandidato = "Nunes" });
            listaPoliticos.Add(new Politico() { id = 2, nomeCandidato = "Humberto" });
        }
        public Politico BuscarPoliticoPorId(int id)
        {
            //sintaxe linq
            //operador Where() fazer filtros
            //categoria quero filtrar uma categoria pelo id dela
            //colecao.Where(colocarVariavel => operacao relacional );

            return listaPoliticos.Where(x => x.id == id).FirstOrDefault();
        }

        public void InserirCategoria(Politico candidato)
        {
            throw new NotImplementedException();
        }

        public IList<Politico> ListarTodasCategorias()
        {
            return listaPoliticos;
        }
    }
}
