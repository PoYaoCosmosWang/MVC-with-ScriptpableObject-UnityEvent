using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntEventTrigger : MonoBehaviour
{
    [SerializeField]
    private int id;
    [SerializeField]
    private IntEvent playerDieEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            playerDieEvent.Invoke(id);
        }
    }
}
