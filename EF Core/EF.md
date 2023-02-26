# 💻 Entity Framework Core

O Entity Framework Core é a nova versão do Entity Framework 6.x.

O EF Core é uma ferramenta ORM (Object Relational Mapping), ele abstrai os objetos ADO .NET e os comandos SQL.

------

## ORM e Modelagem de Dados

**ORM** é uma ferramenta para armazenar dados de objetos de domínio para o banco de dados relacional de forma automática e sucinta.

### 🧩 Abordagens

- *Code First*: Cria o banco de dados e tabelas usando a migração com base nas convenções e configuração fornecidas nas classes do seu domínio. Essa abordagem é útil no DDD(Domain Driven Design).

  

- *Database First*: Cria as classes de domínio e contexto com base em um banco de dados existente usando os comandos do EF Core. Com suporte limitado no EF Core; não suporta designer visual ou assistente.

------

## O modelo de acesso a dados

No EF Core, o acesso a dados é executado usando um **modelo**.

Um modelo é composto de *classe de entidade* e um *contexto* derivado que representa a sessão com o banco de dados, permitindo que você pesquise e salve dados.

Podemos criar um modelo usando as seguintes abordagens:

1. Gerar um **modelo** a partir de um **banco de dados existente**;
2. Codificar manualmente um modelo para corresponder ao banco de dados;
3. Usar o *EF Migrations* para criar um banco de dados a partir do seu modelo

### Passo a passo com Code First

Para implementar a abordagem Code First precisamos definir nossos modelos(ou entidades) com as propriedades que irão compor a classe.

Exemplo de modelo:

```c#
public class Autorizacao
    {
        public int AutorizacaoID { get; set; }

        public int AutorizacaoDia { get; set; }

        public DateTime DataInicial { get; set; }

        public DateTime DataFinal { get; set; }

        public string DescricaoDaAutorizacao { get; set; }
    }
```

Em seguida é definir a classe de contexto como descrito abaixo:

```c#
public class Contexto : DbContext
    {
        public Contexto() : base("GerenciadorEmpresarialConnectionString")
        { }
    
        // Entidades Mapeadas
        public DbSet<Autorizacao> Autorizacoes { get; set; }
    }
```

E por fim, sobrescrever o método  **OnModelCreating** para configurar as entidades e os relacionamentos:

```c#
protected override void OnModelCreating(DbModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);
    modelBuilder.Configurations.AddFromAssembly(typeof(Contexto).Assembly);

    new AutorizacaoBuilder(modelBuilder.Entity<Autorizacao>());
}

public class AutorizacaoBuilder
    {
        public AutorizacaoBuilder(EntityTypeConfiguration<Autorizacao> entity)
        {
            entity.HasKey(autorizacaoId => autorizacaoId.AutorizacaoID);

            entity.Property(p => p.DataInicial).IsRequired();

            entity.Property(p => p.DataFinal).IsRequired();

            entity.Property(p => p.DescricaoDaAutorizacao)
                  .HasMaxLength(200)
                  .IsRequired();

            entity.Property(p => p.AutorizacaoDia)
                  .IsRequired();

            entity.HasMany(departamentos => departamentos.Departamentos) // Uma autorizacao pode ter muitos departamentos
                  .WithRequired(autorizacao => autorizacao.Autorizacao)
                  .HasForeignKey(fk => fk.AutorizacaoId)
                  .WillCascadeOnDelete();
          }
      }
```

------

# 🔃 Relações

> Uma relação define como duas entidades se relacionam entre si.

### Termos usados para relações:

- *Entidade dependente*: É a entidade que contém as propriedades de chave estrangeira.
- *Entidade principal*: É a entidade que contém as propriedades de chave primária.


## 🧭 Propriedades de Navegação

Uma **propriedade de navegação** é definida na **entidade principal ou dependente** que contém uma referência para a entidade relacionada.

```c#
public class Autor 
{
    public int AutorId {get; set;}
    public string Nome {get; set;}
    public string Sobrenome {get; set;}
    public ICollection<Livros> Livros {get; set;} // Propriedade de navegação de Coleção
}
```

```c#
public class Livro 
{
    public int LivroId {get; set;}
    public string Titulo {get; set;}
    public int AnoLancamento {get; set;}
    public Autor Autor {get; set;} // Propriedade de navegação de Referência
}
```



#### Relação um-para-muitos:

```c#
public class Blog // Entidade principal
{
    public int BlogId { get; set; } // Chave Principal
    public string Url { get; set; }

    public List<Post> Posts { get; set; } // Propriedade de navegação de coleção
}

public class Post // Entidade dependente
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int BlogId { get; set; } // Chave estrangeira
    public Blog Blog { get; set; } // Propriedade de navegação por referência
}
```

