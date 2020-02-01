using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class RewardedVideo : MonoBehaviour, IUnityAdsListener
{
    public static RewardedVideo instance;
    public string gameID = "123123";
    public string placementID = "videoID";
    public bool testMode;
    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(gameID,testMode);
        
    }

IEnumerator ShowVideo()
{
     while(!Advertisement.IsReady(placementID))
        {
            yield return new WaitForSeconds(0.5f);
              Debug.Log("video waiting");
        }
        Debug.Log("video ready");
        Advertisement.Show(placementID);
}

    public void IUnityAdsListener(string placementID, ShowResult showResult)
    {
        if(showResult == ShowResult.Finished)
        {

        }else if(showResult == ShowResult.Skipped)
        {

        }else if(showResult == ShowResult.Failed)
        {

        }
    }

    public void OnUnityAdsReady(string placementId)
    {
        if(placementID == placementId)
            Advertisement.Show(placementID);
    }

    public void OnUnityAdsDidError(string message)
    {
        Debug.LogError(message);
    }

    public void OnUnityAdsDidStart(string placementId)
    {

    }
    public void OnUnityAdsDidFinish(string placementId,ShowResult result)
    {
             if(placementID == placementId)
             {
                 if(result == ShowResult.Finished)
                 {
                     DataLoader.instance.currentPlayer.lives++;
                 }
             }
    }

    public void ShowVideoForLIfes()
    {
        StartCoroutine(ShowVideo());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
