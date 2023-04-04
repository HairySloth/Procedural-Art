using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    public float speed;
    public GameObject gerard;
    public bool boom;
    // Start is called before the first frame update
    void Start()
    {
        gerard = GameObject.Find("gerard");
    }

    // Update is called once per frame
    void Update()
    {
        Firework firework = gerard.GetComponent<Firework>();
        if (firework.boomdone)
        {
            transform.position = new Vector3(-30, -30, 0);
        }
        if (firework.explode)
        {
            StartCoroutine(explode());
        }
        boom = firework.explode;
        if ((gerard.transform.position.y < 25) && (gerard.transform.position != new Vector3(-30,-30,0)))
        {
            transform.position = gerard.transform.position;

        }

    }

    IEnumerator explode()
    {


        if (boom)
        {
            transform.position = new Vector3(transform.position.x + (Random.Range(-speed, speed)*Time.deltaTime), transform.position.y + (Random.Range(-speed, speed)*Time.deltaTime), 0);
            print("jahoo");
        }
        


        yield return new WaitForSeconds(0f);
    }

}
