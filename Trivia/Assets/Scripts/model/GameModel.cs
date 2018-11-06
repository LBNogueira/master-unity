using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModel : MonoBehaviour {

    public List<ViewUsuario> adversarios;
    public List<ViewPerguntaResposta> perguntas;
    public int idPartida;
    public Partida partidaAtual;
    public ViewUsuario player;

    void Start()
    {
        player.Id = 999;
        player.Nome = "Player";
        player.Pontos = 0;
    }


    
}
