using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class atis : MonoBehaviour
{
    public GameObject top;
    public int kactop;
    public Text kactoptext;
    public bool durum = false;
    public bool kontrol = false;
    public int renksayi;
    public GameObject topburaya;
    gereken re;
    AudioSource ads;
    public AudioClip atses;
    int reklamsayac = 0;
    // Start is called before the first frame update
    private void Start()
    {
        
        re = GameObject.Find("gerekentophesapla").GetComponent<gereken>();
        ads = GetComponent<AudioSource>();
        reklamsayac = PlayerPrefs.GetInt("reklamsayac");
        reklamsayac++;
        PlayerPrefs.SetInt("reklamsayac", reklamsayac);
        if (PlayerPrefs.GetInt("reklamsayac") == 3)
        {
            
            GameObject.FindGameObjectWithTag("reklam").GetComponent<reklamlar>().reklamigoster();
            PlayerPrefs.SetInt("reklamsayac", 0);
        }
        Debug.Log(reklamsayac);
    }
   
    // Update is called once per frame
    void Update()
    {
        
       if (Input.GetButtonDown("Fire1") && !durum)
        {
            Instantiate(top,transform.position,transform.rotation);
            re.bugcoz = 0;
            renksayi = Random.Range(0,5);
            kontrol = true;
            kactop--;
            ads.PlayOneShot(atses,0.7f);
            
            
        }
        if (Input.GetButtonUp("Fire1") && !durum)
        {
            

            kontrol = false;
            
        }
        kactoptext.text = kactop + "";
        if (kactop < 10)
        {
            kactoptext.text = "0" + kactop;
        }
        if (kactop == 0)
        {
            durum = true;
        }
        
        
        
    }
}
