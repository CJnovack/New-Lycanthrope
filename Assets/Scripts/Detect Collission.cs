using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollission : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Trap"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Hunter"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Arrow"))
        {
            Destroy(other.gameObject);
        }
    }
}
