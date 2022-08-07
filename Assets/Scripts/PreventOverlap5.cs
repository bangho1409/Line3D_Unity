using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreventOverlap5 : MonoBehaviour
{
    
   
        void OnTriggerEnter(Collider col)
        {
            if (col.gameObject.tag == "Ball5")
                Destroy(col.gameObject);
            if (col.gameObject.tag == "Ball2")
                Destroy(gameObject);
            if (col.gameObject.tag == "Ball3")
                Destroy(gameObject);
            if (col.gameObject.tag == "Ball4")
                Destroy(gameObject);
            if (col.gameObject.tag == "Ball")
                Destroy(gameObject);
        }
    private Vector3 screenPoint;
    private Vector3 offset;

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;

    }
}
