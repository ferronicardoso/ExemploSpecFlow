@Browser_Chrome
@Browser_Firefox
@Browser_IE
Funcionalidade: Google Search
	Acessar o site de busca do Google e pesquisar por alguns termos

Esquema do Cenário: Pesquisar
	Dado que o usuário acesse o link 'https://google.com'
	E informe o termo '<Termo>' para ser pesquisado
	Quando a tecla Enter for pressionada
	Então o resultado será apresentado na primeira posição com o '<Link>'
	Exemplos: 
	| Termo    | Link                     |
	| SpecFlow | specflow.org             |
	| Gherkin  | cucumber.io/docs/gherkin |
	| Cucumber | cucumber.io              |
	| Selenium | seleniumhq.org           |
