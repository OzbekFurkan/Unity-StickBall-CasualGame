using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dondur : MonoBehaviour
{
    bool durum = false;
    float angle;
    public float hiz;
    public bool kontrol = true;
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

       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      
        
        if (!durum&&kontrol)
        {
            transform.Rotate(0, 0, hiz);
            if (angle == Quaternion.Angle(Quaternion.Euler(new Vector3(0, 0, 45)), transform.rotation))
            {
                durum = true;
            }
        }
        if (durum&&kontrol)
        {
            transform.Rotate(0, 0, -hiz);
            if (angle == Quaternion.Angle(Quaternion.Euler(new Vector3(0, 0, -45)), transform.rotation))
            {
                durum = false;
            }
        }
    }
}
