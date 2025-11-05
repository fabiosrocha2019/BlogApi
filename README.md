Tecnologias usadas .NET CORE 8 linguagem C# e documentação Swagger e banco de dados Entity Framework, ao rodar o projeto as APIS estarão expostas e prontas para testes.

Caso não tenha uma máquina preparada já rodando projetos com Entity Framework, clique com o botão direito do mouse na solução e indo em Abrir Terminal, e então rode os seguintes comandos:

dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools

Depois de configurar o ambiente, rode o comando:

dotnet ef database update

E então, quando o banco de dados for criado, é só rodar a solução e começar os testes.

Pelo projeto ser simples, optei por uma separação em pastas mais simples e bem organizada, tambem para evitar overengineering e adicionar complexidade a mais sem necessidade.
