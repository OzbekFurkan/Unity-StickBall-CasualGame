using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duvhar : MonoBehaviour
{
    
    bool durum = false;
    dondur dn;
    // Start is called before the first frame update
    void Start()
    {
        dn = GameObject.Find("okalt").GetComponent<dondur>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dn.kontrol)
        {

            if (!durum)
            {
                transform.Translate(Vector2.up * Time.deltaTime * 2);
                if (transform.position.y >= 2)
                {
                    durum = true;
                    Debug.Log("dfdffdfd");
                }
            }

            if (durum)
            {
                transform.Translate(Vector2.down * Time.deltaTime * 2);
                if (transform.position.y <= 0.5)
                {
                    durum = false;
                }
            }
        }
    }
}
