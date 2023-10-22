using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 3;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        if (horizontal != 0 || vertical != 0)
        {
            float lastHorizontal = horizontal;
            float lastVertical = vertical;
        }
        Vector3 direction = new Vector3(horizontal, vertical, 0);
        transform.position += direction * speed * Time.deltaTime;

    }
}
