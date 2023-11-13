using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwoBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 6);
        if (transform.position.y < -8f)
        {
            Destroy(this.gameObject);
        }
    }
}
