using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour
{
    private Transform transf;
    public float maxScale;
    public float minSscale;
    public float shrinkSpeed;
    private float targetScale;
    private Vector3 vScale;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit;

        if (Input.GetMouseButtonDown (1))
        {


            edewdwdfw  
            hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if(hit.transform != null)
            {
                Debug.Log("player diminuindo");
                transf = hit.transform;
                targetScale = minSscale;
                vScale = new Vector2(targetScale, targetScale);
            }
            else
            {
                Debug.Log("nao encontrou o obj 1 ");
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);
            if (hit.transform == transform)
            {
                Debug.Log("player aumentando");
                transf = hit.transform;
                targetScale = maxScale;
                vScale = new Vector2(targetScale, targetScale);
            }
            else
            {
                Debug.Log("nao encontrou o obj ");
            }
        }

        if(transf != null)
        {
            transf.localScale = Vector3.Lerp(transf.localScale, vScale, Time.deltaTime * shrinkSpeed);
        }
        
    }

}
