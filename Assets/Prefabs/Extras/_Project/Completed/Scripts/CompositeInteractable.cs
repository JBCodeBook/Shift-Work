using System.Collections.Generic;
using UnityEngine;

public class CompositeInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private List<GameObject> interactables;

    public void interact()
    {
        print("Interact");
        foreach (var go in interactables)
        {
            var interactable = go.GetComponent<IInteractable>();
            interactable?.interact();
        }
    }
}