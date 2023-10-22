using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        if (horizontal != 0 || vertical != 0)
        {
            lastHorizontal = horizontal;
            lastVertical = vertical;
        }
        direction = new Vector3(horizontal, vertical, 0);
        transform.position += direction * speed * Time.deltaTime;

    }
}
