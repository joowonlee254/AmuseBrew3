using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WatchScreenController : MonoBehaviour
{
    public GameObject watch_screen;

    void watchScreenControl()
    {

        if (!watch_screen.activeSelf)
        {

            watch_screen.SetActive(true);


        }
        else
        {
            watch_screen.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {


        if (watch_screen.activeSelf)
        {
            watch_screen.SetActive(false);

        }

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.H))
        {
            watchScreenControl();
        }
    }
}
