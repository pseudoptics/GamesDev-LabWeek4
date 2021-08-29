using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    private int random;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ":" + ++i);
        if (gameObject.tag == "Red" && i == 100) {
            gameObject.SetActive(false);
        }
        else if (gameObject.tag == "Blue" && i == random) {
            rend.enabled = false;
        }
    }
}
