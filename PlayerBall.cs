using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;
using UnityEngine.UI;

namespace abx
{
    public class PlayerBall : MonoBehaviour
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
        public float scoreball = 0;
        public Text scoretext;
        //[SerializeField] ParticleSystem engineParticle;
        //[SerializeField] ParticleSystem deathParticle;


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

        
        void OnCollisionEnter2D(Collision2D collision)
        {

            if (collision.gameObject.tag == "RedBall")
            {
                notdead = false;
            }
            else
            {

            }

            //if (state != State.Alive) { return; }

            /*switch (collision.tag)
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

            }*/
        }

        // Update is called once per frame
        void Update()
        {



            if (!notdead)
            {
                x++;

            }
            if (x <= 10)
            {
                //scoreball += ;
                scoreball += speed / 1000;
                scoretext.text = Math.Round(scoreball).ToString();
                //Debug.Log(Math.Round(scoreball));
                OrbitAround();
                timer++;

                if (timer % 7 == 0 && timer <= 600)
                {
                    speed += 1;
                }
                else if (timer % 14 == 0 && timer <= 900)
                {
                    speed += 1;
                }
                else if (timer % 21 == 0 && timer <= 1200)
                {
                    speed += 1;
                }
                else if (timer % 28 == 0 && timer <= 1500)
                {
                    speed += 1;
                }
                else if (timer % 35 == 0 && timer <= 1800)
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

}