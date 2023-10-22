using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] float interactionDistance = 5f;

    [Header("References")]
    public Transform interactionPoint;

    void Awake()
    {
        if (interactionPoint == null) // if interaction point is missing generate one
        {
            GenerateInteractionPoint();
        }
    }
    public virtual void Interact(Interactor interactor)
    {

    }
    public float GetInteractionDistance()
    {
        return interactionDistance;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0, 1, 0, 0.5f);

        Gizmos.DrawSphere(interactionPoint.position, interactionDistance);
    }

    void GenerateInteractionPoint()
    {
        GameObject interactionPoint = new GameObject("Interaction_Point");
        interactionPoint.transform.position = transform.position;
        interactionPoint.transform.rotation = transform.rotation;
        interactionPoint.transform.parent = transform;
        this.interactionPoint = interactionPoint.transform;
    }
}
