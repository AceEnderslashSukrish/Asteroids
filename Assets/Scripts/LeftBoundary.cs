using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBoundary : MonoBehaviour
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
        float switchVal = Mathf.Abs(other.gameObject.transform.position.x);
        other.gameObject.transform.position = new Vector3(switchVal - 1, other.gameObject.transform.position.y, other.gameObject.transform.position.z);
    }
}
