<h1>📦 ClienteApi</h1>

API RESTful desenvolvida em ASP.NET Core (.NET 8) para gerenciamento de clientes com as operações básicas de CRUD (Create, Read, Update, Delete) e filtragem por interesse.
Esta API foi projetada para ser consumida por aplicações externas, neste caso para dar suporte a uma imobiliária que precisava melhorar a gestão dos seus clientes. Mas pode
ser adapatada para diversas aplicações.

<h3>📌 Funcionalidades</h3>

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

<h3>🧪 Endpoints</h3>

A documentação interativa pode ser acessada via Swagger quando a API está rodando localmente ou no ambiente de produção.

📌 URL Swagger (local):

https://localhost:<PORT>/swagger

Principais rotas<br>
Método	Endpoint	Descrição<br>
GET	/api/clientes	Lista todos os clientes<br>
GET	/api/clientes/{id}	Busca cliente por ID<br>
GET	/api/clientes/por-interesse	Lista clientes por interesse<br>
POST	/api/clientes	Cria um novo cliente<br>
PUT	/api/clientes/{id}	Atualiza um cliente<br>
DELETE	/api/clientes/{id}	Exclui um cliente<br>

<h3>📁 Estrutura do Projeto</h3>

📦 ClienteApi<br>
├── 📁 Controllers<br>
├── 📁 Data<br>
├── 📁 DTOs<br>
├── 📁 Models<br>
│   └── Enums<br>
├── 📁 Services<br>
├── 📄 Program.cs<br>
├── 📄 appsettings.json<br>
└── 📄 ClienteApi.csproj<br>
