using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D _rb;
    public logic logic;
    public bool birdalive=true;
    [SerializeField] private float flapspeed;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdalive)
        {
            _rb.velocity = Vector2.up * flapspeed;
        }

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        logic.gameover();
        birdalive=false;
    }
}
