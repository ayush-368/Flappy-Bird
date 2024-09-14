using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMoment : MonoBehaviour
{
    //mainSceneUIManager mainSceneUI;

    Rigidbody2D bird;
    public float speed;
    public float jump;

    // Start is called before the first frame update
    void Start()
    {
        bird = GetComponent<Rigidbody2D>();
        speed = 5;
        jump = 5;
    }

    // Update is called once per frame
    void Update()
    {
        bird.velocity = new Vector2(speed, bird.velocity.y);

        if (Input.GetMouseButtonDown(0))
        {
            bird.velocity = new Vector2(bird.velocity.x, jump);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            mainSceneUIManager.Instance.gameOver();
        }
    }
}

    