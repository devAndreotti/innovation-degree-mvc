<!-- Projeto Finalizado -->
# 🎓 Aplicação Web MVC - Grau de Inovação
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

## 📝 Visão Geral
Grau de Inovação é uma aplicação web desenvolvida como parte de um curso técnico em Informática para Internet em 2022, com atualizações realizadas em 2024. É construída utilizando a arquitetura MVC (Model-View-Controller) e incorpora funcionalidades de banco de dados usando MySQL.

## ⚙️ Funcionalidades
- Sistema de registro e login de usuários
- Agendamento de compromissos
- Submissão de conceitos de produtos
- Exibição dinâmica de conteúdo
- Design responsivo para diversos tamanhos de tela

## 🛠 Tecnologias Utilizadas
- ASP.NET Core MVC
- C#
- MySQL (com MySQL Workbench)
- HTML5
- CSS3
- JavaScript

## 🚀 Como Executar

1. **Pré-requisitos:**
   - Instalar o .NET Core SDK
   - Instalar MySQL e MySQL Workbench

2. **Configuração do Banco de Dados:**
   - Abra o MySQL Workbench
   - Crie um novo banco de dados chamado `destino`
   - Importe o script SQL fornecido para configurar as tabelas necessárias

3. **Configuração do Projeto:**
   - Clone o repositório
   - Navegue até o diretório do projeto
   - Atualize a string de conexão em `Models/agendamentoRepository.cs`, `Models/usuariosRepository.cs` e `Models/vendaRepository.cs` com suas credenciais do MySQL

4. **Execute a Aplicação:**
   - Abra um terminal no diretório do projeto
   - Execute `dotnet restore` para instalar as dependências
   - Execute `dotnet run` para iniciar a aplicação
   - Abra um navegador web e navegue até `https://localhost:5001`

## 💪 Contribuição
Contribuições para melhorar o projeto são bem-vindas. Siga estes passos:
1. Faça um fork do repositório
2. Crie uma nova branch (`git checkout -b feature/AmazingFeature`)
3. Comite suas alterações (`git commit -m 'Add some AmazingFeature'`)
4. Faça um push para a branch (`git push origin feature/AmazingFeature`)
5. Abra um Pull Request

## 📌 Nota do Projeto
Este projeto foi inicialmente desenvolvido como parte de um programa educacional e foi atualizado para fins de aprendizado. Ele demonstra conceitos básicos de desenvolvimento web usando ASP.NET Core MVC e integração com banco de dados.
