using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(Random.Range(0, 55), Random.Range(35,45), 0);
        speed = speed * Random.Range(0.8f, 1.2f);

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -25)
        {
            gameObject.transform.position = new Vector3(Random.Range(0, 55), Random.Range(35, 45), 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) speed = speed + 3f;
        if (Input.GetKeyDown(KeyCode.DownArrow)) speed = speed - 3f;


        transform.position = new Vector3(transform.position.x, (transform.position.y - (speed * Time.deltaTime)), transform.position.z);
        


    }
}
