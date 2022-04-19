using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{


    public GameManager gm;
    // S    tart is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        gm.CompletedLevel();
    }
}
