using Sample;
using UnityEngine;

public class RewardSystem : MonoBehaviour
{
    [SerializeField] private GameObject[] coins;
    [SerializeField] private GhostScript ghostScript;
    private UIControl _uiControl;
    void Start()
    {
        _uiControl = FindFirstObjectByType<UIControl>();
    }

    void Update()
    {
        if (DataContainer.s_coinsCount >= coins.Length)
            Victory();
    }

    private void Victory()
    {
        _uiControl.ShowVictoryScreen();
        ghostScript.LockControls();
    }
}
