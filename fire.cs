using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed; 
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        SliderHealth enemy = hitInfo.GetComponent<SliderHealth>();
        BossHealth enemy2 = hitInfo.GetComponent<BossHealth>();
        if(enemy != null)
        {
            enemy.TakeDamage(20);
        }
        if(enemy2 != null)
        {
            enemy2.TakeDamage(40);
        }
        StartCoroutine(fireballVanish());
    }
    IEnumerator fireballVanish()
    {
        yield return new WaitForSeconds(1);
        //gameObject.GetComponent<SpriteRenderer>().enabled = false;
        Destroy(gameObject);
    }
}
