using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _movespeed = 1.0f;
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontal * _movespeed * Time.deltaTime);

        float vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * vertical * _movespeed * Time.deltaTime);
    }
}
