using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed = 5;
    Vector3 dir = Vector3.zero;

    void Update()
    {
        dir.x = Input.GetAxis("Horizontal");
        dir.y = Input.GetAxis("Vertical");
        //transform.Translate(dir * speed * Time.deltaTime);
        this.transform.position += dir * speed * Time.deltaTime;
    }
}
