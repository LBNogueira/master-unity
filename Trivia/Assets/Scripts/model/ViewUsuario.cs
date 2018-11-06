
[System.Serializable]

public class ViewUsuario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public int Pontos { get; set; }
    /// public int IdClassificacao { get; set; } não necessário
}
