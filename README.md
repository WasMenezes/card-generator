# Gerador de Cartão de Crédito

A API deverá gerar números aleatórios para o pedido de novo cartão. Cada cartão gerado deve estar associado a um email para identificar a pessoa que está utilizando.
Essencialmente são 2 endpoints. Um receberá o email da pessoa e retornará um objeto de resposta com o número do cartão de crédito. E o outro endpoint deverá listar, em ordem de criação, todos os cartões de crédito virtuais de um solicitante (passando seu email como parâmetro).

### Para o desenvolvimento dessa api dividimos nossa aplicação em 3 camadas
![alt text](./images-instructions/1.png "")

**API:**
 Onde ficará o Controller.

**Core:**
Entidades e Interfaces.

**Infrastructure:**
Data e Repositories.

![alt text](./images-instructions/2.jpg "")

Agora iremos permitir o que cada camada poderá enxergar :

![alt text](./images-instructions/4.jpg "")

Clicando como botão direito do mouse encima de cada projeto criado iremos na opção:

**Adicionar => Referência de Projeto...**

![alt text](./images-instructions/5.jpg "")
(Exemplo API)

API poderá ter referências do Core e Infrastructure 
INFRASTRUCTURE poderá ter referências do Core
E o Core não referenciará nenhum outro projeto. 

![alt text](https://miro.medium.com/max/719/1*fATLRr4ZggEa0yjCq-f8Hg.png "Clean Architecture")

Em uma explicação rápida, Entities seriam o equivalente ao nosso Core. Contentendo nossas entidades e interfaces, sem enxergar nada fora isso. 

Usecases seria o nosso infrastructure contendo nossa regra de negócio e enxergando o Entities. 

Controllers seria o nosso API. Contendo os controllers da nosa api, e enxergando tanto o nosso Core quanto nosso Infrastructure.

### Começaremos desenvolvendo nossa entidade Card

![alt text](./images-instructions/3.jpg "")


