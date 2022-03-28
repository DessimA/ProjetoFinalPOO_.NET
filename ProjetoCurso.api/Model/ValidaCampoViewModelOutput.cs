using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoCurso.api.Model
{
    public class ValidaCampoViewModelOutput
    {
        public IEnumerable<string> Erros { get; private set; }
        public ValidaCampoViewModelOutput(IEnumerable<string> erros)
        {
            Erros = erros;
        }
    }
}
