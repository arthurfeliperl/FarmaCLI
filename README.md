# FarmaCLI 💊

## Problema Resolvido
O esquecimento ou confusão com horários de medicamentos, especialmente comum em idosos ou pessoas com rotinas complexas. O FarmaCLI oferece uma forma simples de registar e consultar estas informações via terminal.

## Público-Alvo
Idosos, doentes crónicos e cuidadores que necessitam de uma lista de consulta rápida.

## Funcionalidades
- Registo de novos medicamentos com o respetivo horário.
- Listagem completa dos medicamentos agendados.
- Interface simples via linha de comando (CLI).

## Tecnologias Utilizadas
- **Linguagem:** C# (.NET 8)
- **Testes:** xUnit
- **CI/CD:** GitHub Actions
- **Versionamento:** Semântico (v1.0.0)

## Como Instalar e Executar
1. Garante que tens o [.NET 8 SDK](https://dotnet.microsoft.com/download) instalado.
2. Clona o repositório: `git clone https://github.com/arthurfeliperl/FarmaCLI/`
3. Entra na pasta do projeto: `cd FarmaCLI/FarmaCLI.App`
4. Executa a aplicação: `dotnet run`

## Testes e Qualidade
Para garantir o funcionamento, podes correr os testes automatizados:
`dotnet test`

Para verificar a padronização do código (Linting):
`dotnet format --verify-no-changes`

## Versão Atual
1.0.0 (MAJOR.MINOR.PATCH)

---
**Autor:** Arthur Felipe Rocha Lara
**Instituição:** CEUB 
