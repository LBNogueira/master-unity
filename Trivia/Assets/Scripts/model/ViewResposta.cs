
[System.Serializable]

public class ViewResposta
{
    public int Id { get; set; }
    public bool Correta { get; set; }
    public string Resposta { get; set; }
    public int IdPergunta { get; set; }
}
