using ImplicitOperator.Entidades;
using ImplicitOperator.Services;


//Criar a Empresa
Empresa azsistemas = new Empresa
{
    CNPJ = "01358743974582",
    RazaoSocial = "AZSistema.Tech",
};





//Cria um Usuário 
Usuario usuario = new Usuario()
{
    Credencial = new Credencial { Login = "daniel", Senha = "102030" },
    Email = "meuemail@mail.com",
    Nome = "Daniel Silveira ",
    Empresa = azsistemas
};

//Adciona a empresa no banco de dados 
EmpresaService service = new EmpresaService();
service.Add(azsistemas);


