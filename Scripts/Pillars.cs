using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillars : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -5f)
        {
            GameManager.Karen.pillarNum--;
            Destroy(gameObject);
        }
    }
}
