using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zemin : MonoBehaviour
{
    

    private void OnCollisionEnter(Collision collision) // zemin ile elma çarpýþýnca bu olur
    {
        if (collision.gameObject.tag == "elmaTag")
        {

            float rast = Random.Range(-13.57f, -2.4f);

            collision.gameObject.transform.position = new Vector3(rast, 20.93f, -13.57f);
        }
    }
}
