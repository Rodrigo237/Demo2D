﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class BannerAdd : MonoBehaviour
{
    public string gameID = "123123";
    public string placementId = "DKBanner";
    public bool testMode = true;
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(gameID,testMode);
        StartCoroutine(ShowBanner());
    }

    IEnumerator ShowBanner()
    {
        while(!Advertisement.IsReady(placementId))
        {
            yield return new WaitForSeconds(0.5f);
              Debug.Log("banner waiting");
        }
        Debug.Log("banner ready");
        Advertisement.Show(placementId);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
