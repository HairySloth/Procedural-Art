using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingFireworks : MonoBehaviour
{
    private GameObject gerard;
    private GameObject jannes;
    private GameObject hendrik;
    private GameObject yorick;
    private GameObject leeuwenhart;


    public Renderer rend;
    public float sMin;
    public float sMax;
    public float multiplier;
    public Color color;

    private float dist;
    public float[] myCubes;



    // Start is called before the first frame update
    void Start()
    {
        gerard = GameObject.Find("gerard");
        jannes = GameObject.Find("jannes");
        hendrik = GameObject.Find("hendrik");
        yorick = GameObject.Find("yorick");
        leeuwenhart = GameObject.Find("leeuwenhart");
        rend = GetComponent<Renderer>();
        rend.material = new Material(Shader.Find("Specular"));
    }

    // Update is called once per frame
    void Update()
    {
        myCubes = new float[6];
        myCubes[1] = Vector3.Distance(gameObject.transform.position, gerard.transform.position);
        myCubes[2] = Vector3.Distance(gameObject.transform.position, jannes.transform.position);
        myCubes[3] = Vector3.Distance(gameObject.transform.position, hendrik.transform.position);
        myCubes[4] = Vector3.Distance(gameObject.transform.position, yorick.transform.position);
        myCubes[5] = Vector3.Distance(gameObject.transform.position, leeuwenhart.transform.position);




        //print(Vector3.Distance(gameObject.transform.position, gerard.transform.position) + ", " + Vector3.Distance(gameObject.transform.position, jannes.transform.position) + ", " + Vector3.Distance(gameObject.transform.position, hendrik.transform.position) + ", " + Vector3.Distance(gameObject.transform.position, yorick.transform.position) + ", " + Vector3.Distance(gameObject.transform.position, leeuwenhart.transform.position));
        //print(dist);


        if (Input.GetKeyDown(KeyCode.UpArrow)) multiplier++;
        if (Input.GetKeyDown(KeyCode.DownArrow)) multiplier--;
        transform.localScale = new Vector3(sMax - (Mathf.Clamp(dist / multiplier, sMin, sMax)), sMax - (Mathf.Clamp(dist / (multiplier), sMin, sMax)), sMax - (Mathf.Clamp(dist / multiplier, sMin, sMax)));
        rend.material.color = gerard.GetComponent<Firework>().color;
        if (gerard.GetComponent<Firework>().explode)
        {
            multiplier = 2.5f;
        }
        else
        {
            multiplier = 1.5f;
        }


        float max = myCubes[1];
        for (int i = 1; i < myCubes.Length; i++)
        {
            if (myCubes[i] < max)
            {
                max = myCubes[i];
            }
        }
        dist = max;
    }




}
