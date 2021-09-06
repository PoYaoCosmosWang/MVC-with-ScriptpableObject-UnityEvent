using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//generic types cannot be instantiated
//[CreateAssetMenu(menuName ="ScriptableObject Events/ScriptableObjectEvent")]
public class ScriptableObjectEvent : ScriptableObject
{

    public UnityAction gameEvent;


    public void Invoke()
    {
        gameEvent.Invoke();
    }

}
//specify the specific type you need in T
public class ScriptableObjectEvent<T> : ScriptableObject
{

    //argument for the event
    public T argument;
    public UnityAction<T> gameEvent;


    public void Invoke(T argument)
    {
        this.argument = argument;
        gameEvent.Invoke(argument);
    }

}
//specify the specific types you need in T and U
public class ScriptableObjectEvent<T,U> : ScriptableObject
{

    //argument for the event
    public T argument1;
    public U argument2;
    public UnityAction<T,U> gameEvent;
    

    public void Invoke(T argument1,U argument2)
    {
        this.argument1 = argument1;
        this.argument2 = argument2;
        gameEvent.Invoke(argument1, argument2);
    }

}