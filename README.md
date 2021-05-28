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

API poderá ter referências do CORE e INFRASTRUCTURE 
INFRASTRUCTURE poderá ter referências do CORE
e o CORE ore não referenciará nenhum outro projeto. 

![alt text](https://koenig-media.raywenderlich.com/uploads/2019/06/Clean-Architecture-graph.png "Clean Architecture")

Em uma explicação rápida, Entities seriam o equivalente ao nosso Core. Contentendo nossas entidades e interfaces, sem enxergar nada fora isso. 

Usecases seria o nosso infrastructure contendo nossa regra de negócio e enxergando o Entities. 

Controllers seria o nosso API. Contendo os controllers da nosa api, e enxergando tanto o nosso Core quanto nosso Infrastructure.

### Começaremos desenvolvendo nossa entidade Card Localizada no CORE 

![alt text](./images-instructions/3.jpg "")

E instalaremos as seguintes dependências na nossa Layer de INFRASTRUCTURE 

![alt text](./images-instructions/6.png "Step 6")

 e a seguinte dependência no API 

![alt text](./images-instructions/7.png "Step 7")


E no SQL Server Object Explorer iremos criar nosso Banco de dados manualmente 

![alt text](./images-instructions/8.png "Step 8")

E iremos rodar nossa query para criar a tabela Card e seus atributos
O script estará disponível na pasta SCRIPTS 

![alt text](./images-instructions/9.png "Step 9")

Após isso executaremos o SCAFFOLD para gerar nosso DBContext

Scaffold-DbContext "Server=(localdb)\MSSQLLocalDB;Database=SocialMedia;Integrated Security = true" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data

Gerando assim nossa base de dados. 
![alt text](./images-instructions/10.png "Step 10")

Agora iremos configurar nosso startup para fazer a conexão com o banco. 
![alt text](./images-instructions/13.png "Step 13")
(app.settings)
![alt text](./images-instructions/14.png "Step 14")




### Para desenvolvermos nosso repositório utilizaremos o conceito de injeção de dependência, como na imagem a seguir  

![alt text](./images-instructions/11.png "Step 11")


## E também o conceito de interface 
![alt text](./images-instructions/15.png "Step 15")


Para que enfim possamos implementar a busca do cartão por email, e a geração de novos cartões de crédito apartir do email
![alt text](./images-instructions/12.png "Step 12")

Criaremos um novo controller e utilizaremos injeções de dependência para fazer a conexão do Repositório com o Controller



![alt text](./images-instructions/16.png "Step 16")

E enfim criando nossos endpoints

![alt text](./images-instructions/17.png "Step 17")



