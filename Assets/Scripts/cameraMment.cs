using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMment : MonoBehaviour

{
    public Transform targetPosition;
   


    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = targetPosition.position;
        newPosition.z = -10;
        newPosition.y = 0;

        transform.position = newPosition;
        
    }
}
