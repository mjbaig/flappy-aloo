using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ScoreKeeper : MonoBehaviour {

    private LogicManager logicManager;
    
    // Start is called before the first frame update
    void Start()
    {
        logicManager = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManager>();
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.layer == 7)
        {
            logicManager.addScore();
        }
    }
}
