using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField]int hp = 1;
    public GameObject particles;

    public void Damage()
    {
        hp--;
        if(hp <= 0)
        {
            Destroy(gameObject);
        }
        Instantiate(particles, transform.position, Quaternion.identity);
    }
}
