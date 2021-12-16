using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float minX, minY, maxX, maxY;
    private Rigidbody2D rBody;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float rot = Input.GetAxis("Horizontal");
        float push = Input.GetAxis("Vertical");

        if (push > 0)
        {
            Vector2 newVelocity = push * transform.up;
            rBody.velocity = newVelocity + newVelocity * speed;
            rBody.rotation -= rot * speed;
        }
        else if (push == 0)
        {
            Vector2 newVelocity = new Vector2(0, push);
            rBody.velocity = newVelocity * speed;
            rBody.angularVelocity = 0;
            rBody.rotation -= rot * speed;
        }

        //float newX, newY;

        //newX = Mathf.Clamp(rBody.position.x, minX, maxX);
        //newY = Mathf.Clamp(rBody.position.y, minY, maxY);

        //rBody.position = new Vector2(newX, newY);
    }
}
