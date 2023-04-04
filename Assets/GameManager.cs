using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("cube");
        
        for (int j = 0; j < 11; j++)
        {
            for (int i = 0; i < 20; i++)
            {
                Instantiate(cube, new Vector3(transform.position.x + i * 3, transform.position.y + j * 3, transform.position.z), Quaternion.identity);
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            SceneManager.LoadScene(0);
        }
    }
}
