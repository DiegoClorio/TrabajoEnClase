using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed;
    public TextoPuntaje textObject;
    void Start()
    {
        textObject = FindAnyObjectByType<TextoPuntaje>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left.normalized * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {

        textObject.puntos = textObject.puntos + 1;

        if (collision.gameObject.tag == "Player")
        {

        }
        else
        {

            Destroy(collision.gameObject);
            Destroy(gameObject);

        }

    }
}
