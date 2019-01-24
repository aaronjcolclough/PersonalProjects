using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

    public new string name = "Untitled";
    public float speed;
    public bool alive;
    public int age = 10;
    public int[] points;

    void Awake()
    {
        print("Awake");
    }
    // Use this for initialization
    void Start () {
        print("Start");
	}
	
	// Update is called once per frame
	void Update () {
        var pos = transform.position;

        transform.position = new Vector3(pos.x + speed, pos.y, pos.z);
	}
}
