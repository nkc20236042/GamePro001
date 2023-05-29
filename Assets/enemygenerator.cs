using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemygenerator : MonoBehaviour
{
    public GameObject Enemy_prefab;
    float span = 0.5f;
    float delta = 0;
    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(Enemy_prefab);
            int px = Random.Range(-3, 3);
            go.transform.position = new Vector3(6, px, 0);
        }
    }
}
