
using System.Collections.Generic;


[System.Serializable]

public class ViewPerguntaResposta
{
        public ViewPergunta pergunta { get; set; }
        public List<ViewResposta> respostas { get; set; }
}
