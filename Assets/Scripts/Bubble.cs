using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField]
    private float bubbleSpeed;
    Rigidbody2D rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        rigidBody.AddForce(new Vector2(Random.value, Random.value).normalized * bubbleSpeed);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
