using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gereken : MonoBehaviour
{
    public int gerekentop;
    public Text gerekentoptext;
    private atis ates;
    public  GameObject ati;
    public bool durum = false;
    topgit tg;
    public GameObject top;
    public int bitiskont = 1;
    public int bugcoz=0;
    public Text money;
    public Text level;
    public int para;
    int dene = 0;
    AudioSource ads;
    public AudioClip scss;
    public AudioClip uscss;
    dondur dn;
    // Start is called before the first frame update
    void Start()
    {
        dn = GameObject.Find("okalt").GetComponent<dondur>();
        if (PlayerPrefs.GetInt("kayit")==0)
        {
            PlayerPrefs.SetInt("kayit", 1);
        }

        ads = GetComponent<AudioSource>();
        money.text = PlayerPrefs.GetInt("para")+"";
        GameObject.Find("Image").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Image (1)").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("menu").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("nextlevel").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("tryagain").transform.localScale = new Vector3(0, 0, 0);
        
        tg =top.GetComponent<topgit>();
        ates = GameObject.Find("res").GetComponent<atis>();
    }
    IEnumerator say()
    {
        yield return new WaitForSeconds(2);
        if (gerekentop>ates.kactop&& bugcoz==1)
        {
            
            

            ates.kactop = 0;
            dn.kontrol = false;
            GameObject.Find("Image (1)").transform.localScale = new Vector3(1.330668f, 1.330668f, 1.330668f);
            GameObject.Find("menu").transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            GameObject.Find("tryagain").transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            GameObject.Find("nextlevel").SetActive(false);

            ates.durum = true;
            ads.PlayOneShot(uscss,0.7f);
        }
        if (ates.kactop == 0 && gerekentop == 0 && bitiskont==1 && tg.sayi!=1 && top.transform.position.y> -0.922)
        {

            dn.kontrol = false;
            ates.kactop = 0;

          
            GameObject.Find("menu").transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            GameObject.Find("nextlevel").transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            GameObject.Find("Image").transform.localScale = new Vector3(1.330668f, 1.330668f, 1.330668f);
            GameObject.Find("tryagain").SetActive(false);
            ates.durum = true;
            ads.PlayOneShot(scss,0.7f);
        }
        
        if (gerekentop == 0)
        {
            dn.kontrol = false;
           

            GameObject.Find("menu").transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);

            GameObject.Find("nextlevel").transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            GameObject.Find("Image").transform.localScale = new Vector3(1.330668f, 1.330668f, 1.330668f);
            GameObject.Find("tryagain").SetActive(false);
            if (dene == 0)
            {
              para+=  PlayerPrefs.GetInt("para")+ates.kactop;
                
                money.text = para + "";
                
            }
            dene = 1;
            ates.durum = true;
            ads.PlayOneShot(scss, 0.7f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        level.text = PlayerPrefs.GetInt("kayit").ToString();
        gerekentoptext.text = gerekentop + "";
        if (gerekentop < 10)
        {
            gerekentoptext.text = "0"+gerekentop ;

        }
        if (gerekentop == 0)
        {
            ates.durum = true;
            StartCoroutine(say());
            
        }
        if (gerekentop > ates.kactop)
        {
            StartCoroutine(say());
           
        }
        if (ates.kactop == 0 && gerekentop == 0 && bitiskont==1)
        {
            StartCoroutine(say());
           
           
        }
        
    }
}
