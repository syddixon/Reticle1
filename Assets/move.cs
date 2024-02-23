using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float maxX = -13f;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.left);

        if (transform.position.x <= maxX)
        {
            transform.Translate(30f, 0f, 0f);
        }
    }
}
