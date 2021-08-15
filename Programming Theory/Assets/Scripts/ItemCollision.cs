using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollision : MonoBehaviour
{
    private ScoreManager sm;

    private void Start()
    {
        sm = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Dog")
        {
            sm.AddScore();
            Destroy(this.gameObject);

        }
    }
}
