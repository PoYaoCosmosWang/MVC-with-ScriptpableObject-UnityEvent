using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DomainEventHandler : MonoBehaviour
{
    //The events that want to listen
    public NoArgEvent gameOverEvent;
    public IntEvent playerDieEvent;
    // Start is called before the first frame update
    
    //register the events
    private void OnEnable()
    {
        playerDieEvent.gameEvent += OnPlayerDie;
        gameOverEvent.gameEvent += OnGameOver;
    }
    //unregister the events
    private void OnDisable()
    {
        playerDieEvent.gameEvent -= OnPlayerDie;
        gameOverEvent.gameEvent -= OnGameOver;
    }
    //when playerDieEvent invokes, this function is called
    public void OnPlayerDie(int id)
    {
        Debug.Log("player die id:" + id);
    }
    //when gameOverEvent invokes, this function is called
    public void OnGameOver()
    {
        print("game over");
    }
}
