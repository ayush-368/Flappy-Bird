using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyGenerator : MonoBehaviour

{
    public GameObject sky;
    public Transform skyGenraterPoint;
    private float width;

    // Start is called before the first frame update
    void Start()
    {
        width = sky.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < skyGenraterPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + width, transform.position.y, transform.position.z);
            //skyGenraterPoint.position = new Vector3(skyGenraterPoint.position.x + width, skyGenraterPoint.position.y, skyGenraterPoint.position.z);
            Instantiate(sky, transform.position, transform.rotation);
        }
    }
}
