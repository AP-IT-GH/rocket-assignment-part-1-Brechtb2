using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject canvasGameover;
    public GameObject mainCanvas;
    private Health healtPlayer;
    public enum GameStates
    {
        Playing,
        GameOver
    }
    public GameStates gameState = GameStates.Playing;
    // Start is called before the first frame update
    void Start()
    {
        if(player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        healtPlayer = player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        //state machine of the game
        switch (gameState)
        {
            case GameStates.Playing:
                if (!healtPlayer.isAlive)
                {
                    gameState = GameStates.GameOver;
                    mainCanvas.SetActive(false);
                    canvasGameover.SetActive(true);
                }
                break;

        }
    }
}
