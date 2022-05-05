using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    float defaultwidth;
    float defaultheight;
    Vector3 camerapos;
    public bool maintainwidth = true;
    [Range(-1,1)]
    public int adptposition;
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

       
        camerapos = Camera.main.transform.position;
        defaultheight = Camera.main.orthographicSize;
        defaultwidth = Camera.main.orthographicSize * Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        if (maintainwidth)
        {
            Camera.main.orthographicSize = defaultwidth / Camera.main.aspect;
            Camera.main.transform.position = new Vector3(camerapos.x,adptposition*(defaultheight-Camera.main.orthographicSize),camerapos.z);
        }
        else
        {
            Camera.main.transform.position = new Vector3(adptposition*(defaultwidth-Camera.main.orthographicSize*Camera.main.aspect),camerapos.y,camerapos.z);
        }
    }
}
