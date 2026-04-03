# ProductClientHub

ProductClientHub é uma API RESTful construída com ASP.NET Core para gerenciar clientes e seus produtos associados. Segue os princípios da Clean Architecture, fornecendo uma abordagem estruturada para lidar com lógica de negócio, acesso a dados e endpoints da API.

## Funcionalidades

- **Gerenciamento de Clientes**: Operações CRUD completas para clientes, incluindo registro, atualizações, recuperação e exclusão.
- **Gerenciamento de Produtos**: Registrar e excluir produtos vinculados a clientes específicos.
- **Validação**: Validação de entrada usando FluentValidation para garantir a integridade dos dados.
- **Tratamento de Erros**: Tratamento de exceções personalizado com mensagens de erro significativas e códigos de status HTTP apropriados.
- **Documentação da API**: Swagger/OpenAPI integrado para documentação interativa da API.
- **Banco de Dados**: Usa SQLite para persistência de dados (configurável para outros provedores).

## Tecnologias Utilizadas

- **Framework**: ASP.NET Core (.NET 10.0)
- **ORM**: Entity Framework Core com SQLite
- **Validação**: FluentValidation
- **Documentação da API**: Swashbuckle.AspNetCore (Swagger)
- **Arquitetura**: Clean Architecture com camadas de Use Cases, Entities e Infrastructure

## Pré-requisitos

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- SQLite (incluído com EF Core)

## Instalação

1. Clone o repositório:

   ```bash
   git clone https://github.com/yourusername/ProductClientHub.git
   cd ProductClientHub
   ```

2. Restaure as dependências:

   ```bash
   dotnet restore
   ```

3. Construa o projeto:

   ```bash
   dotnet build
   ```

4. Execute a aplicação:

   ```bash
   dotnet run --project ProductClientHub.API
   ```

A API estará disponível em `https://localhost:5001` (ou a porta especificada em `launchSettings.json`).

## Uso

### Endpoints da API

#### Clientes

- **POST** `/api/clients` - Registrar um novo cliente
  - Corpo: `{ "name": "string", "email": "string" }`
  - Resposta: `{ "id": "guid", "name": "string" }`

- **PUT** `/api/clients/{id}` - Atualizar um cliente existente
  - Corpo: `{ "name": "string", "email": "string" }`

- **GET** `/api/clients` - Obter todos os clientes
  - Resposta: `{ "clients": [ { "id": "guid", "name": "string", "email": "string", "products": [...] } ] }`

- **GET** `/api/clients/{id}` - Obter um cliente por ID
  - Resposta: `{ "id": "guid", "name": "string", "email": "string", "products": [...] }`

- **DELETE** `/api/clients/{id}` - Excluir um cliente

#### Produtos

- **POST** `/api/products/{clientId}` - Registrar um novo produto para um cliente
  - Corpo: `{ "name": "string", "brand": "string", "price": decimal }`
  - Resposta: `{ "id": "guid", "name": "string" }`

- **DELETE** `/api/products/{id}` - Excluir um produto

### Documentação Swagger

Acesse a documentação interativa da API em `https://localhost:5001/swagger` quando executando em modo de desenvolvimento.

## Estrutura do Projeto

- **ProductClientHub.API**: Projeto principal da API com controladores, casos de uso, entidades e infraestrutura.
- **ProductClientHub.Communication**: Modelos de requisição e resposta.
- **ProductClientHub.Exceptions**: Classes de exceções personalizadas.

## Contribuição

1. Faça um fork do repositório.
2. Crie uma branch de funcionalidade (`git checkout -b feature/AmazingFeature`).
3. Faça commit das suas mudanças (`git commit -m 'Add some AmazingFeature'`).
4. Faça push para a branch (`git push origin feature/AmazingFeature`).
5. Abra um Pull Request.

## Contact

For questions or support, please open an issue on GitHub.
