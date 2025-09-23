using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DragAndDrop : MonoBehaviour
{
    Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Drag()
    {
        print("Dragging" + gameObject.name);
        //GameObject.Find("image").transform.position= Input.mousePosition;
        gameObject.transform.position = Input.mousePosition;

    }

    public void Drop()
    {
        CheckMatch();
    }

    public void CheckMatch()
    {
        //GameObject ph1 = GameObject.Find("PH1");
        //GameObject img = GameObject.Find ("image");
        GameObject img = gameObject;
        string tag = gameObject.tag;
        GameObject ph1 = GameObject.Find("PH" + tag);
        float distance = Vector3.Distance(ph1.transform.position, img.transform.position);
        if(distance <= 50)
        {
            Snap(img, ph1);  
        }
        else
        {
            MoveBack();
        }
        
    }

    public void MoveBack()
    {
        transform.position = originalPosition;
    }

    public void Snap(GameObject img, GameObject ph)
    {
        img.transform.position = ph.transform.position;
    }

    public void InitCardPosition()
    {
        originalPosition = transform.position;
    }
}
