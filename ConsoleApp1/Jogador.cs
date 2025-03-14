public class Jogador {
    // propriedades ou atributos 

    public int x, y;
    private int vidas;
    private string simbolo;
    private ConsoleKey paraCima, paraBaixo, paraEsquerda, paraDireita;

    //metodos ou operações 
    public Jogador(int x, int y, string simbolo,ConsoleKey cma, ConsoleKey bxa, ConsoleKey esq, ConsoleKey dir){
        this.x = x ;
        this.y = y;
        this.simbolo = simbolo;
        this.vidas = 3;
        this.paraCima = cma;
        this.paraBaixo = bxa;
        this.paraEsquerda = esq;
        this.paraDireita = dir;
    }

    //versão antiga, não é mais necessário
    // public void definirTeclas (ConsoleKey cma, ConsoleKey bxa, ConsoleKey esq, ConsoleKey dir){
    //     this.paraCima = cma ;
    //     this.paraBaixo = bxa;
    //     this.paraEsquerda = esq;
    //     this.paraDireita = dir;
    // }

    public void desenhar(){
        Console.SetCursorPosition(this.x, this.y);
        Console.Write(this.simbolo);
    }


    public void apagar(){
        Console.SetCursorPosition(this.x, this.y);
        Console.Write(" ");
    }

    public void mover(ConsoleKey tecla){
        this.apagar();
        if( tecla == this.paraCima) this.y--;
        if( tecla == this.paraBaixo) this.y++;
        if( tecla == this.paraEsquerda) this.x--;
        if( tecla == this.paraDireita) this.x++;
        this.desenhar();
    }

    public bool PodeResponderTecla(ConsoleKey tecla){
        bool podeMover = false;
        // if (tecla == paraCima) podeMover = true;
        // if (tecla == paraBaixo) podeMover = true;   
        // if (tecla == paraEsquerda) podeMover = true;
        // if (tecla == paraDireita) podeMover = true;
        // return podeMover;

        if (tecla == this.paraCima || tecla == this.paraBaixo || tecla == this.paraEsquerda || tecla == this.paraDireita)
           {podeMover = true;}
        return podeMover;
    }

    //20:35 criamos a qual direção para colocar dentro do programa depois
    public string qualDirecao(ConsoleKey tecla){
        string qual = "";
        if (tecla == this.paraCima) qual = "c";
        if (tecla == this.paraBaixo) qual = "b";
        if (tecla == this.paraEsquerda) qual = "e";
        if (tecla == this.paraDireita) qual = "d";
        return qual;
    }
}