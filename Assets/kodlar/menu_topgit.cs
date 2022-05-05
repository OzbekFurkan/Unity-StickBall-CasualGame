using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_topgit : MonoBehaviour
{
    int renksayi;
    
    buyukcemberrenk bcr;
    GameObject bcrg;
    SpriteRenderer rend;
    Rigidbody2D fizik;
    public float hiz;
    bool durum = true;
    // Start is called before the first frame update
   void Start()
    {
        renksayi = Random.Range(0, 11);
        bcrg = GameObject.Find("buyukcember");
        bcr = bcrg.GetComponent<buyukcemberrenk>();
        fizik = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
    label:
            if (renksayi == 0 && bcr.renksayi != renksayi)
            {
                rend.material.color = Color.red;
            }
            if (renksayi == 1 && bcr.renksayi != renksayi)
            {
                rend.material.color = Color.blue;
            }
            if (renksayi == 2 && bcr.renksayi != renksayi)
            {
                rend.material.color = Color.cyan;
            }
            if (renksayi == 3 && bcr.renksayi != renksayi)
            {
                rend.material.color = Color.green;
            }
            if (renksayi == 4 && bcr.renksayi != renksayi)
            {
                rend.material.color = Color.magenta;
            }
            if (renksayi == 5 && bcr.renksayi != renksayi)
            {
                rend.material.color = Color.yellow;
            }
            if (renksayi == 6 && bcr.renksayi != renksayi)
            {

                Color background = new Color32(227, 64, 27, 255);
                rend.material.color = background;
            }
            if (renksayi == 7 && bcr.renksayi != renksayi)
            {
                Color background = new Color32(252, 161, 15, 255);
                rend.material.color = background;
            }
            if (renksayi == 8 && bcr.renksayi != renksayi)
            {
                Color background = new Color32(66, 252, 15, 255);
                rend.material.color = background;
            }
            if (renksayi == 9 && bcr.renksayi != renksayi)
            {
                Color background = new Color32(117, 23, 13, 255);
                rend.material.color = background;
            }
            if (renksayi == 10 && bcr.renksayi != renksayi)
            {
                Color background = new Color32(127, 227, 27, 255);
                rend.material.color = background;
            }

            if (bcr.renksayi == renksayi)
            {
                renksayi = Random.Range(0, 10);
                goto label;
            }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (durum)
        {
            //fizik.velocity = transform.up * hiz * Time.deltaTime;
            //  fizik.AddForce(Vector2.up*hiz*Time.deltaTime);
            transform.position += transform.up * hiz * Time.deltaTime;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag=="buyukcember")
        {
            durum = false;
            Destroy(fizik);
        }
    }
}
