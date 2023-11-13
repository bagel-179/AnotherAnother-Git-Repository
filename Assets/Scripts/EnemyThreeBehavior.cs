using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyThreeBehavior : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 2);
        if (transform.position.y < -8f)
        {
            Destroy(this.gameObject);
        }
    }
}

