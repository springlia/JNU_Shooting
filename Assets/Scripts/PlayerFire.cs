using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [SerializeField] GameObject bulletFactory;
    [SerializeField] GameObject firePosition;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = firePosition.transform.position;
        }
    }
}
