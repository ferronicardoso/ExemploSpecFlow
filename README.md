# Exemplo de uso do SpecFlow

Exemplo de uso do Specflow e Selenium para teste automatizado. No caso do exemplo, foi realizado uma simples busca no Google utilizando os navegadores:

- Google Chrome
- Internet Explorer
- Mozilla Firefox

Para isso, foi necessário baixar os drivers correspondentes e salva-los em `C:\Selenium`:

- https://www.seleniumhq.org/download/#thirdPartyDrivers


## SpecFlow

O SpecFlow é um ferramenta open source que possui vários propósitos:

- Documentar o comportamento de um sistema
- Teste automatizado (Pode ser usado em Conjunto com o Selenium)

O SpecFlow utiliza da linguagem Gherkin, linguagem essa que foi introduzido pela Cucumber e que também é utilizada por outras ferramentas.

Gherkin é um conjunto simples de regras gramaticais que torna o texto simples estruturado o suficiente para o SpecFlow entender. Os cenários abaixo estão escritos em Gherkin:

```gherkin
Scenario: Breaker guesses a word
  Given the Maker has chosen a word
  When the Breaker makes a guess
  Then the Maker is asked to score

Cenário: Pesquisar no Google
	Dado que o usuario acesse o site de pesquisa do Google
	E digita o termo 'SpecFlow' para ser pesquisa
	Quando o usuário pressionar 'Enter'
	Então o resultado será exibido na primeiro posição da lista
```

Para realizar uso do SpecFlow e do Selenium em projetos DotNet Core, é necessário seguir alguns passos:

- Instalação da extensão para o Visual Studio e reiniciar a IDE
- Criar um novo projeto do tipo Test Project (No exemplo foi criado xUnit DotNet Core)
- Atualizar o Microsoft .NET Test SDK para versão 15 ou superior
- Incluir as bibliotecas do SpecFlow
	- SpecFlow
	- SpecFlow.Tools.MsBuild.Generation
	- SpecRun.SpecFlow
	- Selenium.WebDriver
	- Selenium.Support

## Referências

https://cucumber.io
https://cucumber.io/docs/gherkin 
https://cucumber.io/docs/gherkin/reference
https://cucumber.io/docs/gherkin/step-organization
https://specflow.org
https://specflow.org/documentation
https://specflow.org/documentation/Using-Gherkin-Language-in-SpecFlow
https://www.seleniumhq.org
https://www.seleniumhq.org/download/#thirdPartyDrivers