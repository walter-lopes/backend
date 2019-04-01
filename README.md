### Projeto SHAREBOOK backend.
#### Tecnologias usadas no projeto

- Visual Studio 2017.
- ASP.NET CORE 2.0.
- C#.
- SQL SERVER.
- SWAGGER.

#### Documentação das apis - Swagger

http://www.sharebook.com.br/swagger/

#### Como rodar o projeto ?

##### Via terminal:

- Abra o terminal
- Acesse a pasta `raiz_do_projeto/Sharebook`
- Execute: ```dotnet restore``` e na sequencia ```dotnet run --project ShareBook.Api```

## Como rodar o projeto no DOCKER ?

Assumindo que já tenha o [Docker](https://www.docker.com) instalado na máquina, execute os procedimentos abaixo:

1. Abra o console na pasta raiz da aplicação

2. Execute o o deploy, atualiza a imagem da aplicação e cria o banco MongoDB ```docker-compose up -d --build```

3. No seu browser acesse a url http://localhost:8181/swagger para acessar as apis


** Não se esquecer de mudar a connection string para a sua base de dados no arquivo appsettings.json que se encontra na camada da API do projeto.

** Sempre que criar as classes de model e map  rodar o comando:
"Add-Migration nome-do-migration" na camada BASE do projeto  para criar o novo migration para o  banco de dados.

#### Como rodar os testes ?

Estamos usando a biblioteca xUnit[https://github.com/xunit/xunit]. Todos os pacotes foram instalados através do NuGet. Caso necessário, efetue o comando Restore para baixar os pacotes para a sua máquina local.

Para executar os testes, faça um build da solução e depois acesse o Test Explorer acessando Test < Windows < Test Explorer no menu superior do Visual Studio.

Lista de bibliotecas instaladas para execução dos testes:
- Microsoft.NET.Test.Sdk
- Microsoft.AspNetCore.App [Microsoft.NET.Test.Sdk dependency]
- xunit
- xunit.runner.visualstudio
