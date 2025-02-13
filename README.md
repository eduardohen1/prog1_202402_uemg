# 📋 Aplicação de Cadastro Simples

Este projeto é um exemplo desenvolvido para a disciplina de Programação I do curso de Sistemas de Informação da UEMG (202402), unidade de Passos. A aplicação, construída em C#, demonstra a criação de uma interface Windows Forms para simular um cadastro simples de pessoas.

## 🛠️ Estrutura do Projeto

A aplicação segue o padrão de arquitetura MVC (Model-View-Controller), organizada da seguinte forma:

- **Formulário Principal**: `FormsCadastro` atua como a tela principal do sistema, com a propriedade MDI habilitada para suportar múltiplas janelas filhas.

- **Controller**: O pacote `controller` contém a classe responsável pela conexão com o banco de dados MySQL, incluindo os tratamentos necessários para conexão e acesso aos dados.

- **Model**: No pacote `model`, encontram-se:
  - `Pessoa`: Modelo que representa uma pessoa, com os atributos `Código` (chave primária), `Nome`, `Email` e `Telefone`.
  - `DadosConexao`: Classe que armazena os parâmetros de conexão com o banco de dados, como Host, Porta, Usuário e Senha.

- **View**: O pacote `views` contém a classe/formulário responsável pelo cadastro de pessoas.

## 🧩 Dependências

A aplicação utiliza o gerenciador de pacotes NuGet para gerenciar suas dependências. A biblioteca de conexão com o MySQL fornecida pela Oracle foi adicionada ao projeto.

## 🚀 Como Executar

1. **Clone o Repositório**:
   ```bash
   git clone https://github.com/eduardohen1/prog1_202402_uemg.git
   ```
2. **Abra o Projeto**: Utilize o Visual Studio para abrir o arquivo `FormsCadastro.sln`.
3. **Restaure as Dependências**: No Gerenciador de Soluções, restaure os pacotes NuGet necessários.
4. **Configure a Conexão com o Banco de Dados**: Atualize os valores na classe `DadosConexao` com as informações do seu servidor MySQL.
5. **Execute a Aplicação**: Compile e execute o projeto para iniciar o formulário de cadastro.

## 📂 Estrutura de Pastas e Arquivos

- `controller/`: Contém a classe de conexão com o banco de dados.
- `model/`: Inclui os modelos `Pessoa` e `DadosConexao`.
- `views/`: Abriga o formulário de cadastro de pessoas.
- `FormsCadastro.sln`: Arquivo de solução do Visual Studio.

Para mais detalhes, acesse o repositório oficial: [https://github.com/eduardohen1/prog1_202402_uemg](https://github.com/eduardohen1/prog1_202402_uemg)

---

*Este projeto é parte do conteúdo didático da disciplina de Programação I da UEMG, unidade de Passos.*
