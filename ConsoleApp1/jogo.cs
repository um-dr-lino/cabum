public class Jogo{
    //atributos/propriedades

    private Campo campo;
    private List<Jogador> jogadores;

    //operacoes e metodos


    //metodo construtor do jogo
    public Jogo(int largura, int altura){
        this.campo = new Campo(largura, altura, 1, 1);
        this.jogadores = new List<Jogador>();
    }

    //metodo para adicionar jogadores
    public void adicionarJogador(Jogador jog){
        this.jogadores.Add(jog);
    }

    //metodo para desenhar o "jogo" -> (campo e jogadores)
    public void desenhar(){
        //alguma coisa
        this.campo.desenhar();
        foreach(var jog in this.jogadores){
            jog.desenhar();
        }
    }

    public void processarTecla(ConsoleKey tecla){
        //alguma coisa
    }

/*

  // calcula a nova posição do jog1 antes de mover
    int novoX1 = jog1.x;
    int novoY1 = jog1.y;
    string direcao1 = jog1.qualDirecao(tecla.Key);
    if(direcao1 == "c") novoY1--;
    if(direcao1 == "b") novoY1++;
    if(direcao1 == "e") novoX1--;
    if(direcao1 == "d") novoX1++;

    //calcula a posicao do jog2 antes de mover
    int novoX2 = jog2.x;   
    int novoY2 = jog2.y;
    string direcao2 = jog2.qualDirecao(tecla.Key);
    if(direcao2 == "c") novoY2--;
    if(direcao2 == "b") novoY2++;
    if(direcao2 == "e") novoX2--;
    if(direcao2 == "d") novoX2++;


    //edicão 21:19
    if(jog1.PodeResponderTecla(tecla.Key) && campoJogo.podeMover(jog1.x, jog1.y, tecla.Key)){
        //so move se nao colidir com jog2
        if (novoX1 != jog2.x || novoY1 != jog2.y){
            jog1.mover(tecla.Key);
        }
    }

    if(campoJogo.podeMover(jog2.x, jog2.y, tecla.Key)){
        //so move se nao colidir com jog1
        if (novoX2 != jog1.x || novoY2 != jog1.y){
        jog2.mover(tecla.Key);
    }
    }
*/
}