# Jogo de Adivinhação

![](https://imgur.com/iylqf6z.gif)

## Projeto

Desenvolvido durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net) 2025

---
## Detalhes

Ao iniciar o jogo, temos três opções para jogar: o modo Fácil, Médio e Difícil, onde
cada um deles acompanha uma quantidade de tentativas que o usuário tem para jogar:
- facil:   10 tentativas 
- medio:    5 tentativas 
- dificil:  3 tentativas 

---
## Entrada

Os jogadores interagem com o console. Nessa interação, eles digitam um número e o sistema já retorna a mensagem correspondente ao 
feedback do número escolhido pelo jogador. Caso ele acerte, haverá uma mensagem dizendo que ele ganhou. Caso o
jogador erre, ele pode continuar a jogar, desde que esteja alinhado com o número de tentativas escolhidas de acordo com a
dificuldade.

---
## Funcionalidades

- **Geração de Número Secreto:** No início de cada jogo, um número secreto é gerado aleatoriamente entre 1 e 20.
- **Seleção de Dificuldade:** Os jogadores podem escolher entre três níveis de dificuldade (Fácil, Médio, Difícil), que influenciam o número de tentativas disponíveis.
- **Feedback Instantâneo:** Após cada tentativa, o jogo fornece feedback indicando se o número escolhido é maior ou menor que o número secreto.
---
## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
---
## Como Usar

#### Clone o Repositório
```
https://github.com/LeandroJader/jogo_de_adivinhacao_2025
```

#### Navegue até a pasta raiz da solução
```
cd jogo-de-adivinhacao-2025
```

#### Restaure as dependências
```
dotnet restore
```

#### Navegue até a pasta do projeto
```
cd JogoDaAdivinhacao.ConsoleApp
```

#### Execute o projeto
```
dotnet run
```