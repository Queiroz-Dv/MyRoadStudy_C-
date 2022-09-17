<h1 style="color: #FFFAF0"> 💻 Entity Framework Core </h1>

<div>
<fieldset style="border-style: outset">
    <legend  style="color: #00CED1">Introdução</legend>
    <p>O Entity Framework Core é a nova versão do Entity Framework 6.x.
        O EF Core é uma ferramenta ORM (<strong style="color: #00FFFF">Object Relational Mapping</strong>), ele abstrai os objetos <strong> ADO .NET </strong> e os comandos <strong>SQL</strong>
    </p>
</fieldset>
</div><br>

<div>
    <fieldset  style="border-style: outset">
        <legend style="color: #00CED1">ORM e Modelagem de Dados</legend>
        <strong style="color: #00FFFF">ORM</strong> é uma ferramenta para armazenar dados de objetos de domínio para o banco de dados relacional de forma automática e sucinta.
        <h2 style="color: #FFFAF0"> 🧩 Abordagens</h2>
        <ul>
            <li><strong>Code First:</strong></li>
            <p>
                Cria o banco de dados e tabelas usando a <i style="color: #7FFFD4">migração</i> com base nas <i style="color: #7FFFD4">conveções</i> e configuração fornecidas nas classes do seu domínio.
                Essa abordagem é útil no DDD(Domain Driven Design).
            </p>
            <li><strong>Database First:</strong></li>
            <p>
                Cria as classes de domínio e contexto com ase em um banco de dados eistente
                usando os comandos do EF Core.
                Com suporte limitado no EF Core; não suporta designer visual ou assistente.
            </p>
        </ul>
    </fieldset>
</div><br>

<div>
    <fieldset  style="border-style: outset">
        <legend  style="color: #00CED1"> O Modelo de Acesso a Dados</legend>
        <div>
        <p>
            No EF Core, o acesso a dados é executado usando um <i style="color: #7FFFD4">modelo</i>.
        </p>
        <p>
            Um modelo é composto de <i style="color: #7FFFD4">classes de entidade</i> e um <i style="color: #7FFFD4">contexto</i> derivado que representa uma sessão com o banco de dados, permitindo que você pesquise e salve dados.
        </p>
        </div>
        <session>
            <p>Podemos criar um modelo usando as seguintes abordagens:</p>
            <ol>
                <li>
                    Gerar um <i style="color: #7FFFD4">modelo</i> a partir de um <i style="color: #7FFFD4">banco de dados existente</i>;
                </li>
                <li>
                    Codificar manualmente um <i style="color: #7FFFD4">modelo</i> para corresponder ao seu banco de dados;
                </li>
                <li>
                    Usar o <i style="color: #7FFFD4">EF Migrations</i> para criar um banco de dados a partir do seu <i style="color: #7FFFD4">modelo</i><em>(e depois evoluí-lo conforme seu modelo muda ao longo do tempo).</em>
                </li>
            </ol>
        </session>
    </fieldset>
</div>
