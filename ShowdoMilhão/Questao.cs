namespace ShowdoMilhão
{
  public class Questao
  {
    public string Pergunta;
    public string Resposta1;
    public string Resposta2;
    public string Resposta3;
    public string Resposta4;
    public string Resposta5;
    public int RespostaCerta;
    public int Nivel;

    private Label labelPergunta;
    private Button btResposta01;
    private Button btResposta02;
    private Button btResposta03;
    private Button btResposta04;
    private Button btResposta05;

    public Questao ()
    {

    }
    public void Desenhar ()
    {
        labelPergunta.Text= Pergunta;
        btResposta01.Text= Resposta1;
        btResposta02.Text= Resposta2;
        btResposta03.Text= Resposta3;
        btResposta04.Text= Resposta4;
        btResposta05.Text= Resposta5;
    }
    public Questao (Label LP, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05)
    {
        labelPergunta=LP;
        btResposta01= bt01;
        btResposta02= bt02;
        btResposta03= bt03;
        btResposta04= bt04;
        btResposta05= bt05;
    }
     public void ConfiguraDesenho (Label LP, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05)
    {
        labelPergunta=LP;
        btResposta01= bt01;
        btResposta02= bt02;
        btResposta03= bt03;
        btResposta04= bt04;
        btResposta05= bt05;
    }

    public bool VerificaResposta (int RespostaRespondida)
    {
        if (RespostaRespondida == RespostaCerta)
        return true;
        else
        returnf
    }
  }
}