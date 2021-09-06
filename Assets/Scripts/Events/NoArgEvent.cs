using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName ="ScriptableObject Events/NoArgumentEvent")]
public class NoArgEvent : ScriptableObject
{

    public UnityAction gameEvent;
    
    public void Invoke()
    {

        gameEvent.Invoke();
        
    }
    
}