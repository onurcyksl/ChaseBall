using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class Rots : MonoBehaviour
{   

    enum State { Alive, Dying }
    State state = State.Alive;
    public int a = 0;
    public int yon = 1;
    public GameObject table;
    public float speed;
    public int timer = 0;
    public bool notdead = true;
    public int x = 0;
    public float score = 0;
    [SerializeField] ParticleSystem engineParticle;
    [SerializeField] ParticleSystem deathParticle;

    //AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        //audioSource = GetComponent<AudioSource>();

    }
    
    void OrbitAround()
    {
        
        if (Input.GetKeyDown("space"))
        {
            yon++;
            //Debug.Log(yon);
            if (yon == 2)
            {
                yon = 0;
            }

        }
        if (yon % 2 == 0)
        {
            transform.RotateAround(table.transform.position, Vector3.back, speed * Time.deltaTime);

        }
        else
        {
            transform.RotateAround(table.transform.position, Vector3.forward, speed * Time.deltaTime);

        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (state != State.Alive) { return; }

        switch (collision.gameObject.tag)
        {

            case " ":
                Console.WriteLine("Alive");

                break;

            case "RedBall":
                Console.WriteLine("Dead");
                notdead = false;
                //audioSource.PlayOneShot();

                //Destroy(gameObject);
                break;
     
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        
        
        if (!notdead)
        {
            x++;
            deathParticle.Play();
        }
        if (x <= 5 )
        {
            engineParticle.Play();
            score += speed/100;
            
            Debug.Log(Math.Round(score));
            OrbitAround();
            timer++;

        if(timer % 7 == 0 && timer <= 200)
        {
            speed += 1;
        }
        else if(timer % 14 == 0 && timer <= 400)
        {
            speed += 1;
        }
        else if (timer % 21 == 0 && timer <= 800)
        {
            speed += 1;
        }
        else if (timer % 28 == 0 && timer <= 1200)
        {
            speed += 1;
        }
        else if (timer % 35 == 0 && timer <= 1600)
        {
            speed += 1;
        }
        else if (timer % 150 == 0)
        {
                speed += 1;
        }
    }
    }
}