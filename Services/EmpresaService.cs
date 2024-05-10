using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplicitOperator.Entidades;

namespace ImplicitOperator.Services
{
    /// <summary>
    /// Classe de exemplo apenas para simular as operções de CRUD
    /// </summary>
    internal class EmpresaService
    {
        private static IList<Empresa> Empresas = new List<Empresa>();

        public void Add(Empresa empresa)
        {
            Empresas.Add(empresa);
        }
        
        public void Delete(Empresa empresa)
        {
            Empresas.Remove(empresa);
        }  
        
        public void Update(Empresa empresa)
        {            
            Empresas.Remove(empresa);
            this.Add(empresa);
        }

        public IList<Empresa> ListAll()
        {
            return Empresas;
        }
    }
}
