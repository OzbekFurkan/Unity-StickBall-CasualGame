using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class reklamlar : MonoBehaviour
{
    private InterstitialAd interstitial;
    static reklamlar reklamkontrol;
    void Start()
    {
        
        this.request();
    }
    private void request()
    {
        if (reklamkontrol == null)
        {
            DontDestroyOnLoad(gameObject);
            reklamkontrol = this;
#if UNITY_ANDROID
            string appId = "";
#elif UNITY_IPHONE
        string appId = "";
#else
        string appId = "unexpected_platform";
#endif


            MobileAds.Initialize(appId);
            /////////////////////////////////////////////////////////////////////////////////////////////////
#if UNITY_ANDROID
            string adUnitId = "";
#elif UNITY_IPHONE
        string adUnitId = "";
#else
        string adUnitId = "unexpected_platform";
#endif


            this.interstitial = new InterstitialAd(adUnitId);
            this.interstitial.OnAdClosed += interstitialclosed;
            ////////////////////////////////////////////////////////////////////////////////////////////////

            AdRequest request = new AdRequest.Builder().Build();

            this.interstitial.LoadAd(request);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

        }
        else
        {
            Destroy(gameObject);
        }



    }
    private void interstitialclosed(object sender, EventArgs e)
    {
        request();
    }
    public void reklamigoster()
    {

        this.interstitial.Show();

        reklamkontrol = null;

    }
}
