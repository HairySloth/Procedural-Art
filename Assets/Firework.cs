using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firework : MonoBehaviour
{

    public float speed;
    public bool explode;
    public bool test;
    public bool boomdone;
    public float mouseX;
    public Color[] colors;
    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(3, 0.2f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && transform.position.y == -30)
        {
            GetComponent<Rigidbody>().position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 100, -Camera.main.transform.position.z));
            mouseX = GetComponent<Rigidbody>().position.x;
            color = colors[Random.Range(0, 5)];
            print(color);
        }



        if (transform.position.y < 25 && transform.position.y > 0)
        {
            if (mouseX < 26)
            {
                transform.position = new Vector3(transform.position.x + ((speed * 0.3f) * Time.deltaTime), (transform.position.y + (speed * Time.deltaTime)), transform.position.z);



            }
            else
            {
                transform.position = new Vector3(transform.position.x + ((speed * -0.3f) * Time.deltaTime), (transform.position.y + (speed * Time.deltaTime)), transform.position.z);

            }

        }
        if (transform.position.y > 25)
        {
            StartCoroutine(explodetrue());
            transform.position = new Vector3(-30,-30,0);


        }
        else if(test == false)
        {
            explode = false;
        }


    }


    IEnumerator explodetrue()
    {
        explode = true;
        test = true;
        print("yeehoo");
        yield return new WaitForSeconds(1f);
        boomdone = true;
        explode = false;
        test = false;
        yield return new WaitForSeconds(0.2f);
        boomdone = false;
    }
}
