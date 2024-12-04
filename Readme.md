# Códigos Feitos em C# durante a Aula

## Aula 1

Foi estudado a estrutura de um programa em C#, utilização de variáveis e tipos de dados primitivos.

## Aula 2

Foi estudado a entrada de dados pelo teclado, conversão de tipos de dados, operadores aritméticos, operadores de comparação e operadores lógicos.

## Aula 3

Foi estudado a estrutura condicional `if`, `else if`, `else`, 
`Switch Case`  e operador ternário.

## Aula 4

Foi estudado a estrutura de repetição `for`, `while`, `do while` e `foreach`.

## Aula 5

Foi estudado a estrutura de Vetores, como declarar, inicializar e acessar os elementos de um vetor.

## Aula 6

Foi estudado a estrutura de Matrizes, como declarar, inicializar e acessar os elementos de uma matriz.

## Aula 7

Foi estudado de matriz tridimensional, como declarar, inicializar e acessar os elementos de uma matriz tridimensional.

## Aula 8

Foi estudado a estrutura de Funções, como declarar, chamar e retornar valores de uma função. Seus tipos de funções, funções sem retorno, funções com retorno e funções com parâmetros.

## Aula 9

Continuação da função, foi estudado a passagem de parâmetros por referência e por valor.

## Aula 10

Foi estudado Função Recursiva e a diferença entre função recursiva e função iterativa. Além disso, foi estudado a função de retorno de múltiplos valores.
Também foi estudado variaveis implicitas, e o que elas são.
Obs: Variaveis implicitas são variaveis que não precisam ser declaradas com o tipo de dado, pois o compilador consegue inferir o tipo de dado da variavel.

## Aula 11

Introdução de Algoritmos de Ordenação, foi estudado o algoritmo de ordenação como o Bubble Sort, Selection Sort e Insertion Sort.
E quais são as vantagens e desvantagens de cada algoritmo, como o tempo de execução e a quantidade de comparações.

## Aula 12

Continuação de Algoritmos de Ordenação, foi estudado o algoritmo de ordenação como o Merge Sort, Quick Sort.
E quais são as vantagens e desvantagens de cada algoritmo, como o tempo de execução e a quantidade de comparações.

Além disso foi feito o exercicio ordenação de string usando ASCII.


## Aula 13

Foi ensinado a estrutura de Fila, Pilha e Lista Encadeada.
E como implementar essas estruturas de dados em C#.

## Aula 14

Foi ensinado a estrutura de Fila, Pilha e Lista Duplamente Encadeada. E foi feito um exercicio de implementação de uma lista duplamente encadeada.

# Agora irá começar aulas de Orientação a Objetos

## Aula 15

A introdução a Orientação a Objetos, foi estudado o que é uma classe, o que é um objeto, o que é um atributo e o que é um método.


# Explicação da estrutura do projeto

### Entendendo o `Codigo.sln`

O arquivo `.sln` (ou `Codigo.sln` neste caso) é o arquivo de solução do Visual Studio que agrupa vários projetos (`.csproj`) em uma única estrutura. Esse arquivo ajuda a organizar e gerenciar múltiplos projetos, permitindo que todos eles sejam abertos, compilados e depurados juntos. O `.sln` também facilita a configuração de dependências e configurações globais para a solução.

### O que é um GUID

GUID (Globally Unique Identifier) é um identificador único para cada projeto dentro do arquivo de solução. Ele ajuda o Visual Studio a identificar cada projeto de maneira única, evitando conflitos. Cada projeto em uma solução deve ter um GUID único. Esse identificador pode ser gerado automaticamente ou através de ferramentas online, como [GUID Generator](https://www.guidgenerator.com/).

### Estrutura de Declaração de Projetos no `.sln`

Dentro do arquivo `.sln`, cada projeto é adicionado com uma estrutura específica, conforme o exemplo abaixo:

```plaintext
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "Aula_4", "Aula_4\Aula_4.csproj", "{2930212e-8b88-4775-b5fc-4a4fa63ad6d3}"
EndProject
```

- `{9A19103F-16F7-4668-BE54-9A1E7A4F7556}`: Esse é o tipo de projeto, neste caso, representa um projeto C#.
- `"Aula_4"`: Esse é o nome do projeto exibido na solução.
- `"Aula_4\Aula_4.csproj"`: Esse é o caminho relativo para o arquivo `.csproj` do projeto.
- `"{2930212e-8b88-4775-b5fc-4a4fa63ad6d3}"`: Este é o GUID exclusivo para o projeto "Aula_4".

### Instruções para Adicionar Projetos ao Arquivo de Solução

Para garantir que todos os projetos estejam devidamente incluídos na solução e evitar o erro de "Documento fora de qualquer projeto aberto", siga estas etapas:

1. Abra o terminal no diretório raiz do projeto (onde está o arquivo `Codigo.sln`).
2. Execute o comando abaixo para adicionar cada projeto existente à solução:

    ```bash
    dotnet sln Codigo.sln add Aula_2/Aula_2.csproj
    dotnet sln Codigo.sln add Aula_3/Aula_3.csproj
    dotnet sln Codigo.sln add Aula_4/Aula_4.csproj
    ```

Após isso, o arquivo `Codigo.sln` será atualizado automaticamente com a estrutura dos novos projetos.

Caso você precise adicionar os projetos manualmente ao `Codigo.sln`, insira cada projeto seguindo o padrão de estrutura mencionado acima. Lembre-se de gerar um GUID único para cada novo projeto, que pode ser obtido através de ferramentas de geração de GUID.

Após seguir essas etapas, todos os projetos estarão devidamente vinculados na solução, e o IntelliSense deve funcionar corretamente para todos eles.

Se precisar de mais alguma ajuda, não hesite em nos contatar.

