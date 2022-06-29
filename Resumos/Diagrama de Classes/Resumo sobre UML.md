<h1>🔗 UML - Unified Modeling Language</h1>
A UML é uma linguagem de modelagem feita para <strong>especificar, visualizar, construir e documentar um sistema</strong>.  <br><br>

Na UML a representação de uma classe usa um retângulo dividido em três partes:<br><br>

 Exemplo                |   Objeto
 --------------------   | ----------------------  |
 Nome da Classe         |   Pessoa
 Atributos da Classe    | dataNacimento: DateTime <br> Nome: string <br> Idade: int <br> Sexo: string
 Métodos da Classe | IdentificarPessoa(); <br> Pessoa();



 Para representar a <strong>visibilidade</strong> dos atributos e comportamentos usamos a seguinte notação: 
<ul>
    <li> - <strong>privada</strong> - a visibilidade ocorre somente dentro da classe</li>
    <li> + <strong>pública</strong> - a visibilidade pode ser obtida em qualquer classe</li>
    <li> # <strong>protegida</strong> - a visibilidade é restrita às subclasses ou classes derivadasa</li>
</ul>