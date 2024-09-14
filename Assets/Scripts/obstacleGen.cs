using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleGen : MonoBehaviour
{
    public GameObject obstacle;
    public Transform obsGenPoint;

    private float diff;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        diff = Random.Range(6, 10);

        if (transform.position.x < obsGenPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + diff, Random.Range(-5.75f, -1.85f), transform.position.z);
            Instantiate(obstacle, transform.position, transform.rotation);
        }
    }
}
