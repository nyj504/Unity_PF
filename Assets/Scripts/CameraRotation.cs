using Unity.Cinemachine;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField]
    private float sensitivity = 2.0f;
    [SerializeField]
    private float _rotX;
    private float _rotY;

   
    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        _rotX += mouseX;
        _rotY -= mouseY;
        _rotX = Mathf.Clamp(_rotX, -30f, 70f);

        transform.rotation = Quaternion.Euler(_rotX, _rotY, 0f);
    }
}
