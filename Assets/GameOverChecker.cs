using System;
using UnityEngine;
public class GameOverChecker : MonoBehaviour
{
    public GameObject ball;
    public GameObject panelOnGameOver;
    private DateTime time;


    // Start is called before the first frame update
    void Start()
    {
        time = DateTime.Now.AddSeconds(5);
    }

    // Update is called once per frame
    void Update()
    {
        if (time.ToString("yyyy/MM/dd HH:mm:ss") == DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
        {
            OngameOver();
        }
    }

    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Ball")
        {
            OngameOver();
        }
    }

    public void OngameOver()
    {
        panelOnGameOver.SetActive(true);
        ball.SetActive(false);
    }

}
// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class GameOverChecker : MonoBehaviour
// {

//     public GameObject ball;

//     public GameObject panelOnGameOver;




//     private float time = 0f;
//     private  float gameOverTime = 1f;


//     // Start is called before the first frame update
//     void Start()
//     {

//     }

//     // Update is called once per frame
//     void Update()
//     {
//         time += Time.deltaTime;

//         Debug.Log("time" + time);

//         if (time >= gameOverTime)
//         {
//             OnGameOver();
//         }


//     }
//     void OnTriggerEnter(Collider c)
//     {
//         if (c.gameObject.tag == "Ball")
// {
//             OnGameOver();
//         }
//     }
//     public void OnGameOver()
//     {
//         panelOnGameOver.SetActive(true);
//         ball.SetActive(false);
//     }


// }