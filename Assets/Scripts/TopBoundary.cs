using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopBoundary : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        other.gameObject.transform.position = new Vector3(other.gameObject.transform.position.x, (other.gameObject.transform.position.y * -1) + 1, 0);
    }
}
