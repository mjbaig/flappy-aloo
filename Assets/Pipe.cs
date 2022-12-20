using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {

    public float moveSpeed = 5;
    
    public float deletePosition = -11;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += Vector3.left * (moveSpeed * Time.deltaTime);

        if (transform.position.x < deletePosition)
        {
            Debug.Log("deleting pipes");
            Destroy(gameObject);
        }
    }
}
