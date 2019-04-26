using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;
    public float timer = 100;
    public int health = 100;
    public bool isPaused = false;
    public UIManager UI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPaused && timer >= 0)
        {
            timer -= Time.deltaTime;
        }
        if(Input.GetKeyDown(KeyCode.H))
        {
            health -= 5;
        }
        //Debug.Log(score);

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            isPaused = !isPaused;
            UI.Pause(isPaused);
        }
    }
}
