using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;


public class EnemyBall : MonoBehaviour
{
    enum State { Alive, Dying }
    State state = State.Alive;
    public bool notdead = true;
    public int a = 0;
    public int yon = 0;
    public System.Random abc;
    public GameObject table;
    public float speed;
    public int timer = 0;
    public int x = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Random1()
    {

        abc = new System.Random();
        int randn = abc.Next(30, 210); // fps 30 so int/30 
        a = randn;


    }

    void OrbitAround()
    {
        if (a == 1)
        {
            yon++;
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

            case "Player":
                
                notdead = false;
                
                break;

            case "RedBall":
                
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
        }
        if (x <= 5) 
        {
            OrbitAround();

            //Debug.Log(a);
            if (a == 0)
            {
                Random1();
            }
            a--;

            timer++;

            if (timer % 7 == 0 && timer <= 200)
            {
                speed += 1;
            }
            else if (timer % 14 == 0 && timer <= 400)
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


