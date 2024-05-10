using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitOperator.JsonsResponses
{
    /// <summary>
    /// Classe empresa representada em formato Json 
    /// </summary>
    internal class EmpresaJsonResponse
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
    }
}
