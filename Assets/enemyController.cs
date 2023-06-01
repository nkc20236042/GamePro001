using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    GameObject Chara;
    // Start is called before the first frame update
    void Start()
    {
        this.Chara = GameObject.Find("MyChar_0");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.08f, 0, 0);
    
    if(transform.position.x < -5.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.Chara.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.3f;
        float r2 = 0.4f;

       if (d < r1 + r2) 
       { 
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseTime();
            Destroy (gameObject);
       }
    }
}
