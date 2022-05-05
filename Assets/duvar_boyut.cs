using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duvar_boyut : MonoBehaviour
{

    float wid = Screen.width;
    float heit = Screen.height;
    float hesap;
    private void Start()
    {
        hesap = wid / heit;
        Debug.Log(hesap);
        float depth = gameObject.transform.lossyScale.z;
        float width = gameObject.transform.lossyScale.x;
        float height = gameObject.transform.lossyScale.y;

        Vector3 lowerLeftPoint = Camera.main.WorldToScreenPoint(new Vector3(gameObject.transform.position.x - width / 2, gameObject.transform.position.y - height / 2, gameObject.transform.position.z - depth / 2));
        Vector3 upperRightPoint = Camera.main.WorldToScreenPoint(new Vector3(gameObject.transform.position.x + width / 2, gameObject.transform.position.y + height / 2, gameObject.transform.position.z - depth / 2));
        Vector3 upperLeftPoint = Camera.main.WorldToScreenPoint(new Vector3(gameObject.transform.position.x - width / 2, gameObject.transform.position.y + height / 2, gameObject.transform.position.z - depth / 2));
        Vector3 lowerRightPoint = Camera.main.WorldToScreenPoint(new Vector3(gameObject.transform.position.x + width / 2, gameObject.transform.position.y - height / 2, gameObject.transform.position.z - depth / 2));

        float xPixelDistance = Mathf.Abs(lowerLeftPoint.x - upperRightPoint.x);
        float yPixelDistance = Mathf.Abs(lowerLeftPoint.y - upperRightPoint.y);

       
        if (hesap < 0.5f && hesap > 0.45)
        {
            GameObject.Find("kactoptext").transform.Translate(0, -35, 0);
            GameObject.Find("gerekentop").transform.Translate(0, 20, 0);
            GameObject.Find("lvlbg").transform.Translate(0, 45, 0);
            GameObject.Find("levelyazisi").transform.Translate(0, 45, 0);
            GameObject.Find("level").transform.Translate(0, 45, 0);
            GameObject.Find("moneyicon").transform.Translate(0, 45, 0);
            GameObject.Find("money").transform.Translate(0, 45, 0);
            if (transform.position.x > 0)
            {
                transform.Translate(-0.4f, 0, 0);

            }
            else if (transform.position.x < 0)
            {
                transform.Translate(0.4f, 0, 0);
            }

        }
        else if (hesap==0.5)
        {
            GameObject.Find("kactoptext").transform.Translate(0, -22, 0);
            GameObject.Find("gerekentop").transform.Translate(0, 20, 0);
            GameObject.Find("lvlbg").transform.Translate(0, 30, 0);
            GameObject.Find("levelyazisi").transform.Translate(0, 30, 0);
            GameObject.Find("level").transform.Translate(0, 30, 0);
            GameObject.Find("moneyicon").transform.Translate(0, 30, 0);
            GameObject.Find("money").transform.Translate(0, 30, 0);
            if (transform.position.x > 0)
            {
                transform.Translate(-0.3f, 0, 0);

            }
            else if (transform.position.x < 0)
            {
                transform.Translate(0.3f, 0, 0);
            }
        }
        else if (hesap <= 0.45)
        {
            GameObject.Find("buyukcember").transform.localScale = new Vector2(1.3f, 1.3f);
            GameObject.Find("kactoptext").transform.Translate(0, -45, 0);
            GameObject.Find("gerekentop").transform.Translate(0, 30, 0);
            GameObject.Find("lvlbg").transform.Translate(0, 45, 0);
            GameObject.Find("levelyazisi").transform.Translate(0, 45, 0);
            GameObject.Find("level").transform.Translate(0, 45, 0);
            GameObject.Find("moneyicon").transform.Translate(0, 45, 0);
            GameObject.Find("money").transform.Translate(0, 45, 0);
            if (transform.position.x > 0)
            {
                transform.Translate(-0.5f, 0, 0);

            }
            else if (transform.position.x < 0)
            {
                transform.Translate(0.5f, 0, 0);
            }
        }
    }
   

  
}
