using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitOperator.Entidades
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// Credenciais do usuário, login e senha
        /// </summary>
        public Credencial Credencial {  get; set; }

        /// <summary>
        /// Empresa a qual ele pertence 
        /// </summary>
        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
    }
}
