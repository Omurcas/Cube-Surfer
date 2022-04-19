using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public Player player;
    public Score sc;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Point")
        {
            
            player.gameObject.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            sc.AddPoint();
            Destroy(collision.gameObject);
            //FindObjectOfType<GameManager>().GameOver();
            
        }
        if (collision.collider.tag == "Minus")
        {

            player.gameObject.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
            sc.MinusPoint();
            Destroy(collision.gameObject);
            //FindObjectOfType<GameManager>().GameOver();

        }
        if (collision.collider.tag == "Platform")
        {
           
            FindObjectOfType<GameManager>().GameOver();
            

        }
    }
}
