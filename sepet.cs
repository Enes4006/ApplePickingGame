using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sepet : MonoBehaviour
{
    public float hiz = 5f;

    int skor = 0;

    private void OnCollisionEnter(Collision collision) // sepet ile elma çarpýþýnca bu olur
    {
        if(collision.gameObject.tag=="elmaTag")
        {
            skor += 10;
            Debug.Log(skor.ToString());

            float rast = Random.Range(-13.57f,-2.4f); // elma, x ekseninde rastgele yerlerde spawn olur

            collision.gameObject.transform.position = new Vector3(rast, 20.93f, -13.57f);
        }
    }


    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)) // sað ok tuþuna basýldýðýnda,
        {
            transform.Translate(hiz * Time.deltaTime,0,0);  
        }
        if(Input.GetKey(KeyCode.LeftArrow)) // sol ok tuþuna basýldýðýnda,
        {
            transform.Translate(-hiz * Time.deltaTime,0,0); 
        }
        
    }
}
