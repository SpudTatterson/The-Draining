using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    Camera cam;

    void Start()
    {
        cam = Camera.main;
    }
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            RaycastHit2D hit = Physics2D.Raycast(cam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if(hit.collider != null && hit.collider.GetComponentInParent<Interactable>())
            {
                Debug.Log("interacted");
            }
        }
    }
}
