using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "ScriptableObject Events/IntEvent")]
public class IntEvent : ScriptableObject
{
    //argument for the event
    public int integer;
    
    public UnityAction<int> gameEvent;


    public void Invoke(int integer)
    {
        Debug.Log("int:" + integer);
        this.integer = integer;
        gameEvent.Invoke(integer);
    }

}