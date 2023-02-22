<h1>🎲  O que é Estrutura de Dados?</h1>
**Estrutura de dados** é uma organização de dados na memória ou em qualquer dispositivo de armazenamento.

### 🧩 Tipos de Estruturas
<ul>
<li><strong>Vetores e Matrizes</strong>: são estutura de dados simples que podem auxiliar quando há <i>muitas variáveis do mesmo tipo</i>.
<br><strong>O vetor</strong> é uma estrutura indexada que pode armazenar uma determinada quantidade de valores do mesmo tipo. Já <strong>a matriz</strong> é um vetor que possui duas ou mais dimensões.
</li>
</ul>
**Registros**: é uma estrutura que fornece um formato especializado para armazenar informações em memória. O registro permite armazenar mais de um tipo de dado.

*É composto por campos que especificam cada uma das informações que o compõem*

Toda estrutura de um registro tem um nome, e seus campos podem ser acessados pelo uso do ponto. 
<ul>
	<li>
			<strong>Listas</strong>: armazena dados de um determinado tipo em uma ordem específica. A lista tem <i>tamanho ajustável</i> em quanto arrays possuem tamanho físico.<br><br>
			Além disso existe dois tipos de listas:
    </li>
</ul>
- **Listas Ligada**: neste tipo existem os nós onde cada um dos nós conhece o valor que está armazenado em seu interior. É chamada de lista ligada pelos nós serem amarrados com a indicação de saber qual é o próximo nó.
- **Listas Duplamente Ligada**: neste tipo os nós sabem quem é o próximo elemento e também quem é o elemento anterior, o que permite a navegação reversa.

## Estruturação de um HeapSort

Um algoritmo *heapsort* utiliza o chamado heap binário que ordena os elementos à medida que cada um vai sendo inserido na estrutura.

Na ordenação de um heapsort é preciso garantir que o valor da chave do pai seja maior que a dos filhos.

## Algoritmos Recursivos

### Radix Sort

*RadixSort* é um algoritmo de ordenção não comparativo. A classificação é realiada do dígito menos significativo para o dígito mais significativo.

#### Radix Sort LSD
- Classifica a matriz com base no menor dígito

#### Radix Sort MSD
- Classifica a matriz com base no maior dígito

### Insertion Sort

*Insertion Sort* é um algoritmo de ordenação que percorre as posições do vetor começando pelo seu índice.


## Algoritmos de Pesquisa 

### Pesquisa Linear

O principal objetivo de uma pesquisa linear é retorna uma solução para um dado problema.

- **Pesquisa Sequencial**: em que uma lista é percorrida e cada elemento da lista é verificado.
- **Pesquisa de Intervalo**:  na qual pesquisam estruturas em que são classificadas previamente.

Na pesquisa Linear o vetor é percorrido do ínicio até o final, por conta disso é assumido que os dados não estão ordenados.


### Pesquisa Binária

É um algoritmo que tem como finalidade encontrar um determinado item considerando um vetor de n posições. Nesta estrutura ele vai diminuindo o vetor pelo meio até encontrar o valor desejado.

