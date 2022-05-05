using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyukcemberrenk : MonoBehaviour
{
    public int renksayi;
    SpriteRenderer rend;
    public Sprite[] bcmbrsprt;
    // Start is called before the first frame update
    void Start()
    {
        float depth = gameObject.transform.lossyScale.z;
        float width = gameObject.transform.lossyScale.x;
        float height = gameObject.transform.lossyScale.y;

        Vector3 lowerLeftPoint = Camera.main.WorldToScreenPoint(new Vector3(gameObject.transform.position.x - width / 2, gameObject.transform.position.y - height / 2, gameObject.transform.position.z - depth / 2));
        Vector3 upperRightPoint = Camera.main.WorldToScreenPoint(new Vector3(gameObject.transform.position.x + width / 2, gameObject.transform.position.y + height / 2, gameObject.transform.position.z - depth / 2));
        Vector3 upperLeftPoint = Camera.main.WorldToScreenPoint(new Vector3(gameObject.transform.position.x - width / 2, gameObject.transform.position.y + height / 2, gameObject.transform.position.z - depth / 2));
        Vector3 lowerRightPoint = Camera.main.WorldToScreenPoint(new Vector3(gameObject.transform.position.x + width / 2, gameObject.transform.position.y - height / 2, gameObject.transform.position.z - depth / 2));

        float xPixelDistance = Mathf.Abs(lowerLeftPoint.x - upperRightPoint.x);
        float yPixelDistance = Mathf.Abs(lowerLeftPoint.y - upperRightPoint.y);

       
        rend = GetComponent<SpriteRenderer>();
        renksayi = Random.Range(0, 6);
        if (renksayi == 0)
        {
            rend.sprite = bcmbrsprt[renksayi];
        }
        if (renksayi == 1)
        {
            rend.material.color = Color.blue;
        }
        if (renksayi == 2)
        {
            rend.sprite = bcmbrsprt[renksayi];
        }
        if (renksayi == 3)
        {
            rend.sprite = bcmbrsprt[renksayi];
        }
        if (renksayi == 4)
        {
            rend.sprite = bcmbrsprt[renksayi];
        }
        if (renksayi == 5)
        {
            rend.sprite = bcmbrsprt[renksayi];
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
