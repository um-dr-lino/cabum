using System.ComponentModel;

public class Campo{

    //atributos ou propriedades 

    private int largura;
    private int altura;
    private int coluna;
    private int linha;

    //metodos ou operações 

    public Campo(int largura, int altura, int coluna, int linha){
        this.largura = largura;
        this.altura = altura;
        this.coluna = coluna;
        this.linha = linha;
    }

    public void desenhar()
    {
        int colIni, colFin, linIni, linFin;
        colIni = this.coluna;
        colFin = this.coluna+this.largura;
        linIni = this.linha;
        linFin = this.linha+this.altura;
        
        for(int x=colIni; x<=colFin; x++)
        {
            //linha superior
            Console.SetCursorPosition(x,linIni);
            Console.Write("-");

            //linha inferior
            Console.SetCursorPosition(x,linFin);
            Console.Write("-");
        }

        //desenhar as linhas verticais
        for( int y=linIni; y<=linFin;y++)
        {
            //linha esquerda
            Console.SetCursorPosition(colIni,y);
            Console.Write("|");

            //linha direira
            Console.SetCursorPosition(colFin,y);
            Console.Write("|");
        }
        
    }
    
    public bool podeMover(int x, int y, ConsoleKey tecla){
        bool pode = true; 

        // verifica o limite superior do campo 
        if (tecla == ConsoleKey.W || tecla == ConsoleKey.UpArrow){
            y--;
            if(y == linha ) pode = false;
        }

        // verifica o limite inferior do campo 
        if(tecla == ConsoleKey.S || tecla == ConsoleKey.DownArrow){
            y++;
            if(y == linha+altura) pode = false;
        }

        // verifica o limite lateral esquerdo do campo 
        if( tecla == ConsoleKey.A || tecla == ConsoleKey.LeftArrow){
            x--;
            if(x == coluna) pode = false;
        }

        // verifica o limite lateral direito do campo 
        if(tecla == ConsoleKey.D || tecla == ConsoleKey.RightArrow){
            x++;
            if(x == coluna+largura) pode = false;
        }

        return pode; 
    }


}