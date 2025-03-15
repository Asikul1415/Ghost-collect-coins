using TMPro;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    public TMP_Text coinsCountText;
    public TMP_Text deathsCountText;
    [SerializeField] private GameObject victoryUI;

    private void Update()
    {
        UpdateCoinsAndDeathsTexts();
    }
    private void UpdateCoinsAndDeathsTexts()
    {
        coinsCountText.text = $"Coins: {DataContainer.s_coinsCount}";
        deathsCountText.text = $"Deaths: {DataContainer.s_deathsCount}";
    }

    public void ShowVictoryScreen()
    {
        victoryUI.SetActive(true);
    }
}
