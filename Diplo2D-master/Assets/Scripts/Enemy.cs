using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Enemy : MonoBehaviour
{

    public Enemy[] enemyLevels;
    private string jsonString;
    public static Enemy instaceEnemy;
    public string fileNameEnemy;
    private StreamReader sr;
    private StreamWriter sw;
   

    private void Awake()
    {
        instaceEnemy = this;
        enemyLevels = new Enemy[5];

        if (File.Exists(Application.persistentDataPath + "/" + fileNameEnemy))
        {
            sr = new StreamReader(Application.persistentDataPath + "/" + fileNameEnemy);
            jsonString = sr.ReadToEnd();
            sr.Close();
            int level = DataLoader.instance.currentPlayer.lastLevel;
            enemyLevels[level] = JsonUtility.FromJson<Enemy>(jsonString);
        }
        else
        {
            if (DataLoader.instance.currentPlayer.lastLevel == 1)
            {
                enemyLevels[0] = new Enemy();
                StartCoroutine("createBarrel(10,new Vector2(-150,-10))");
            }


            if (DataLoader.instance.currentPlayer.lastLevel == 2)
            {
                enemyLevels[1] = new Enemy();
                StartCoroutine("createBarrel(8,new Vector2(-150,-10))");
            }


            if (DataLoader.instance.currentPlayer.lastLevel == 3)
            {
                enemyLevels[2] = new Enemy();
                StartCoroutine("createBarrel(6,new Vector2(-150,-10))");
            }

            if (DataLoader.instance.currentPlayer.lastLevel == 4)
            {
                enemyLevels[3] = new Enemy();
                StartCoroutine("createBarrel(4,new Vector2(-150,-10))");
            }

            if (DataLoader.instance.currentPlayer.lastLevel == 5)
            {
                enemyLevels[4] = new Enemy();
                StartCoroutine("createBarrel(3,new Vector2(-150,-10))");
            }

            if (DataLoader.instance.currentPlayer.lastLevel == 6)
            {
                enemyLevels[5] = new Enemy();
                StartCoroutine("createBarrel(2,new Vector2(-150,-10))");
            }



        }
    }

    public void WriteData()
    {
        sw = new StreamWriter(Application.persistentDataPath + "/" + fileNameEnemy, false);
        sw.Write(JsonUtility.ToJson(enemyLevels));
        sw.Close();
    }
}



