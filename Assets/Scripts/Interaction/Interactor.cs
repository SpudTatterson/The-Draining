using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] KeyCode interactionKey = KeyCode.E;


    [Header("References")]
    Camera cam;

    void Start()
    {
        cam = Camera.main;
    }
    void Update()
    {
        if(Input.GetButtonDown("Fire1") || Input.GetKeyDown(interactionKey))
        {
            RaycastHit2D hit = Physics2D.Raycast(cam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            Interactable interactable =hit.collider.GetComponentInParent<Interactable>();
            if(hit.collider != null && interactable != null)
            {
                if(Physics2D.OverlapCircle(interactable.interactionPoint.position, interactable.GetInteractionDistance()))
                {
                    interactable.Interact(this);
                }
                else
                {
                    // need to get closer 
                    // if movement is point and click then send command to walk towards interactable
                }
            }
        }
    }
}
