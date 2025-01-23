using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ImageTilt : MonoBehaviour
{
    [SerializeField] private float _autoTiltAmount = 30;
    [SerializeField] private float _tiltSpeed = 2;
    void Update()
    {
        
            float sine = Mathf.Sin(Time.time) * _autoTiltAmount;
            float cosine = Mathf.Cos(Time.time) * _autoTiltAmount;
            
            float targetTiltX = sine; 
            float targetTiltY = cosine;
            float targetTiltZ = 0;
            
            float lerpX = Mathf.LerpAngle(transform.eulerAngles.x, targetTiltX, _tiltSpeed * Time.deltaTime);
            float lerpY = Mathf.LerpAngle(transform.eulerAngles.y, targetTiltY, _tiltSpeed * Time.deltaTime);
            float lerpZ = Mathf.LerpAngle(transform.eulerAngles.z, targetTiltZ, _tiltSpeed * Time.deltaTime);
            
            transform.eulerAngles = new Vector3(lerpX, lerpY, lerpZ);
    }
}
