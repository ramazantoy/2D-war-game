using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman_Mermi : MonoBehaviour
{
    float y;
    void Start()
    {
        
    }
    void Sil()
    {
        y = gameObject.transform.position.y;
        if (y < -5)
        {
            Destroy(this.gameObject);
        }
    }
 
    void Update()
    {
        Sil();
    }
}
