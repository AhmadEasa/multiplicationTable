using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, here is the multiplication table for five:");
   
        int Multiply(int a, int b)
    {
        return a*b;
    }   
       for (int F = 1 ; F<=10; F++){
            int result = Multiply(5, F);
            Debug.Log("5 x " + F + " = " + result);
       }
    }


}
