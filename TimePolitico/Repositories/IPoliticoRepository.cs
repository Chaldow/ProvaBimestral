using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimePolitico.Models;

namespace TimePolitico.Repositories
{
    interface IPoliticoRepository
    {
        public IList<Politico> ListarTodasCategorias();

        public Politico BuscarCategoriaPorId(int id);

        public void InserirCategoria(Politico candidato);

    }
}
