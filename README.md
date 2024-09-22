# Versão em Português Brasileiro <img src="https://upload.wikimedia.org/wikipedia/commons/0/05/Flag_of_Brazil.svg" alt="Brazil Flag" width="50px">

## Minimal API with .NET/C# and VS Code

Criação de um Minimal API usando .NET/C# com o Visual Studio Code
Aqui estão demonstrados desde a criação do projeto via CLI do .NET.
Utilizei as seguintes tecnologias:

* .NET/C# Minimal API;
* EntityFramework;
* SQL-SERVER Express;

## Ambiente de desenvolvimento

* Visual Studio Code

## Antes de Começar

Precisamos verificar se temos o SDK do .NET está instalado em nossa máquina. E confirmar se esta versão é acima da versão 6.0. Para isto, podemos rodar o comando:

<pre>dotnet --version</pre>

Caso não apareça algo semelhante a isto:

<pre>PS D:\MyCompute\minimal_dotnet_api_with_vsc> dotnet --version
8.0.101</pre>

Você não tem o SDK do .NET instalado. Porém não se preocupe, você pode acessar o site da Microsoft e fazer download do respectivo instalador, [clique aqui](https://dotnet.microsoft.com).

1. Instale o sdk do .NET (dê preferência às versões iniciadas com número pares, pois são versões LTS)

2. Criando o projeto.

Com o SDK instalado, vamos iniciar criar nosso projeto. Abra um terminal do Visual Studio Code (VSCode). Dentro do diretório onde ficará nossa API Mínima, execute o seguinte comando:

<pre>dotnet new web -o &ltnome_do_seu_projeto&gt</pre>

__Explicando o comando:__

* __dotnet:__ comando principal para invocar a CLI do .NET
* __new:__ argumento que indica a intenção de criar um novo projeto ou arquivo
* __web:__ tipo de projeto que será criado. O .NET já fornece um template baseado nesta escolha
* __-o:__ parâmetro para especificar o diretório de saída

Observe o diretório criado. Você deverá encontra o arquivo <code>program.cs</code>. Este arquivo é o <code>entry point</code> da aplicação. Nele é onde estaria o método <code>main</code>. Na verdade, este método ainda existe. Contudo, a partir da versão 6 do .NET, os desenvolvedores resovleram deixá-lo implícito.

3. Executando o projeto:

Depois que você tiver gerado o projeto, entre na pasta dele e execute o seguinte comando:

<pre>dotnet run</pre>

O projeto será compilado e, se tudo estiver correto, serão gerados vários logs de info. Procure pelo log que traz a seguinte mensagem:

<pre>Now listening on: http://localhost:&ltport&gt</pre>

Clique no link ou abra o navegador e digite a url que aparece no respectivo log. _Voilá_, temos uma api develvendo um get em tela. Chegou a hora de criarmos nossas classes de modelo. Podemos optar tanto por bibliotecas de classes e definirmos uma arquitetura em camadas, ou podemos simplesmente adicionar um diretorio e adicionar nossos modelos neste.
Vamos optar pelo uso de uma biblioteca de classes. Para isto, execute o comando abaixo:

<pre>dotnet new classlib -o Modelos</pre>

Depois de criada, vamos referenciar nossa biblioteca de classes na nossa api, executando o seguinte comando:

<pre>dotnet add reference ./&ltnome_da_api&gt/Modelos.csproj</pre>

Podemos alterar a nossa rota <code>app.MapGet("/", () => new SuperheroModel("Batman"));</code>no arquivo <code>program.cs</code> para testar se o referenciamento da biblioteca de classes está correto.

Execute novamente o comando <code>dotnet run</code>. Abra o navegador e verifique se o objeto aparece criado.

Vamos instalar o EntityFramework Core e suas dependências para podermos implementar nosso CRUD.
No terminal (estaremos utilizando o sql-server express), execute os seguintes comandos:

- Para instalar o pacote principal do EF Core:

<pre>dotnet add package Microsoft.EntityFrameworkCore</pre>

- Para instalar o pacote com provedor específico do SQL Server

<pre>dotnet add package Microsoft.EntityFrameworkCore.SqlServer</pre>

- Para realizar migrações e scaffolding

<pre>dotnet add package Microsoft.EntityFrameworkCore.Tools</pre>

- Para componentes em tempo de design

<pre>dotnet add package Microsoft.EntityFrameworkCore.Design</pre>


## English version ![England Flag](https://upload.wikimedia.org/wikipedia/en/thumb/b/be/Flag_of_England.svg/50px-Flag_of_England.svg.png)

## Minimal API with .NET/C# and VS Code

Creating a Minimal API using .NET/C# with Visual Studio Code. The steps are demonstrated starting from project creation via the .NET CLI. I used the following technologies:

* .NET/C# Minimal API;
* EntityFramework;
* SQL-SERVER Express;

## Development Environment

* Visual Studio Code

## Before Starting

We need to check if the .NET SDK is installed on our machine and ensure it is above version 6.0. To do this, we can run the following command:

<pre>dotnet --version</pre>

If it doesn't show something similar to this:

<pre>PS D:\MyCompute\minimal_dotnet_api_with_vsc> dotnet --version
8.0.101</pre>

You don't have the .NET SDK installed. But don't worry, you can visit Microsoft's website and download the installer, [click here](https://dotnet.microsoft.com).

1. Install the .NET SDK (preferably use versions starting with even numbers, as these are LTS versions).

2. Creating the project

With the SDK installed, let's start creating our project. Open a terminal in Visual Studio Code (VSCode). Inside the directory where our Minimal API will reside, run the following command:

<pre>dotnet new web -o &ltyour_project_name&gt</pre>

__Command explanation:__

__dotnet:__ main command to invoke the .NET CLI
__new:__ argument indicating the intention to create a new project or file
__web:__ type of project that will be created. .NET already provides a template based on this choice
__-o:__ parameter to specify the output directory

Observe the created directory. You should find the file <code>program.cs</code>. This file is the <code>entry point</code> of the application. It is where the <code>main</code> method would be. In fact, this method still exists. However, starting from version 6 of .NET, the developers decided to make it implicit.

3. Running the project:
Once you've generated the project, go into its folder and run the following command:

<pre>dotnet run</pre>
The project will be compiled and, if everything is correct, several info logs will be generated. Look for the log that has the following message:

<pre>Now listening on: http://localhost:&ltport&gt</pre>
Click the link or open the browser and type the URL that appears in the respective log. Voilá, we have an API returning a GET on screen. Now it's time to create our model classes. We can either opt for class libraries and define a layered architecture or simply add a directory and place our models there. Let's opt for using a class library. To do this, run the following command:

<pre>dotnet new classlib -o Models</pre>
After creating it, let's reference our class library in our API by running the following command:

<pre>dotnet add reference ./&ltapi_name&gt/Models.csproj</pre>
We can modify our route <code>app.MapGet("/", () => new SuperheroModel("Batman"));</code> in the <code>program.cs</code> file to test if the class library referencing is correct.

Run the command <code>dotnet run</code> again. Open the browser and check if the object is created.

Let's install EntityFramework Core and its dependencies to implement our CRUD. In the terminal (we will be using SQL Server Express), run the following commands:

- To install the main EF Core package

<pre>dotnet add package Microsoft.EntityFrameworkCore</pre>

- To install the package with SQL Server specific provider

<pre>dotnet add package Microsoft.EntityFrameworkCore.SqlServer</pre>

- To perform migrations and scaffolding

<pre>dotnet add package Microsoft.EntityFrameworkCore.Tools</pre>

- For design-time components

<pre>dotnet add package Microsoft.EntityFrameworkCore.Design</pre>
