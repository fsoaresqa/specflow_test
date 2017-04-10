#language: pt-BR
#encoding: iso-8859-1


Funcionalidade: Pesquisar wiki
Como usuario 
Quero pesquisar por um termo
de modo que obtenha o resultado esperado

Esquema do Cenario: pesquisar wiki
Dado que acesse a pagina <url>
E faça a pesquisa <pesquisa>
Quando acionar o botão
Então resultado é exibido <paginasucesso>
E fechar pagina 

Exemplos: 
|url|pesquisa|paginasucesso|
|"https://pt.wikipedia.org/wiki/Wikip%C3%A9dia:P%C3%A1gina_principal"|"teste"|"Teste"|