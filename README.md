# FarmaCLI 💊

## Problema Resolvido
O esquecimento ou confusão com horários de medicamentos, especialmente comum em idosos ou pessoas com rotinas complexas. O FarmaCLI oferece uma forma simples de registar, consultar e gerir estas informações via terminal.

## Público-Alvo
Idosos, doentes crónicos e cuidadores que necessitam de uma lista de consulta rápida.

## Funcionalidades
- **Registro:** Cadastro de novos medicamentos com o respetivo horário diretamente na nuvem.
- **Listagem:** Consulta em tempo real dos medicamentos agendados no banco de dados.
- **Remoção:** Exclusão de medicamentos da base de dados através do terminal.
- **Interface:** Interface simples e leve via linha de comando (CLI).

## Tecnologias e Stack Utilizadas
- **Linguagem:** C# (.NET 8)
- **Banco de Dados:** PostgreSQL (Hospedado na nuvem via [Neon.tech](https://neon.tech/))
- **Driver de Conexão:** Npgsql
- **Testes:** xUnit
- **CI/CD:** GitHub Actions (Pipeline automatizada para validação de Pull Requests)
- **Versionamento:** Semântico (v1.0.0)

## Como Instalar e Executar
1. Garante que tens o [.NET 8 SDK](https://dotnet.microsoft.com/download) instalado.
2. Clona o repositório: `git clone https://github.com/arthurfeliperl/FarmaCLI/`
3. Entra na pasta do projeto: `cd FarmaCLI/FarmaCLI.App`
4. Executa a aplicação: `dotnet run`

*Nota de Deploy: Por se tratar de uma aplicação CLI (Console), o software é executado localmente no terminal, mantendo uma conexão ativa e segura com o servidor de banco de dados PostgreSQL hospedado na nuvem.*

## Testes e Qualidade
Para garantir o funcionamento e a integridade do ciclo de integração contínua (CI), podes correr os testes automatizados antes de abrir um Pull Request:
`dotnet test`

Para verificar a padronização do código (Linting):
`dotnet format --verify-no-changes`

## Versão Atual
1.0.0 (MAJOR.MINOR.PATCH)

---
## Equipe de Desenvolvimento
* **Arthur Felipe Rocha Lara** -


**Instituição:** Centro Universitário de Brasília – CEUB  
**Curso:** Ciência da Computação
