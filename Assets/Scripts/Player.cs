using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Light myLight;
    public int health = 100;
    public int healthBonus = 10;
    public float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        //myLight.color = Color.green;
        myLight.color = new Color(0.1f, 0.56f, 0.78f);
        AddToHealth();

        //Adds full health
        AddToHealth(100);

        //Adds half health
        AddToHealth(50);

        //Adds tiny health
        AddToHealth(10);

    }

    // Update is called once per frame
    void Update()
    {
        //AddToHealth();

        if (Input.GetKey(KeyCode.H))
        {
            AddToHealth(1);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            AddToHealth(50);
            Debug.Log("Big Health");
        }

        if (Input.GetKeyUp(KeyCode.J))
        {
            AddToHealth(150);
            Debug.Log("Big Health Up");
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed);
        }

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h, 0, v) * speed);
    }

    //This adds to our health
    void AddToHealth()
    {
        //health = health + 10;  //the longer way to write the same thing
        health += 10;
        health += healthBonus;
    }

    void AddToHealth(int healthModifier)
    {
        health += healthModifier;
    }
}
