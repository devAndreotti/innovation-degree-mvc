<!-- Projeto em Melhoria -->
# 🎲 Innovation Degree
<p align="center">
  <!-- Contador de linguagens do GitHub -->
  <img alt="GitHub language count" src="https://img.shields.io/github/languages/count/devAndreotti/dataform-mvc?color=FFF&labelColor=635184&style=flat-square" >
  <!-- Tamanho do repositório no GitHub -->
  <img alt="GitHub repo size" src="https://img.shields.io/github/repo-size/devAndreotti/dataform-mvc?color=FFF&labelColor=635184&style=flat-square" >
  <!-- Licença do GitHub -->
  <img alt="GitHub License" src="https://img.shields.io/github/license/devAndreotti/devAndreotti?color=FFF&labelColor=635184&style=flat-square" >
</p>

<div align="center">
  <img src="./src/imagens/thor.jpg" alt="Thor Banner" width="250" style="display: block;">
  <img src="./src/imagens/hulk.jpg" alt="Hulk Banner" width="250" style="display: block;">
  <img src="./src/imagens/ultron.jpg" alt="Ultron Banner" width="250" style="display: block;">
</div>

## 💻 Sobre o Projeto
Innovation Degree é uma aplicação web desenvolvida em uma atividade de um curso Técnico em Informática no ano de 2022, com atualizações realizadas em 2024. É construída utilizando a arquitetura MVC (Model-View-Controller) e incorpora funcionalidades de banco de dados usando MySQL.

## ⚙️ Funcionalidades
- [x] Design responsivo para diversos tamanhos de tela
- [x] Sistema básico de registro e login de usuários
- [x] Submissão de conceitos de produtos
- [x] Exibição dinâmica de conteúdo
- [x] Agendamento de compromissos

## ⚠️ Pré-requisitos
Antes de começar, instale e configure as seguintes ferramentas:

- **[.NET SDK 3.1 ou superior](https://dotnet.microsoft.com/download)**: Necessário para desenvolver e executar a aplicação ASP.NET Core MVC.
- **[MySQL Server 8.0 ou superior](https://dev.mysql.com/downloads/mysql/)**: Para gerenciar o banco de dados utilizado pela aplicação.
- **[MySQL Workbench](https://dev.mysql.com/downloads/workbench/)**: Ferramenta gráfica para administração do MySQL.
- **[Git](https://git-scm.com/downloads)** (opcional): Para clonar o repositório e gerenciar o código-fonte. Verifique a instalação com `git --version`.
- **[Visual Studio Code](https://code.visualstudio.com/)** (opcional): Editor de código recomendado. Instale as extensões [C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e [ASP.NET Core](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.blazorwasm-companion).
- **[Navegador Atualizado](https://www.google.com/intl/pt-BR/chrome/)**: Recomendado [Google Chrome](https://www.google.com/intl/pt-BR/chrome/), [Firefox](https://www.mozilla.org/pt-BR/firefox/new/), [Edge](https://www.microsoft.com/pt-br/edge) ou [Safari](https://www.apple.com/safari/) para testar a aplicação.
- Familiaridade com **C#**, **ASP.NET Core MVC**, e **SQL**: Recomendado para um melhor entendimento do projeto.
- **Conexão com a Internet**: Necessária para restaurar pacotes NuGet e acessar outros recursos online.

## 🧭 Como Executar a Aplicação
```bash
# Clone este repositório
$ git clone https://github.com/seu-usuario/innovation-degree-mvc-project.git

# Navegue para o diretório do projeto
$ cd innovation-degree-mvc-project

# Configure o banco de dados
# Abra o MySQL Workbench, crie um novo banco de dados chamado 'destino'
# Importe o script SQL fornecido para configurar as tabelas necessárias

# Atualize a string de conexão
# Modifique os arquivos Models/agendamentoRepository.cs, Models/usuariosRepository.cs e Models/vendaRepository.cs
# Atualize as credenciais do MySQL na string de conexão

# Restaure as dependências
$ dotnet restore

# Inicie a aplicação
$ dotnet run

# Abra um navegador web e acesse
$ https://localhost:5001
```

## 🛠 Tecnologias Utilizadas
- MySQL (com MySQL Workbench)
- ASP.NET Core MVC
- JavaScript
- HTML5
- CSS3
- C#

## 💪 Contribuição
1. Faça um fork do projeto.
2. Crie uma nova branch para sua feature: `git checkout -b feature/nome-feature`.
3. Commit suas mudanças: `git commit -m 'Adiciona nova feature'`.
4. Envie para a branch: `git push origin feature/nome-feature`.
5. Abra um Pull Request.

## 📌 Nota do Projeto
Este projeto foi originalmente desenvolvido como parte de uma atividade educacional e está sob a Licença MIT. Sinta-se à vontade para utilizá-lo e modificá-lo conforme os termos da licença.
