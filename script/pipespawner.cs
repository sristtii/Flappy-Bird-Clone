using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class pipespawner : MonoBehaviour
{
    public GameObject pipe;
    [SerializeField] float spawnrate;
    private float timer = 0;
    public float heightoffset;


    // Start is called before the first frame update
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;
        }
    }
    void spawnpipe()
    {
        float lowpoint = transform.position.y - heightoffset;
        float highpoint = transform.position.y + heightoffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowpoint, highpoint)), transform.rotation);
    }
}
