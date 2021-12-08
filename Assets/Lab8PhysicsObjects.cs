using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab8PhysicsObjects : MonoBehaviour
{
    public float mass = 1.0f;
    public Vector3 velocity = Vector3.zero;
    public PhysicsCollider shape = null;
    public float Bounciness = 0.6f;
    public bool LockPosition = false;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<Lab8PhysicsSystem>().lab8Physics.Add(this);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
