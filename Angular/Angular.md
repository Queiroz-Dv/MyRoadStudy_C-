<h1>💻 Angula 2+</h1>

Angula é uma plataforma de aplicações web de código aberto baseado em TypeScript.

Liderado pelo Google, vem recebendo ajuda de comunidades de desenvolvedores e corporações.

<h2>🤔 Compreendendo Angular</h2>

- Componentes;
- Diretivas;
- Serviços
- Módulos.

Entre outros detalhes.

<h2> 🧩 Componentes </h2>

Uma aplicação Angular é baseada em componentes. Nós podemos encapsular comportamentos e regras da interface, tornando a criação de aplicações algo mais simples. 

Além disso, um componente pode encapsular outros componentes. Componentes permitem dividir a UI em partes independentes, reutilizáveis.

Trata cada parte da aplicação como um bloco isolado, livre de outras dependências externas.

<h2>🕔 Ciclo de Vida </h2>

No Angular, cada componente tem um ciclo de vida, vários estágios diferentes pelos quais ele passa. Como cada componente é uma classe TS, todos eles devem conter um método construtor.

<h3> 1. ngOnInit() </h3>

Este evento é inicializado após o Angular exibir pela primeira vez as propriedades vinculadas aos dados ou quando o componente foi inicializado. 

Este evento é usado principalmente para inicializar dados em um componente.

<h3> 2. ngOnChanges() </h3>

É executado sempre que um valor de um controle de entrada dentro do componente é alterado.

Sempre que um componente recebe um dado através do **@Input()** este método é invocado.

<h3> 3. ngDoCheck() </h3>

Este evento é disparado sempre que as propriedades de entrada de um componente são verificadas.

<h3> 4.ngAfterContentInit() </h3>

É executado quando o Angular realiza qualquer projeção de conteúdo nas visualizações do componente.

<h3> 5. ngAfterContenteChecked() </h3>

É executado sempre que o conteúdo do componente é verificado pelo mecanismo de detecção de alteração do Angular.

<h3> 6. ngAfterViewInit()</h3>

É executado quando a visualização do componente foi totalmente inicializada. 

<h3> 7. ngAfterViewChecked() </h3>

É executado toda vez que a visualização de um determinado componente foi verificada pelo algoritmo de detecção de alterações do Angular.

<h3> 8. ngOnDestroy() </h3>

É executado quando destruir algo, ou propriamente dito um componente.