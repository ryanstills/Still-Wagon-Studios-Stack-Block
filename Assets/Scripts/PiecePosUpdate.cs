using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiecePosUpdate : MonoBehaviour
{
    int drop_size = 1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Camera height:" + Camera.main.pixelHeight);
    }

    // Update is called once per frame
    void Update()
    {
        var camera = Camera.main;
        gameObject.transform.position = new Vector3(transform.position.x, (transform.position.y - (drop_size * (1/60F))), transform.position.z);
        if(gameObject.transform.position.y < (0 - camera.pixelHeight) / 2F)
        {
            gameObject.transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        drop_size = 0;
    }
}
