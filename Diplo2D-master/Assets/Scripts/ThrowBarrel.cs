using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBarrel : MonoBehaviour
{
    public GameObject barrel;
    public Transform barrelPos;
    public Vector2 barrelDirection;
    private GameObject tmpBarrel;
    private Enemy currentEnemy;
    void Start()
    {
        StartCoroutine("createBarrel");
    }

    IEnumerator createBarrel()
    {
        tmpBarrel = Instantiate(barrel, barrelPos.position, Quaternion.identity);
        tmpBarrel.GetComponent<Rigidbody2D>().AddForce(currentEnemy.barrelDirection);
        yield return new WaitForSeconds(currentEnemy.time);
        StartCoroutine("createBarrel");
    }
}
