using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{

    public bool switchOn;
    GameObject[] moveables;
    private int length;

    AudioSource aud;

    private void Start()
    {
        moveables = GameObject.FindGameObjectsWithTag("Moveable");
        aud = gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (!switchOn)
        {
            length = moveables.Length;
            while (length > 0)
            {
                moveables[length - 1].GetComponent<Rigidbody2D>().gravityScale = 0;
                moveables[length - 1].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
                length--;
            }
        }
        else if (switchOn)
        {
            length = moveables.Length;
            while (length > 0)
            {
                moveables[length - 1].GetComponent<Rigidbody2D>().gravityScale = 1;
                moveables[length - 1].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
                moveables[length - 1].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
                length--;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(!switchOn)
            {
                switchOn = !switchOn;
                Vector3 localScale = gameObject.transform.localScale;
                localScale.y *= -1;
                gameObject.transform.localScale = localScale;
                GameObject[] switches = GameObject.FindGameObjectsWithTag("switch");
                length = switches.Length;
                aud.Play();
                while(length > 0)
                {
                    switches[length - 1].GetComponent<Switch>().switchOn = switchOn;
                    length--;
                }
                
            }
            else if(switchOn)
            {
                switchOn = !switchOn;
                Vector3 localScale = gameObject.transform.localScale;
                localScale.y *= -1;
                gameObject.transform.localScale = localScale;
                GameObject[] switches = GameObject.FindGameObjectsWithTag("switch");
                length = switches.Length;
                aud.Play();
                while (length > 0)
                {
                    switches[length - 1].GetComponent<Switch>().switchOn = switchOn;
                    length--;
                }
            }
        }
    }

}
