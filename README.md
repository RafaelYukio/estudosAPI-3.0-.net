# Estudos C#

### Projeto para estudos de C# (.NET)

Criação de API, seguindo padrões e boas práticas. </br>
Padrão feito a partir de vários tutoriais e estruturas que achei interessante. </br>
Baseado nos vídeos:

<details>
<summary>Playlist - Macoratti - Clean Architecture</summary>
https://www.youtube.com/watch?v=ZWfrI5Bu6so&list=PLJ4k1IC8GhW3GICba2dLmiTZrVPw0SthC
</details>
<details>
<summary>Playlist - Amichai Mantinband - REST API following CLEAN ARCHITECTURE & DDD Tutorial</summary>
https://www.youtube.com/watch?v=fhM0V2N1GpY&list=PLzYkqgWkHPKBcDIP5gzLfASkQyTdy0t4k
</details>
<details>
<summary>Playlist - AK Academy - Building Secure APIs with ASP.NET Core using Identity & JWT</summary>
https://www.youtube.com/watch?v=gsx3xCiJJlY&list=PLFJQnCcZXWjuHP03Kgf46FrX5L2fRzDsx
</details>
<details>
<summary>Vídeo - Nick Chapsas - Adding JWT Authentication & Authorization in ASP.NET Core</summary>
https://www.youtube.com/watch?v=mgeuh8k3I4g
</details>
</br>

---

### Histórico branches:

<details>
<summary>1 - Base</summary>
<ul>
  <li>Implementado estrutura base com projetos e pastas;</li>
  <li>Implementado contexts do Identity e Data (Products);</li>
  <li>Migrations iniciais;</li>
  <li>Ordem de progresso:
    <ol>
        <li>Criado projetos e pastas</li>
        <li>Criado context do Identity</li>
        <li>Criado entidades</li>
        <li>Criado context das entidades</li>
        <li>Criado injeção de dependências dos contextos do Identity e Data (entidades)</li>
        <li>Criado mapping para relação 1:1 (Product <-> Description)</li>
        <li>Executado migrations</li>
        <li>Atualizado database</li>
    </ol>
  </li>
</ul> 
</details>

<details>
<summary>1 - Controller (em desenvolvimento)</summary>
<ul>
  <li>Implementado controllers para inserção e retorno de dados</li>
  <li>Ordem de progresso:
    <ol>
        <li>Criado Interfaces de Services e Repositories de Product, Description, Category e Tag</li>
        <li>Criado Classes de Services e Repositories de Product, Description, Category e Tag</li>
        <li>Criado Injeção de Services e Repositories de Product, Description, Category e Tag</li>
        <li>Criado endpoint para Product</li>
        <li>(Inicialmente colocado as classes relacionadas com o Product como nullable para testes)</li>
    </ol>
  </li>
</ul> 
</details>

<details>
<summary>1 - Indentity e JWT (a desenvolver)</summary>
</details>
</br>

---

### Estudos (com links para referência):

<details>
<summary>EF Core - Effectively Decouple The Data And Domain Model</summary>
https://www.c-sharpcorner.com/article/ef-core-effectively-decouple-the-data-and-domain-model/
</details>
<details>
<summary>Clean Architecture</summary>
https://www.c-sharpcorner.com/article/clean-architecture-in-asp-net-core-web-api/#:~:text=What%20is%20Clean%20Architecture,data%20access%20and%20infrastructure%20concerns
</details>
<details>
<summary>Onion vs Clean vs Hexagonal Architecture</summary>
https://medium.com/@edamtoft/onion-vs-clean-vs-hexagonal-architecture-9ad94a27da91
</details>
<details>
<summary>DDD</summary>
https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/ddd-oriented-microservice
</details>
<details>
<summary>DDD x Clean Architecture</summary>
https://softwareengineering.stackexchange.com/questions/405973/difference-between-domain-driven-design-and-clean-architecture
</details>
<details>
<summary>Entity Framework</summary>
https://learn.microsoft.com/en-us/ef/core/
</details>
<details>
<summary>EF Relationships</summary>
https://learn.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key
</details>
<details>
<summary>Dependency Injection</summary>
https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection
</details>
<details>F
<summary>SOLID</summary>
- https://medium.com/beelabacademy/princípios-de-s-o-l-i-d-em-c-guia-prático-cbb1e6584284
- https://www.c-sharpcorner.com/UploadFile/damubetha/solid-principles-in-C-Sharp/
</details>
<details>
<summary>AutoMapper</summary>
https://www.macoratti.net/15/07/net_amap1.htm
</details>
<details>
<summary>MediatR</summary>
https://www.macoratti.net/20/07/aspc_mediatr1.htm
</details>
<details>
<summary>Notification Pattern</summary>
- https://medium.com/tableless/não-lance-exceptions-em-seu-domínio-use-notifications-70b31f7148d3
- https://blog.tiagopariz.com/c-with-patterns-notification/
</details>
<details>
<summary>Observer Pattern</summary>
- https://refactoring.guru/design-patterns/observer/csharp/example#:~:text=Observer%20is%20a%20behavioral%20design,that%20implements%20a%20subscriber%20interface.
- https://learn.microsoft.com/pt-br/dotnet/standard/events/observer-design-pattern
</details>
