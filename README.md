# SalesWeb - Gerenciador de Vendas ASP.NET Core MVC
[![Mit](https://img.shields.io/npm/l/react)](https://github.com/VagnerBritz/SalesWeb/blob/main/LICENSE)

  Bem-vindo ao repositório do projeto SalesWeb! Este é um aplicativo ASP.NET Core MVC desenvolvido durante o curso "C# COMPLETO Programação Orientada a Objetos + Projetos" ministrado pelo Prof. Nélio Alves. O SalesWeb é um gerenciador de vendas que permite cadastrar vendedores, departamentos e consultar vendas previamente cadastradas.
### Layout Web
## Tecnologias e recursos utilizados
O projeto foi desenvolvido utilizando as seguintes tecnologias e recursos:
- Aspnet Core MVC 6.0 com c#
- Razor engine
- Entity Framework (EF Core)
- Programação Orientada a objetos;
- Scaffolding de CRUD
- Banco de dados SQL Server
- Bootstrap
- CRUS de vendedores
- CRUD de categorias

## Como Executar o Projeto
Para executar o projeto localmente, siga os passos abaixo:

#### 1. Pré-requisitos:
- Certifique-se de ter o SDK do ASP.NET Core 6.0 ou superior instalado em sua máquina.
- Tenha um servidor SQL Server configurado (ou utilize alguma outra fonte de dados suportada pelo EF Core).
#### 2. Clone este repositório:
````bash
git clone https://github.com/VagnerBritz/SalesWeb.git
````
#### 3. Abra o projeto no Visual Studio ou em outra IDE compatível com o ASP.NET Core.
#### 4. Verifique a conexão com o banco de dados:

- No arquivo appsettings.json, verifique a string de conexão com o banco de dados SQL Server.
#### 5. Execute as migrações do EF Core para criar o banco de dados:
- No terminal, navegue até a pasta raiz do projeto e execute o comando:
 ```bash
dotnet ef database update
  ```
#### 6. Inicie o projeto:
 - No Visual Studio, pressione F5 ou clique no botão "Iniciar".
 #### 7. O aplicativo SalesWeb deverá ser executado localmente e estará disponível em http://localhost:porta (a porta será exibida na saída do terminal ou console).

## Licença
Este projeto é licenciado sob a licença MIT. Para mais detalhes, consulte o arquivo LICENSE.

## Contato
Em caso de dúvidas ou sugestões, sinta-se à vontade para entrar em contato:

Nome: Vagner Britz
Email: vagner.britz@gmail.com
LinkedIn: www.linkedin.com/in/vagnerbritz

   
