using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeUp : MonoBehaviour
{
    private Character character;
    public GameObject pipeDown;

    // Start is called before the first frame update
    void Start()
    {
        character = FindObjectOfType<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        if (character.transform.position.x - transform.position.x > 30)
        {
            float xRan = Random.Range(0, 10);
            float yRan = Random.Range(-5, 5);
            float gapRan = Random.Range(0, 3);

            Instantiate(gameObject, new Vector2(character.transform.position.x + 30 + xRan, -11 + yRan), transform.rotation);
            Instantiate(pipeDown, new Vector2(character.transform.position.x + 30 + xRan, 12 + gapRan + yRan), transform.rotation);
            Destroy(gameObject);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            character.Death();
        }
    }
}
