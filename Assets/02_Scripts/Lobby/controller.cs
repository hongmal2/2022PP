using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(GameManager.GM.forward))
        {
            transform.position += Vector3.forward * Time.deltaTime;
        }
         if (Input.GetKey(GameManager.GM.backward))
        {
            transform.position += -Vector3.forward * Time.deltaTime;
        }
         if (Input.GetKey(GameManager.GM.Left))
        {
            transform.position += Vector3.left * Time.deltaTime;
        }
         if (Input.GetKey(GameManager.GM.right))
        {
            transform.position += Vector3.right * Time.deltaTime;
        }
         if (Input.GetKey(GameManager.GM.jump))
        {
            transform.position += Vector3.up * Time.deltaTime;
        }
    }
}
