using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBarrel : MonoBehaviour
{
    public GameObject barrel;
    public Transform barrelPos;
    public Vector2 barrelDirection;
    private GameObject tmpBarrel;

    void Start()
    {
        StartCoroutine("createBarrel");
    }

    IEnumerator createBarrel(int seconds,Vector2 direction)
    {
        tmpBarrel = Instantiate(barrel, barrelPos.position, Quaternion.identity);
        tmpBarrel.GetComponent<Rigidbody2D>().AddForce(direction);
        yield return new WaitForSeconds(seconds);
        StartCoroutine("createBarrel");
    }
}
