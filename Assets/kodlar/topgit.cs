using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class topgit : MonoBehaviour
{
    public Sprite[] topsprite;
    
    Rigidbody2D fizik;
    public int hiz;
    Collider2D lo;
    public GameObject bcember;
    bool kontrol=false;
    SpriteRenderer rend;
    atis ates;
    buyukcemberrenk bcr;
    GameObject bcrg;
   public int sayi;
    bool durum = false;
    GameObject gerekens;
    AudioSource ads;
    private gereken gerekenler;
    GameObject res;
    bool bostopdur = false;
   public AudioClip uscss;
    dondur dn;
    // Start is called before the first frame update
    void Start()
    {
        dn = GameObject.Find("okalt").GetComponent<dondur>();
        float depth = gameObject.transform.lossyScale.z;
        float width = gameObject.transform.lossyScale.x;
        float height = gameObject.transform.lossyScale.y;

        Vector3 lowerLeftPoint = Camera.main.WorldToScreenPoint(new Vector3(gameObject.transform.position.x - width / 2, gameObject.transform.position.y - height / 2, gameObject.transform.position.z - depth / 2));
        Vector3 upperRightPoint = Camera.main.WorldToScreenPoint(new Vector3(gameObject.transform.position.x + width / 2, gameObject.transform.position.y + height / 2, gameObject.transform.position.z - depth / 2));
        Vector3 upperLeftPoint = Camera.main.WorldToScreenPoint(new Vector3(gameObject.transform.position.x - width / 2, gameObject.transform.position.y + height / 2, gameObject.transform.position.z - depth / 2));
        Vector3 lowerRightPoint = Camera.main.WorldToScreenPoint(new Vector3(gameObject.transform.position.x + width / 2, gameObject.transform.position.y - height / 2, gameObject.transform.position.z - depth / 2));

        float xPixelDistance = Mathf.Abs(lowerLeftPoint.x - upperRightPoint.x);
        float yPixelDistance = Mathf.Abs(lowerLeftPoint.y - upperRightPoint.y);


       
        ates = GameObject.Find("res").GetComponent<atis>();
        fizik = GetComponent<Rigidbody2D>();
        lo = GetComponent<Collider2D>();
        ads = GetComponent<AudioSource>();
        gerekens = GameObject.Find("gerekentophesapla");
        gerekenler = gerekens.GetComponent<gereken>();
        rend = GetComponent<SpriteRenderer>();
        bcrg = GameObject.Find("buyukcember");
        bcr= bcrg.GetComponent<buyukcemberrenk>();
        if (ates.kontrol)
        {
            
            if (ates.renksayi == 0 )
            {
                
                rend.sprite = topsprite [ates.renksayi];
               
            }
            if (ates.renksayi == 1 )
            {
                
                rend.sprite = topsprite[ates.renksayi];
            }
            if (ates.renksayi == 2 )
            {
                
                rend.sprite = topsprite[ates.renksayi];
            }
            if (ates.renksayi == 3 )
            {
                
                rend.sprite = topsprite[ates.renksayi];
            }
            if (ates.renksayi == 4 )
            {
                
                rend.sprite = topsprite[ates.renksayi];
            }
            if (ates.renksayi == 5 )
            {
                rend.sprite = topsprite[ates.renksayi];
            }
          
        }

        StartCoroutine(say());
    }
  
    // Update is called once per frame
    void FixedUpdate()
    {
        
        Vector3 pos = transform.position;
        pos.z = 0;
        transform.position = pos;
        //transform.rotation = bcember.transform.rotation;
        if (!durum)
        {
            fizik.velocity = transform.up * hiz*Time.deltaTime;
        }

       

       
        

    }
    IEnumerator say()
    {
        yield return new WaitForSeconds(1.8f);
        if (!bostopdur)
        {
            Destroy(gameObject);
            gerekenler.bugcoz = 1;
        }
    }
    
    
    IEnumerator OnTriggerEnter2D(Collider2D col)
    {
        if (transform.position.y > -1.2)
        {
            if (col.gameObject.tag == "buyukcember")
            {
                durum = true; ;
                gameObject.transform.SetParent(col.gameObject.transform);
                Destroy(fizik);
                bostopdur = true;
                lo.isTrigger = true;
            }

            if (col.gameObject.tag == "top")
            {
                durum = true; ;
                
                Destroy(fizik);
                bostopdur = true;
          
                lo.isTrigger = true;
                
            }
        }
        if (transform.position.y <= -1.2)
        {
            if (col.gameObject.tag == "top")
            {
                Destroy(col.gameObject);
                Destroy(gameObject);
            }
        }
        if (col.gameObject.tag == "duvar")
        {
            durum = true;
            lo.isTrigger = false;
        }
        if (col.gameObject.tag == "la")
        {
            sayi = 1;
            yield return new WaitForSeconds(0.8f);
            if (sayi == 1 & bostopdur)
            {
                gerekenler.bitiskont = 0;
                
                ates.kactop = 0;
                dn.kontrol = false;
                
               
                GameObject.Find("menu").transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
                GameObject.Find("tryagain").transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
                GameObject.Find("Image (1)").transform.localScale = new Vector3(1.330668f, 1.330668f, 1.330668f);
                GameObject.Find("nextlevel").SetActive(false);
                ates.durum = true;
                ads.PlayOneShot(uscss,0.7f);
                
            }


        }

        if (col.gameObject.tag=="buyukcember"&transform.position.y>-1.2||col.gameObject.tag=="top"&transform.position.y>-1.2)
        {
            
            if (!kontrol)
            {
                if (gerekenler.gerekentop > 0)
                {
                    gerekenler.gerekentop--;
                    kontrol = true;
                }
            }
        }

        if (col.gameObject.tag=="sinir")
        {
            gerekenler.bugcoz = 1;
        }

    }
   
    void OnTriggerExit2D()
    {
        
            sayi = 0;
            
        
    }
    
    
    
}
