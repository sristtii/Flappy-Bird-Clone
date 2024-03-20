using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class pipemovement : MonoBehaviour
{
    [SerializeField]
    private float movespeed;
    public float deadzone=-11;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * movespeed)* Time.deltaTime;
        if(transform.position.x<deadzone){
            Destroy(gameObject);
        }
    }
}
