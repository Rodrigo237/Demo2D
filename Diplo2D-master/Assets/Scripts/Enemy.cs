using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject[] enemyLevels;
    // Start is called before the first frame update
    void Start()
    {
        enemyLevels = new GameObject[5];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
