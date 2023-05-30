using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject timegauge;
    // Start is called before the first frame update
    void Start()
    {
        this.timegauge = GameObject.Find("timegauge");
    }

void Update()
    {
        this.timegauge.GetComponent<Image>().fillAmount -= 0.0002f;
    }
}
