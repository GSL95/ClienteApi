<h1>📦 ClienteApi</h1>

API RESTful desenvolvida em ASP.NET Core (.NET 8) para gerenciamento de clientes com as operações básicas de CRUD (Create, Read, Update, Delete) e filtragem por interesse.
Esta API foi projetada para ser consumida por aplicações externas, neste caso para dar suporte a uma imobiliária que precisava melhorar a gestão dos seus clientes. Mas pode
ser adapatada para diversas aplicações.

📌 Funcionalidades

A API oferece:

CRUD de clientes

Criar cliente

Listar todos

Buscar por id

Atualizar cliente

Excluir cliente

Filtro por interesse

Listar clientes por tipo de interesse (enum)

Estrutura moderna

DTOs (entrada/saída)

Service layer

Swagger (documentação e testes)

Entity Framework Core com SQL Server

🧪 Endpoints

A documentação interativa pode ser acessada via Swagger quando a API está rodando localmente ou no ambiente de produção.

📌 URL Swagger (local):

https://localhost:<PORT>/swagger

Principais rotas
Método	Endpoint	Descrição
GET	/api/clientes	Lista todos os clientes
GET	/api/clientes/{id}	Busca cliente por ID
GET	/api/clientes/por-interesse	Lista clientes por interesse
POST	/api/clientes	Cria um novo cliente
PUT	/api/clientes/{id}	Atualiza um cliente
DELETE	/api/clientes/{id}	Exclui um cliente

📁 Estrutura do Projeto

📦 ClienteApi
├── 📁 Controllers
├── 📁 Data
├── 📁 DTOs
├── 📁 Models
│   └── Enums
├── 📁 Services
├── 📄 Program.cs
├── 📄 appsettings.json
└── 📄 ClienteApi.csproj
