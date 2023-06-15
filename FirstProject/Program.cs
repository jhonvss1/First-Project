// Aprimorando o conhecimento da aula01

// Sistema de Login

using FirstProject;

Console.WriteLine("-------------------- Bem vindo novamente vamos realizar o seu login? ------------------------------");
string emailvalido = "jhon.vs1@gmail.com";
string senhavalida = "jhonlindao";
//Nome do usuario
Console.WriteLine("Digite seu nome: ");
string name = Console.ReadLine();
//Email 
Console.WriteLine("Digite seu email: ");
string email = Console.ReadLine(); // ele vai pedir ao usuario o email

// Senha
Console.WriteLine("Digite sua senha: "); // vai informar ao usuario que quer a senha
string senha = Console.ReadLine(); // manda o usuario digitar a senha em caractere
// token
Random random = new Random();
var token = random.Next(1, 100).ToString(); 

// Validação dos campos do usuário

if (email != emailvalido || senha != senhavalida)
{
    Console.WriteLine("Email ou senha errados.");
    return;
}
//Retorno de sucesso
ReturnSucessDTO returnSucess = new ReturnSucessDTO()
{
    Message = "Login Realizado com sucesso",
    Name = name,
    Token = token
}; 

Console.WriteLine ($"Message {returnSucess.Message}\n Name : {returnSucess.Name}\n Token {returnSucess.Token}");