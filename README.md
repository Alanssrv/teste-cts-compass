# Teste técnico - CTS Compass
Esse projeto foi desenvolvido como parte do processo seletivo para vaga de Desenvolvedor .NET Jr  na [CTS Compass](https://www.ctscompass.com)

## Sobre o projeto
A solicitação do projeto é o desenvolvimento de um sistema de visualização de uma lista de produtos, o projeto foi solicitado e desenvolvido em três partes:
- **Banco de dados**: Foi solicitada a criação de uma tabela Produtos, com Id, Nome, Preço e Quantidade, e foi solicitada a criação de um script de inserção de três registros com valores pré-determinados no contexto do teste, todo o banco de dados foi utilizando SQL Server
- **Backend**: Criação de uma ASP.NET Core Web API que contém um método de GET que retorna todos os produtos do banco de dados, para a integração com banco de dados foi utilizado o Entity Framework
- **Frontend**: Em Angular, foi solicitado e desenvolvido um portal que integra com o serviço de produtos e com o método de resgate de todos os produtos para visualizá-los, no site foi utilizada componentização separando header, página de listagem de produtos e footer, e para integração foi utilizado o HttpClient disponível no próprio Angular

## Melhorias
O projeto desenvolvido seguiu de acordo com a descriação do teste, mas fica como ponto de melhoria a implementação do CRUD completo para a entidade Produto
- **Backend**: Métodos POST, PUT e DELETE no serviço de produtos
- **Frontend**: Modal de adição e alteração de produtos, ação de remoção de produtos na lista
