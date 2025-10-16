# 🛒 WebSales

![.NET](https://img.shields.io/badge/.NET%208.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![ASP.NET MVC](https://img.shields.io/badge/ASP.NET%20MVC-68217A?style=for-the-badge&logo=asp.net&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![Status](https://img.shields.io/badge/Status-Em%20Desenvolvimento-yellow?style=for-the-badge)

---

## 💡 Sobre o Projeto

**WebSales** é uma aplicação web desenvolvida em **.NET 8** com **ASP.NET MVC**, criada para fins **educacionais**.  
O sistema permite o **gerenciamento de vendedores, departamentos e vendas**, oferecendo operações **CRUD completas** e **filtros inteligentes** por departamento e intervalo de datas.

---

## ⚙️ Funcionalidades Principais

✅ CRUD completo de **Vendedores**, **Departamentos** e **Vendas**  
🔎 Filtros de vendas por **Departamento** e **Data**  
💾 Banco de dados local com **SQL Server (LocalDB)**  
📈 Relatórios simples de desempenho  
🌐 Interface responsiva e organizada com **Bootstrap**

---

## 🧩 Tecnologias Utilizadas

| Tecnologia | Função |
|-------------|--------|
| **.NET 8 / ASP.NET Core MVC** | Framework principal da aplicação |
| **C#** | Linguagem de programação |
| **Entity Framework Core** | ORM para manipulação de dados |
| **SQL Server (LocalDB)** | Banco de dados relacional |
| **Bootstrap** | Estilização e layout responsivo |

---

## 🧱 Estrutura do Projeto

WebSales/
├── Controllers/
│ ├── SellersController.cs
│ ├── DepartmentsController.cs
│ └── SalesRecordsController.cs
├── Models/
│ ├── Seller.cs
│ ├── Department.cs
│ ├── SalesRecord.cs
│ └── ViewModels/
├── Data/
│ ├── WebSalesContext.cs
│ └── SeedingService.cs
├── Views/
│ ├── Shared/
│ ├── Sellers/
│ ├── Departments/
│ └── SalesRecords/
└── wwwroot/
├── css/
├── js/
└── lib/

---

## 🧾 Como Executar o Projeto

### 🔧 Pré-requisitos

- [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [SQL Server (LocalDB)](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou **VS Code** com extensão C#

---

### ▶️ Passos para rodar o projeto

1. **Clone o repositório**
   ```bash
   git clone https://github.com/ViniciusCruzSP/WebSales.git

2. **Acesse o diretório do projeto**
```bash
cd WebSales
```
3. **Restaure os pacotes**
```bash
dotnet restore
```

4. **Crie o banco de dados local**
Abra o Package Manager Console no Visual Studio
Selecione o projeto principal (WebSales) como Default Project
Execute:
```powershell
update-database
```
💡 Esse comando aplica a migration inicial e cria o banco de dados LocalDB automaticamente.

5. **Execute o projeto**
```bash
dotnet run
```

🎯 Objetivo Educacional

O WebSales foi desenvolvido com o propósito de estudo e prática de ASP.NET Core MVC, explorando:

Estrutura MVC (Model–View–Controller)

Entity Framework Core (Code First e Migrations)

Injeção de dependência

Razor Pages e Views

Padrões de boas práticas em .NET

👨‍💻 Autor

Vinicius Cruz
📧 [viniciuscruzcosta011@gmail.com]
🌐 [https://www.linkedin.com/in/vinicius-da-cruz-costa/]

📝 Licença
Este projeto é de uso livre para fins educacionais.
Sinta-se à vontade para clonar, modificar e evoluir o código.
