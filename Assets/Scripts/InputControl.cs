using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControl : MonoBehaviour
{
    //reference and variables
    public GameObject upCube;
    public GameObject downCube;
    public GameObject leftCube;
    public GameObject rightCube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            upCube.GetComponent<MeshRenderer>().material.color = new Color(0,1,0);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            upCube.GetComponent<MeshRenderer>().material.color = new Color(1,1,1);
        }
    }
}
