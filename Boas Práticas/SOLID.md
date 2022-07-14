<h1>🧱 SOLID Principles</h1>

<p>Os princípios <strong>SOLID</strong> representam cinco princípios de <i>boas práticas na programação</i> que ajudam a escrever códigos mais robustos, com baixo acoplamento, fáceis de estender, testar, reutilizar e de manter.</p>
- A palavra <strong>SOLID</strong> é um acrônimo, criado por <em>Michael Feathers</em>
- Esses princípios foram identificados por <em>Uncle Bob</em>
<div>
<h2>SRP - Single Responsability Principle</h2>
<strong>Princípio da Responsabilidade Única</strong> - Uma classe deve ter um, e somente um, motivo para mudar.
</div><br>
<div align="right">
<h2>OCP - Open/Closed Principle</h2>
<strong>Princípio do Aberto/Fechado</strong> - Você deve ser capaz de estender um comportamento de uma classe sem a necessidade de modificá-lo.
</div><br>
<div>
<h2>LSP - Liskov Substitution Pinciple</h2>
<strong>Princípio da Substituição de Liskov</strong> - As classes derivadas devem ser substituíveis por suas classes bases.
</div><br>
<div align="right">
<h2>ISP - Interface Segregation Principle</h2>
<strong>Princípio da Segregração de Interfaces</strong> - Muitas interfaces específicas são melhores do que uma interface geral.
</div><br>
<h2>Dependecy Inversion Principle</h2>

<strong>Princípio da Inversão da Dependência</strong> - Dependa de abstrações e não de implementações.<br>


<h3>Explicação Detalhada</h3>
- SRP - <strong>S</strong>ingle <strong>R</strong>esponsability <strong>P</strong>rinciple: 
	- Cada classe deve ter apenas um motivo para mudar 
	
	- Cada classe deve ter apenas uma responsabilidade para mudar<br><br>
	
	  
	
- OCP - <strong>O</strong>pen <strong>C</strong>losed <strong>P</strong>rinciple:
	- <strong>Métodos de Extensão</strong>: Métodos estáticos aplicados a um <strong>Tipo</strong> que permitem adicionar uma nova funcionalidade a um tipo de dados existente sem ter que criar um novo <strong>Tipo</strong> derivado.
	
	- Você deve ser capaz de <i>estender</i> um comportamento de uma classe sem a necessidade de alterá-lo.
	
	- Criar novas classes derivadas que devem ser herdadas pela classe base original

	- <i>Estender</i> significa incluir novas funcionalidades sem precisar 'mexer' no que está pronto mantendo a estabilidade do código.
	
	- <i>Alterar</i> é incluir novas funcionalidades 'mexendo' no que está pronto, o que geralmente causa impacto no código.<br>
	
	  
	
- LSP - <strong>L</strong>iskov <strong>S</strong>ubstitution <strong>P</strong>rinciple:
	- Uma <i>classe base</i> deve poder ser substituída pela sua <i>classe derivada</i> sem alteração no comportamento final.
	
	- A instância de uma <strong>classe base</strong> deve possibilitar sua substituição por instâncias de <strong>classes derivadas</strong> sem que se necessite qualquer alteração no código.

	- Uma <strong>classe derivada</strong> deve sobrescrever os métodos da <strong>classe base</strong> de forma que a funcionalidade do ponto de vista do cliente continue a mesma.<br>
	
	  
	
- ISP - <strong>I</strong>nterface <strong>S</strong>egregation <strong>P</strong>rinciple
	- Muitas interfaces específicas são melhores do que uma interface geral.
	
	- Uma interface não deve forçar uma classe a implementar funcionalidades que ela não irá utilizar.
	
	- Interfaces que têm muitos comportamentos se espalham pelo sistema trazendo complexidade e dificuldade de manutenção ao código.
	
	- Como as classes, as interfaces não devem ser genéricas mas ter uma responsabilidade única.<br>
	
	  
	
- DIP - <strong>D</strong>ependency <strong>I</strong>nversion <strong>P</strong>rinciple
	- Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de uma abstração.
	- Abstrações não devem depender de detalhes. Detalhes devem depender de abstrações.
	- O <em>Princípio da Inversão de Dependência</em> procura manter o foco da tarefa de design no negócio, deixando este design independente ou desacoplado do componente que vai executar as tarefas de baixo nível que não fazem parte da modelagem do negócio.