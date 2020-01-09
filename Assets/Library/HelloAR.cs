using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloAR : MonoBehaviour
{
    [SerializeField]
    int Hiz = 10;


    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float yatay = Input.GetAxis("Horizontal");

        float dikey = Input.GetAxis("Vertical");
        Vector3 hareket = new Vector3(yatay * Hiz, 0.0f, dikey * Hiz);
        rb.AddForce(hareket);//force güç ekle demek unutmayınız
    }
}
