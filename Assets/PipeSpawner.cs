using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

    public GameObject pipes;

    private float pipeTimer = 0;

    public float spawnTime = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        pipeTimer += Time.deltaTime;

        if (pipeTimer > spawnTime)
        {
            spawnPipe();
            pipeTimer = 0;
        }

    }

    private void spawnPipe()
    {
        var random = Random.Range(-4, 4);

        var location = new Vector3(
            transform.position.x, 
            transform.position.y + random, 
            transform.position.z);
        
        Instantiate(pipes, location, transform.rotation);
    }
}
 