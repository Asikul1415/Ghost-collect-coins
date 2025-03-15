using Sample;
using UnityEngine;

public class LavaCollision : MonoBehaviour
{
    private GhostScript _ghostScript;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<GhostScript>())
        {
            _ghostScript = other.GetComponent<GhostScript>();
            _ghostScript.Damage();
        }
    }
}
