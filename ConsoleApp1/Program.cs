﻿
// cria o campo e os 2 jogadores. 
//campo retirado do jogo.cs
/*
Campo campoJogo = new Campo(70,20,1,1);
// desenha o campo 
campoJogo.desenhar();
*/

// // cria jogador 1 
// Jogador jog1 = new Jogador(3,3,"#",ConsoleKey.W, ConsoleKey.S, ConsoleKey.A, ConsoleKey.D);

// // cria jogador 2 
// Jogador jog2 = new Jogador(10,10,"&",ConsoleKey.I, ConsoleKey.K, ConsoleKey.J, ConsoleKey.L);

// // desenha o jogador 
// jog1.desenhar();
// jog2.desenhar();

//criação 22:00
//fizemos a criação de jogadores para exemplificar a criação de jogadores no program.cs
Jogo jogoAtual = new Jogo(70,20);
jogoAtual.adicionarJogador( new Jogador(2,2,"#",ConsoleKey.W, ConsoleKey.S, ConsoleKey.A, ConsoleKey.D));
jogoAtual.adicionarJogador( new Jogador(10,10,"&",ConsoleKey.I, ConsoleKey.K, ConsoleKey.J, ConsoleKey.L));
jogoAtual.adicionarJogador( new Jogador(60,18,"#",ConsoleKey.UpArrow, ConsoleKey.DownArrow, ConsoleKey.LeftArrow, ConsoleKey.RightArrow));


jogoAtual.desenhar();
// desliga o cursor 
Console.CursorVisible = false;


    ConsoleKeyInfo tecla;

while(true){
    tecla = Console.ReadKey(true);

    if(tecla.Key == ConsoleKey.Escape) break; 
    jogoAtual.processarTecla(tecla.Key);


    //movido para a classe jogo.cs
    // calcula a nova posição do jog1 antes de mover
    // int novoX1 = jog1.x;
    // int novoY1 = jog1.y;
    // string direcao1 = jog1.qualDirecao(tecla.Key);
    // if(direcao1 == "c") novoY1--;
    // if(direcao1 == "b") novoY1++;
    // if(direcao1 == "e") novoX1--;
    // if(direcao1 == "d") novoX1++;

    // //calcula a posicao do jog2 antes de mover
    // int novoX2 = jog2.x;   
    // int novoY2 = jog2.y;
    // string direcao2 = jog2.qualDirecao(tecla.Key);
    // if(direcao2 == "c") novoY2--;
    // if(direcao2 == "b") novoY2++;
    // if(direcao2 == "e") novoX2--;
    // if(direcao2 == "d") novoX2++;


    // //edicão 21:19
    // if(jog1.PodeResponderTecla(tecla.Key) && campoJogo.podeMover(jog1.x, jog1.y, tecla.Key)){
    //     //so move se nao colidir com jog2
    //     if (novoX1 != jog2.x || novoY1 != jog2.y){
    //         jog1.mover(tecla.Key);
    //     }
    // }

    // if(campoJogo.podeMover(jog2.x, jog2.y, tecla.Key)){
    //     //so move se nao colidir com jog1
    //     if (novoX2 != jog1.x || novoY2 != jog1.y){
    //     jog2.mover(tecla.Key);
    // }
    // }
}
Console.ReadKey();



