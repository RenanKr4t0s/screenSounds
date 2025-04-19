# Screen Sounds 🎵🎸

![catGuitarist](https://media3.giphy.com/media/v1.Y2lkPTc5MGI3NjExMDdkM3NpNndwMWVueW9senRpajY3YzFhMGR6bGYwem1xYzk5c256OCZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/xrZuNcEAmTb6U/giphy.gif)

Bem-vindo ao **Screen Sounds**, minha primeira aplicação em C#! Como desenvolvedor JavaScript (e talvez TypeScript, se você considerar uma linguagem diferente 😅), produto de um feriado, foi uma jornada divertida e cheia de aprendizado. Aqui, explorei conceitos de linguagens fortemente tipadas e descobri como C# pode ser poderoso e, ao mesmo tempo, amigável para inicianteso

## ![C#](https://blog.rocketseat.com.br/content/images/size/w2000/2024/03/C--2.png)

## Sobre o Projeto

O **Screen Sounds** é um aplicativo de console que permite:

- Cadastrar bandas.
- Avaliar bandas com notas.
- Ver a média das notas de cada banda.
- Listar todas as bandas cadastradas.

Tudo isso com um toque de humor e animações simples para deixar a experiência mais divertida! 😄

---

## O que Aprendi

### 1. **Linguagens Fortemente Tipadas**

- Descobri que `Thread.Sleep` é como o `setTimeout` do JavaScript, mas com um nome mais sério. 😅
- Trabalhar com tipos explícitos me fez perceber o quanto isso pode evitar bugs (e me fez sentir mais seguro).

### 2. **Dicionários (Dictionary)**

- Achei incrível como o `Dictionary<string, List<int>>` permite armazenar chaves (nomes das bandas) e valores que são listas (notas das bandas). É como um objeto no JavaScript, mas com superpoderes! 💪

### 3. **Cálculo de Médias**

- O método `.Average()` foi uma surpresa agradável. Ele simplifica o cálculo de médias de uma lista de números, algo que eu costumava fazer manualmente no JavaScript.

---

## Comandos Básicos de C# Explorados

Aqui estão alguns dos comandos e métodos que usei no projeto:

- **`Console.WriteLine()`**: Para exibir mensagens no console.
- **`Console.ReadLine()`**: Para capturar a entrada do usuário.
- **`Thread.Sleep()`**: Para criar pequenas pausas (como um `setTimeout`).
- **`Dictionary<string, List<int>>`**: Para armazenar bandas e suas notas.
- **`List<int>.Add()`**: Para adicionar notas às bandas.
- **`List<int>.Average()`**: Para calcular a média das notas.
- **`foreach`**: Para iterar sobre as bandas cadastradas.
- **`switch`**: Para gerenciar as opções do menu.

---

## Como Rodar o Projeto

1. Certifique-se de ter o .NET SDK instalado.
2. Clone o repositório:
   ```bash
   git clone https://github.com/RenanKr4t0s/screenSounds
   ```
3. Navegue até a pasta do projeto:
   ```bash
   cd screen-sounds
   ```
4. Execute o projeto:
   ```bash
   dotnet run
   ```

---

## Estrutura do Código

O projeto é dividido em funções para facilitar a leitura e manutenção:

- **`MenuEscolha()`**: Exibe o menu principal e gerencia as opções.
- **`AdicionarUmaBanda()`**: Permite cadastrar uma nova banda.
- **`BandasRegistradas()`**: Lista todas as bandas cadastradas.
- **`AvaliarBanda()`**: Permite avaliar uma banda com uma nota.
- **`MediaBanda()`**: Calcula e exibe a média das notas de uma banda.

---

## Conclusão

Essa foi minha primeira aventura com C#, e posso dizer que foi uma experiência incrível! 🚀 Como alguém vindo do mundo do JavaScript, explorar uma linguagem fortemente tipada foi um desafio divertido. Espero que você goste do projeto tanto quanto eu gostei de criá-lo. 😄

Se você também está aprendendo C#, sinta-se à vontade para clonar o repositório, brincar com o código e contribuir!

---

**Feito com ❤️ por um desenvolvedor JavaScript explorando novos horizontes!** 🌟
