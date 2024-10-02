<h1>💻 Resumos sobre o Angular</h1>

<div>
  <p>Angula é uma plataforma de aplicações web de código aberto baseado em TypeScript.</p>

  <p>É um framework liderado pelo Google, vem recebendo ajuda de comunidades de desenvolvedores e corporações.</p>
</div>
<hr>

<h2> Realizando o setup de instalação do Angular</h2>

Para utilizarmos o Angular é necessário a instalação do NodeJs e também do NVM para navergamos entre as versões do Node

<hr>

<h2>🤔 Compreendendo Angular</h2>

As principais estruturas do angular são:
<ul>
  <li>Componentes</li>
  <li>Diretivas</li>
  <li>Serviços</li>
  <li>Módulos</li>
</ul>

Abaixo descrevemos melhor sobre essas estruturas.

<h2> 🧩 Componentes </h2>

Uma aplicação Angular é baseada em <b>componentes</b>. Nós podemos encapsular comportamentos e regras da interface, tornando a criação de aplicações algo mais simples. 

Além disso, um componente pode encapsular outros componentes. Eles permitem dividir a UI em partes independentes, reutilizáveis.

Por isso cada parte da aplicação é tratada como um bloco isolado, livre de outras dependências externas.

<h2>🕔 Ciclo de Vida </h2>

No Angular, cada componente tem um ciclo de vida, vários estágios diferentes pelos quais ele passa. Como cada componente é uma classe TS, todos eles devem conter um método construtor.

Alguns desses ciclos são:
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