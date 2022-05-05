using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sure : MonoBehaviour
{
    public int zaman;
    public Text zamantext;
    atis ates;
    // Start is called before the first frame update
    void Start()
    {
        ates = GameObject.Find("res").GetComponent<atis>();
        StartCoroutine(say());
    }


    IEnumerator say()
    {
        for (int i=zaman;i>=0;i--)
        {
            yield return new WaitForSeconds(2);
zaman--;
            if (ates.durum)
            {
                break;
            }
                
                
        }
        
       
    }
    IEnumerator bekle()
    { ates.durum = true;
        yield return new WaitForSeconds(2);
       
            GameObject.Find("menu").transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            GameObject.Find("tryagain").transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        GameObject.Find("Image (1)").transform.localScale = new Vector3(1.330668f, 1.330668f, 1.330668f);
        GameObject.Find("nextlevel").SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
 
        zamantext.text = zaman + "";
        if (zaman < 10)
        {
            zamantext.text ="0"+ zaman;
        }
        if (zaman<=0)
        {
            zamantext.text = "0";
            StartCoroutine(bekle());
            
        }
    }
}
