
using UnityEngine;

public class ImageMovement : MonoBehaviour
{
    [SerializeField] private Vector3 _movementAxis = new Vector3(0, 0, 0);
    [SerializeField] private float _movementAmount = 30;
    [SerializeField] private float _movementSpeed = 1;
    void Update()
    {
        
            float sine = Mathf.Sin(Time.time) * _movementAmount;
            
            float targetMovementX = sine * _movementAxis.x;
            float targetMovementY = sine * _movementAxis.y;
            float targetMovementZ = sine * _movementAxis.z;
            
            float lerpX = Mathf.Lerp(transform.localPosition.x, targetMovementX+transform.localPosition.x, _movementSpeed * Time.deltaTime);
            float lerpY = Mathf.Lerp(transform.localPosition.y, targetMovementY+transform.localPosition.y, _movementSpeed * Time.deltaTime);
            float lerpZ = Mathf.Lerp(transform.localPosition.z, targetMovementZ+transform.localPosition.z, _movementSpeed * Time.deltaTime);

            transform.localPosition = new Vector3(lerpX, lerpY, lerpZ);
    }
}
