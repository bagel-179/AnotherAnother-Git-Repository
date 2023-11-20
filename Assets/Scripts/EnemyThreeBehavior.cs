using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyThreeBehavior : MonoBehaviour
{

    public GameObject explosionPrefab;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(new Vector3(-0.6f, 1, 0) * Time.deltaTime * 2);
        if (transform.position.y < -8f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D whatIHit)
    {
        if (whatIHit.tag == "Player")
        {
            whatIHit.GetComponent<Player>().LoseLife();
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
        else if (whatIHit.tag == "Weapon")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().EarnScore(2);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(whatIHit.gameObject);
            Destroy(this.gameObject);
        }
    }
}