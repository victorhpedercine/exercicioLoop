# Relatório – Confrontos entre times (Java, C# e Rust)

## 1. Identificação da dupla

| Nome completo               | RA           |
|-----------------------------|--------------|
| Victor Hugo Pedercine Costa | 126221444275 |
| Pedro David Vieira          | 126221446360 |

**Disciplina:** _preencher_
**Professor(a):** _preencher_
**Data:** _preencher_

## 2. Objetivo

Desenvolver o mesmo programa em três linguagens (Java, C# e Rust) que, a partir de uma lista de times definida diretamente no código, gera tabelas de confrontos usando laços aninhados.

Times utilizados: **Atletico-MG, Cruzeiro, America-Mg e Villa Nova**.

## 3. Requisitos atendidos

| Requisito | Descrição | Como foi atendido |
|-----------|-----------|-------------------|
| Tabela 1  | Todos contra todos, em ida e volta, sem um time jogar contra ele mesmo | Dois laços de `0` até `times.length` com a condição `i != j` |
| RF-05     | Segunda tabela em turno único, com cada par aparecendo uma única vez | Laço interno começando em `j = i + 1`, sem coleção auxiliar |
| RF-06     | Contar e exibir o total de confrontos do turno único | Variável contadora `totalTurnoUnico`, exibida ao final |

O programa não possui menus, interface gráfica nem entrada de dados pelo teclado.

## 4. Tabelas geradas

### 4.1 Tabela 1 – ida e volta (12 jogos)

| Nº | Confronto                  |
|----|----------------------------|
| 1  | Atletico-MG X Cruzeiro     |
| 2  | Atletico-MG X America-Mg   |
| 3  | Atletico-MG X Villa Nova   |
| 4  | Cruzeiro X Atletico-MG     |
| 5  | Cruzeiro X America-Mg      |
| 6  | Cruzeiro X Villa Nova      |
| 7  | America-Mg X Atletico-MG   |
| 8  | America-Mg X Cruzeiro      |
| 9  | America-Mg X Villa Nova    |
| 10 | Villa Nova X Atletico-MG   |
| 11 | Villa Nova X Cruzeiro      |
| 12 | Villa Nova X America-Mg    |

### 4.2 Tabela 2 – turno único (6 jogos)

| Nº | Confronto                  |
|----|----------------------------|
| 1  | Atletico-MG X Cruzeiro     |
| 2  | Atletico-MG X America-Mg   |
| 3  | Atletico-MG X Villa Nova   |
| 4  | Cruzeiro X America-Mg      |
| 5  | Cruzeiro X Villa Nova      |
| 6  | America-Mg X Villa Nova    |

**Total de confrontos no turno único: 6**

## 5. Respostas e explicações

### 5.1 Como a Tabela 1 evita que um time jogue contra ele mesmo?

Os dois laços percorrem todos os índices da lista. A condição `if (i != j)` descarta os casos em que o índice do primeiro time é igual ao do segundo. Por isso, são gerados 4 × 3 = 12 jogos.

### 5.2 Como a Tabela 2 evita pares repetidos (RF-05)?

O laço interno começa em `j = i + 1`, ou seja, sempre no time seguinte ao do laço externo. Assim, só aparecem pares em que o time de índice menor vem antes do de índice maior. Se `Atletico-MG X Cruzeiro` (0 e 1) foi gerado, `Cruzeiro X Atletico-MG` (1 e 0) nunca será, pois `j` nunca é menor que `i`. Nenhuma lista, conjunto ou outra coleção auxiliar foi usada para eliminar duplicatas.

| `i` (time)        | `j` assume | Jogos gerados |
|-------------------|------------|---------------|
| 0 (Atletico-MG)   | 1, 2, 3    | 3             |
| 1 (Cruzeiro)      | 2, 3       | 2             |
| 2 (America-Mg)    | 3          | 1             |
| 3 (Villa Nova)    | nenhum     | 0             |
| **Total**         |            | **6**         |

### 5.3 Como o total foi contado (RF-06)?

A variável `totalTurnoUnico` começa em 0 e é incrementada a cada confronto gerado. Ela também serve de numeração dos jogos e, ao final, é exibida na tela. O resultado confere com a fórmula n(n−1)/2 para n = 4: 4 × 3 / 2 = 6.

### 5.4 Qual a diferença entre as duas tabelas?

| Característica        | Tabela 1 (ida e volta) | Tabela 2 (turno único) |
|-----------------------|------------------------|------------------------|
| Início do laço interno | `j = 0`               | `j = i + 1`            |
| Condição extra        | `i != j`               | não é necessária       |
| Fórmula               | n(n−1)                 | n(n−1)/2               |
| Total com 4 times     | 12                     | 6                      |

## 6. Código-fonte

O código das três versões está nas pastas do projeto:

| Linguagem | Arquivo(s)                               |
|-----------|------------------------------------------|
| Java      | `java/App.java`                          |
| C#        | `csharp/Program.cs`, `csharp/Confrontos.csproj` |
| Rust      | `rust/src/main.rs`, `rust/Cargo.toml`    |

Trecho principal do turno único (Java):

```java
int totalTurnoUnico = 0;
for (int i = 0; i < times.length; i++) {
    for (int j = i + 1; j < times.length; j++) {
        totalTurnoUnico++;
        System.out.println("[" + totalTurnoUnico + "] " + times[i] + " X " + times[j]);
    }
}
System.out.println("Total de confrontos no turno unico: " + totalTurnoUnico);
```

## 7. Evidências de execução

> Inserir aqui os prints da execução de cada versão, com a saída completa no terminal.

### 7.1 Java

```bash
cd java
javac App.java
java App
```

![Execução em Java](evidencias/java.png)

### 7.2 C#

```bash
cd csharp
dotnet run
```

![Execução em C#](evidencias/csharp.png)

### 7.3 Rust

```bash
cd rust
cargo run
```

![Execução em Rust](evidencias/rust.png)

## 8. Conclusão

As três versões produzem a mesma saída: 12 jogos na tabela de ida e volta e 6 jogos na tabela de turno único. A regra de não repetir pares foi resolvida apenas com o limite do laço interno (`j = i + 1`), sem coleções auxiliares, e a contagem de jogos foi feita com uma variável contadora, conforme RF-05 e RF-06.
