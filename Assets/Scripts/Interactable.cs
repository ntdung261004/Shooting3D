using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //Add or remove an InteractionEvent component to this gameobject.
    public bool useEvents;
    [SerializeField]
    public string promptMessage;

    public virtual string OnLook()
    {
        return promptMessage;
    }
    public void BaseInteract()
    {
        if(useEvents)
        {
            GetComponent<InteractionEvent>().OnInteract.Invoke(); 
        }
        Interact();
    }
    protected virtual void Interact()
    {

    }
    
}
