using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dusman : MonoBehaviour
{
    int can = 100;
    public Text t;
    Rigidbody2D r;
    public GameObject mermi;
    float yatay = 1;
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        InvokeRepeating("RandomMermi", 1, 0.7f);
    }

    void Hareket()
    {

        if (gameObject.transform.position.x >= 5.54)
        {
            yatay = -1;
        }
        else if (gameObject.transform.position.x <= -5.57)
        {
            yatay = 1;
        }
        r.velocity = new Vector3(5 * yatay, 0, 0);
    }
    void RandomMermi()
    {
        Instantiate(mermi, gameObject.transform.position, gameObject.transform.rotation);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Mermi2")
        {
            can = can - 10;
        }
    }
    void skor()
    {
        t.text = "" + can;
        if (can <= 0)
        {
            t.text = "Kazandınız";
        }
    }
    void Update()
    {
        Hareket();
        skor();
    }
}
