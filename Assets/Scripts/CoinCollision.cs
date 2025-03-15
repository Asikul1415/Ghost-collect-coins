using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        DataContainer.s_coinsCount += 1;
        Destroy(gameObject);
    }
}
