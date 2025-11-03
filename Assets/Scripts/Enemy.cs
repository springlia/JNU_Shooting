using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed = 5;
    Vector3 dir;
    [SerializeField] GameObject boomEffect;

    private void Start()
    {
        int randValue = Random.Range(0, 10);
        if (randValue < 3)
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - this.transform.position;
            dir.Normalize();
        }
        else
        {
            dir = Vector3.down;
        }
    }
    void Update()
    {
        
        this.transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Bullet"))
        {

            GameObject smObject = GameObject.Find("ScoreManager");
            ScoreManager sm = smObject.GetComponent<ScoreManager>();
            sm.SetScore(sm.GetScore() + 1);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Instantiate(boomEffect, this.transform.position, Quaternion.identity);            
        }
    }


}
