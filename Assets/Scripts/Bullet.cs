using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed;
    
    void Update()
    {
        this.transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
