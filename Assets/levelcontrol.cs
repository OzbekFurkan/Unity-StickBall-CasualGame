using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelcontrol : MonoBehaviour
{
    gereken grkn;
    atis ats;
    dondur dndr;
    duvhar wallmove;
    duvhar wallmove2;
    int rndmgereken;
    int rndmkactop;
    sure zaman;
    public GameObject timetext;
    int timeornot;
    int wallornot;
    void Start()
    {

       grkn = GameObject.Find("gerekentophesapla").GetComponent<gereken>();
        zaman = GameObject.Find("gerekentophesapla").GetComponent<sure>();
        ats = GameObject.Find("res").GetComponent<atis>();
        dndr = GameObject.Find("okalt").GetComponent<dondur>();
        wallmove = GameObject.Find("duvar").GetComponent<duvhar>();
        wallmove2 = GameObject.Find("duvar2").GetComponent<duvhar>();
        if(PlayerPrefs.GetInt("kayit")==1)
        {
            grkn.gerekentop = 3;
            ats.kactop = 5;
            PlayerPrefs.SetInt("gereken", rndmgereken);
            PlayerPrefs.SetInt("kactop", rndmkactop);
            zaman.enabled = false;
            timetext.SetActive(false);
            PlayerPrefs.SetInt("timeornot", 0);
            wallmove.enabled = false;
            wallmove2.enabled = false;
            PlayerPrefs.SetInt("duvaroynarmi", 0);
        }
        else if (PlayerPrefs.GetInt("bolumgecildi") == 1)
        {

            if (PlayerPrefs.GetInt("kayit") > 1 && PlayerPrefs.GetInt("kayit") < 10)
            {
            git:
                rndmgereken = Random.Range(3, 15);
                rndmkactop = Random.Range(6, 16);
                if (rndmgereken > rndmkactop - 3)
                {
                    goto git;
                }
                else
                {
                    grkn.gerekentop = rndmgereken;
                    ats.kactop = rndmkactop;
                    dndr.hiz = 0.5f;
                    zaman.enabled = false;
                    PlayerPrefs.SetFloat("donenhiz", 0.5f);
                    timetext.SetActive(false);
                    PlayerPrefs.SetInt("timeornot", 0);
                    wallmove.enabled = false;
                    wallmove2.enabled = false;
                    PlayerPrefs.SetInt("duvaroynarmi", 0);
                }

            }

            if (PlayerPrefs.GetInt("kayit") >= 10 && PlayerPrefs.GetInt("kayit") < 20)
            {
            git:
                rndmgereken = Random.Range(7, 15);
                rndmkactop = Random.Range(8, 20);
                if (rndmgereken > rndmkactop - 1)
                {
                    goto git;
                }
                else
                {
                    grkn.gerekentop = rndmgereken;
                    ats.kactop = rndmkactop;
                    dndr.hiz = 0.5f;
                    zaman.enabled = false;
                    PlayerPrefs.SetInt("gereken", rndmgereken);
                    PlayerPrefs.SetInt("kactop", rndmkactop);
                    PlayerPrefs.SetFloat("donenhiz", 0.5f);
                    timetext.SetActive(false);
                    PlayerPrefs.SetInt("timeornot", 0);
                    wallmove.enabled = false;
                    wallmove2.enabled = false;
                    PlayerPrefs.SetInt("duvaroynarmi", 0);
                }

            }

            if (PlayerPrefs.GetInt("kayit") >= 20 && PlayerPrefs.GetInt("kayit") < 30)
            {
            git:
                rndmgereken = Random.Range(10, 23);
                rndmkactop = Random.Range(11, 24);
                if (rndmgereken > rndmkactop - 1)
                {
                    goto git;
                }
                else
                {
                    grkn.gerekentop = rndmgereken;
                    ats.kactop = rndmkactop;
                    dndr.hiz = 0.9f;
                    zaman.enabled = false;
                    PlayerPrefs.SetInt("gereken", rndmgereken);
                    PlayerPrefs.SetInt("kactop", rndmkactop);
                    PlayerPrefs.SetFloat("donenhiz", 0.9f);
                    timetext.SetActive(false);
                    PlayerPrefs.SetInt("timeornot", 0);
                    wallmove.enabled = false;
                    wallmove2.enabled = false;
                    PlayerPrefs.SetInt("duvaroynarmi", 0);
                }

            }

            if (PlayerPrefs.GetInt("kayit") >= 30 && PlayerPrefs.GetInt("kayit") < 40)
            {
            git:
                rndmgereken = Random.Range(10, 20);
                rndmkactop = Random.Range(10, 20);
                var tme = Random.Range(10, 24);
                if (rndmgereken > rndmkactop )
                {
                    goto git;
                }
                else
                {
                    grkn.gerekentop = rndmgereken;
                    ats.kactop = rndmkactop;
                    dndr.hiz = 0.5f;
                    timetext.SetActive(true);
                    zaman.enabled = true;
                    zaman.zaman = tme;
                    PlayerPrefs.SetInt("gereken", rndmgereken);
                    PlayerPrefs.SetInt("kactop", rndmkactop);
                    PlayerPrefs.SetInt("zaman", tme);
                    PlayerPrefs.SetFloat("donenhiz", 0.5f);
                    PlayerPrefs.SetInt("timeornot", 1);
                    wallmove.enabled = false;
                    wallmove2.enabled = false;
                    PlayerPrefs.SetInt("duvaroynarmi", 0);
                }

            }

            if (PlayerPrefs.GetInt("kayit") >= 40 && PlayerPrefs.GetInt("kayit") < 60)
            {
            git:
                rndmgereken = Random.Range(10, 28);
                rndmkactop = Random.Range(10, 28);
                var rndmspeed = Random.Range(0,4);
                var tme = Random.Range(10, 24);
                timeornot = Random.Range(0,3);
                wallornot = Random.Range(0,3);
                if (rndmgereken > rndmkactop)
                {
                    goto git;
                }
                else
                {
                    grkn.gerekentop = rndmgereken;
                    ats.kactop = rndmkactop;
                    
                   if (rndmspeed == 1)
                    {
                        dndr.hiz = 0.9f;
                    }
                   else
                    {
                        dndr.hiz = 0.5f;
                    }
                   

                   
                   if (timeornot == 1)
                    {
                        timetext.SetActive(true);
                        zaman.enabled = true;
                    }
                    else
                    {
                        timetext.SetActive(false);
                        zaman.enabled = false;
                    }
                    zaman.zaman = tme;
                    PlayerPrefs.SetInt("gereken", rndmgereken);
                    PlayerPrefs.SetInt("kactop", rndmkactop);
                    PlayerPrefs.SetInt("zaman", tme);
                    PlayerPrefs.SetFloat("donenhiz", dndr.hiz);
                    PlayerPrefs.SetInt("timeornot",timeornot);
                    if (wallornot == 1)
                    {
                         wallmove.enabled = true;
                    wallmove2.enabled = true;
                    }
                    else
                    {
                        wallmove.enabled = false;
                        wallmove2.enabled = false;
                    }
                   
                    PlayerPrefs.SetInt("duvaroynarmi", wallornot);
                }

            }

            if (PlayerPrefs.GetInt("kayit") >= 60 )
            {
            git:
                rndmgereken = Random.Range(10, 28);
                rndmkactop = Random.Range(10, 28);
                var rndmspeed = Random.Range(0, 2);
                var tme = Random.Range(10, 24);
                timeornot = Random.Range(0, 2);
                wallornot = Random.Range(0, 2);
                if (rndmgereken > rndmkactop)
                {
                    goto git;
                }
                else
                {
                    grkn.gerekentop = rndmgereken;
                    ats.kactop = rndmkactop;

                    if (rndmspeed == 1)
                    {
                        dndr.hiz = 0.9f;
                    }
                    else
                    {
                        dndr.hiz = 0.5f;
                    }



                    if (timeornot == 1)
                    {
                        timetext.SetActive(true);
                        zaman.enabled = true;
                    }
                    else
                    {
                        timetext.SetActive(false);
                        zaman.enabled = false;
                    }
                    zaman.zaman = tme;
                    PlayerPrefs.SetInt("gereken", rndmgereken);
                    PlayerPrefs.SetInt("kactop", rndmkactop);
                    PlayerPrefs.SetInt("zaman", tme);
                    PlayerPrefs.SetFloat("donenhiz", dndr.hiz);
                    PlayerPrefs.SetInt("timeornot", timeornot);
                    if (wallornot == 1)
                    {
                        wallmove.enabled = true;
                        wallmove2.enabled = true;
                    }
                    else
                    {
                        wallmove.enabled = false;
                        wallmove2.enabled = false;
                    }

                    PlayerPrefs.SetInt("duvaroynarmi", wallornot);
                }


            }

           

        }

        else
        {
            grkn.gerekentop = PlayerPrefs.GetInt("gereken");
            ats.kactop = PlayerPrefs.GetInt("kactop");
            dndr.hiz = PlayerPrefs.GetFloat("donenhiz");
            
            if(PlayerPrefs.GetInt("timeornot")==1)
            {
                timetext.SetActive(true);
                zaman.enabled = true;
                zaman.zaman = PlayerPrefs.GetInt("zaman");

            }
            else if (PlayerPrefs.GetInt("timeornot") == 0)
            {
                timetext.SetActive(false);
                zaman.enabled = false;
                zaman.zaman = PlayerPrefs.GetInt("zaman");

            }

            if(PlayerPrefs.GetInt("duvaroynarmi")==1)
            {
                wallmove.enabled = true;
                wallmove2.enabled = true;
            }
            else
            {
                wallmove.enabled = false;
                wallmove2.enabled = false;
            }
        }






    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
