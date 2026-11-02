# Confrontos entre times – Java, C# e Rust

## Identificação da dupla

| Nome completo                | RA             |
|------------------------------|----------------|
| Victor Hugo Pedercine Costa  | 126221444275   |
| Pedro David Vieira           | 126221446360   |

**Disciplina:** _preencher_
**Professor(a):** _preencher_
**Data de entrega:** _preencher_

## Descrição

O programa define diretamente no código a lista de times `Atletico-MG, Cruzeiro, America-Mg, Villa Nova`, separa os nomes pelo delimitador `", "` e gera duas tabelas de confrontos usando laços aninhados:

1. **Tabela 1 – ida e volta:** cada time enfrenta todos os outros (exceto ele mesmo), usando a condição `i != j`. Com 4 times, são 4 × 3 = **12 jogos**.
2. **Tabela 2 – turno único (RF-05):** cada par de times aparece apenas uma vez. A regra é resolvida pelo limite do laço interno, que começa em `j = i + 1`, sem usar nenhuma coleção auxiliar para eliminar duplicatas. Assim, se `Atletico-MG X Cruzeiro` aparece, `Cruzeiro X Atletico-MG` não aparece.
3. **Total de jogos (RF-06):** ao final, o programa exibe o total de confrontos do turno único. Com 4 times, são 4 × 3 / 2 = **6 jogos**.

Não há menus, interface gráfica nem entrada de dados pelo teclado.

Exemplo de saída da Tabela 2:

```
=== Tabela 2: turno unico ===
[1] Atletico-MG X Cruzeiro
[2] Atletico-MG X America-Mg
[3] Atletico-MG X Villa Nova
[4] Cruzeiro X America-Mg
[5] Cruzeiro X Villa Nova
[6] America-Mg X Villa Nova

Total de confrontos no turno unico: 6
```

## Estrutura do projeto

```
.
├── README.md
├── relatorio.md
├── java/
│   └── App.java
├── csharp/
│   ├── Program.cs
│   └── Confrontos.csproj
└── rust/
    ├── Cargo.toml
    └── src/
        └── main.rs
```

> As pastas de compilação e dependências (`bin`, `obj`, `target`) **não** são incluídas na entrega.

## Como executar

### Java

Requisito: JDK 17 ou superior.

```bash
cd java
javac App.java
java App
```

### C#

Requisito: .NET SDK 8.0 ou superior.

```bash
cd csharp
dotnet run
```

### Rust

Requisito: Rust e Cargo (https://rustup.rs).

```bash
cd rust
cargo run
```

## Relatório

As respostas, tabelas e evidências (prints da execução) estão em [`relatorio.md`](relatorio.md).
