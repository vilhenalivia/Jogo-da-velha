# Jogo-da-velha

<h2>Descrição do Projeto</h2>
Este é um projeto em C# que implementa o clássico Jogo da Velha (Tic-Tac-Toe). Ele permite que dois jogadores humanos interajam e disputem em um tabuleiro 3x3, com regras simples e uma interface interativa no console. O foco do projeto é demonstrar conceitos fundamentais de programação como controle de fluxo, manipulação de arrays, e interações com o usuário.

<h2>Funcionalidades</h2>
<h4>Jogo entre dois jogadores: </h4>
- O jogo é projetado para dois participantes, alternando as jogadas entre eles.<br>
- Os jogadores inserem suas escolhas de posição através de comandos no console.

<h4>Validação de entradas:</h4>
- O sistema valida se a posição escolhida está disponível ou se já foi ocupada.
Apenas entradas válidas são aceitas.

<h4>Verificação automática de vitória:</h4>
-O programa verifica após cada jogada se há uma vitória em linhas, colunas ou diagonais.
Caso contrário, verifica se o jogo terminou em empate.

<h4>Reinício ou encerramento:</h4>
- Após o término do jogo (vitória ou empate), os jogadores têm a opção de reiniciar ou encerrar.


README: Projeto Jogo da Velha
Descrição do Projeto
Este é um projeto em C# que implementa o clássico Jogo da Velha (Tic-Tac-Toe). Ele permite que dois jogadores humanos interajam e disputem em um tabuleiro 3x3, com regras simples e uma interface interativa no console. O foco do projeto é demonstrar conceitos fundamentais de programação como controle de fluxo, manipulação de arrays, e interações com o usuário.

Funcionalidades
Jogo entre dois jogadores:

O jogo é projetado para dois participantes, alternando as jogadas entre eles.
Os jogadores inserem suas escolhas de posição através de comandos no console.
Validação de entradas:

O sistema valida se a posição escolhida está disponível ou se já foi ocupada.
Apenas entradas válidas são aceitas.
Verificação automática de vitória:

O programa verifica após cada jogada se há uma vitória em linhas, colunas ou diagonais.
Caso contrário, verifica se o jogo terminou em empate.
Reinício ou encerramento:

Após o término do jogo (vitória ou empate), os jogadores têm a opção de reiniciar ou encerrar.

<h2>Regras do Jogo</h2>
-O tabuleiro é uma matriz de 3x3.<br>
-Jogadores alternam entre os símbolos X e O.<br>
-Vence o jogador que conseguir alinhar três símbolos consecutivos na horizontal, vertical ou diagonal.<br>
-Caso todas as posições sejam preenchidas sem alinhamento, o jogo termina em empate.

<h2>Estrutura do Projeto</h2>
<h4>1-Arquivo Principal</h4>
-Contém a lógica principal do jogo, incluindo:<br>
  --Exibição do tabuleiro:<br>
  --Leitura das jogadas dos jogadores:<br>
  --alidação das jogadas:<br>
  --Verificação de vitória ou empate:<br>
<h4>Funções Principais</h4>
- ExibirTabuleiro: Atualiza o estado do tabuleiro no console.<br>
- RegistrarJogada: Permite que um jogador escolha uma posição.<br>
- VerificarVitoria: Avalia o tabuleiro para identificar condições de vitória.<br>
- VerificarEmpate: Confirma se todas as posições estão preenchidas sem um vencedor.<br>
<h4>Fluxo do Jogo</h4>
- O jogo segue uma estrutura cíclica:
  --Exibe o tabuleiro.<br>
  --Lê e valida a jogada.<br>
  --Verifica vitória ou empate.<br>
  --Alterna para o próximo jogador até o término.<br>

<h2>Contribuições</h2>
Contribuições são bem-vindas! Caso tenha ideias para melhorias ou correções, siga estas etapas:<br>
-Faça um fork do projeto.<br>
-Crie uma nova branch para suas alterações.<br>
-Envie um pull request com uma descrição detalhada.<br>

<h2>Divirta-se jogando Jogo da Velha com este projeto interativo! 🎮</h2>
