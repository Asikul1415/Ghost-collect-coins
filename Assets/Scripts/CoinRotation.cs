using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 20f;
    void Update()
    {
        transform.Rotate(
            xAngle: Time.deltaTime * rotationSpeed, 
            yAngle: Time.deltaTime * rotationSpeed, 
            zAngle:0);
    }
}
