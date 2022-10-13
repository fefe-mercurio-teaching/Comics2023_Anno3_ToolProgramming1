using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    public float min;
    public float max;

    private void Start()
    {
        int[] numeri = { 10, 20, 30 };
        
        ContaElementi(numeri);
        
        ContaElementiParams(10, 20, 30, 40, 50);
        ContaElementiParams();
    }

    public void ContaElementi(int[] array)
    {
        Debug.Log($"L'array contiene {array.Length} elementi");
    }

    public void ContaElementiParams(params int[] array)
    {
        Debug.Log($"L'array contiene {array.Length} elementi");
    }
}
