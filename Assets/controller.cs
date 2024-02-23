using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject explodePrefab;
    [SerializeField] Vector3 explodePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(speed * Time.deltaTime * Vector3.up);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime * Vector3.right);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(speed * Time.deltaTime * Vector3.down);
        }
        if(Input.GetButtonDown("Fire1"))
        {
            GetComponent<AudioSource>().Play();
            Instantiate(explodePrefab, transform.position + explodePos, transform.rotation);
        }


    }
}
