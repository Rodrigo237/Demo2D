using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public SpriteRenderer enemyRenderer;
    public EnemyDataScriptableObject enemyData;
    // Start is called before the first frame update
    void Start()
    {
        enemyRenderer.sprite = enemyData.enemySprite;
        Debug.Log(enemyData.forceDirection);
        Debug.Log(enemyData.launchTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
