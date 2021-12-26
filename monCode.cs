using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monCode : MonoBehaviour
{
    float gravity;

    Vector2 speed = new Vector2(1, 1);

    int a = 6;
    int b = 5;

    int addition(int x, int y)
    {
        int resultat;
        resultat = x + y;
        return resultat;
    }
    int produit(int x, int y)
    {
        int resultat;
        resultat = x * y;
        return resultat;
    }

    float division(float x,float y)
    {
        float resultat;
        resultat = x / y;
        return resultat;
    }



    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        Debug.Log(addition(2, 5));
        Debug.Log(addition(7, 5));
        Debug.Log(produit(4, 6));
        Debug.Log(division(3, 2));
        


    }
    // Update is called once per frame
    void Update()
    {


        float x = Input.GetAxis("Horizontal");
       


        gravity = Input.GetAxis("Vertical");





    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().gravityScale = gravity;
    }    
}