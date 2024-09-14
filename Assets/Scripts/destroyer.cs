using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    GameObject destroyerObj;

    // Start is called before the first frame update
    void Start()
    {
        destroyerObj = GameObject.Find("destroyer");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < destroyerObj.transform.position.x)
        {
            Destroy(gameObject);
        }    
    }
}
