# Códigos Feitos em C# durante a Aula

## Aula 1

Foi estudado a estrutura de um programa em C#, utilização de variáveis e tipos de dados primitivos.

## Aula 2

Foi estudado a entrada de dados pelo teclado, conversão de tipos de dados, operadores aritméticos, operadores de comparação e operadores lógicos.

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

