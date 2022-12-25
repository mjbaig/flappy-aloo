using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

    public GameObject pipes;

    private float _pipeTimer = 0;

    public float spawnTime = 2;

    public int poolSize = 3;
    
    private Queue<Pipe> _queue = new();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _pipeTimer += Time.deltaTime;

        if (_pipeTimer > spawnTime)
        {
            placePipe();
            _pipeTimer = 0;
        }

    }

    private void placePipe()
    {
        var random = Random.Range(0, 1000) % 7;
        
        var location = new Vector3(
            transform.position.x, 
            transform.position.y + random, 
            transform.position.z);
        
        Instantiate(pipes, location, transform.rotation);
    }
}
 