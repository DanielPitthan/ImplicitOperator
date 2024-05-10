using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitOperator.Entidades
{

    /// <summary>
    /// Classe da Empresa para demonstrar o Implicit Operator 
    /// </summary>
    internal class Empresa
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }

        /// <summary>
        /// Uma empresa pode ter N usuários
        /// </summary>
        public ICollection<Usuario> Usuarios { get; set; }

    }
}
