using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AutoMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody obj;
    public int maxX;
    public int minX;
    public float speed;
    public bool limit = false;

    private void FixedUpdate()
    {
        obj.AddForce(speed * Time.deltaTime, 0, 0,ForceMode.Impulse);
        if(obj.position.x>=maxX&& limit == false)
        {
            speed = -speed;
            limit = true;
        }else if(obj.position.x<=minX&& limit == true)
        {
            speed = -speed;
            limit = false;
        }
    }

   /* private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "moveleft")
        {
            obj.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        else if (collision.collider.tag == "moveRight")
        {
            obj.AddForce(speed * Time.deltaTime, 0, 0);
        }
    }*/





}
