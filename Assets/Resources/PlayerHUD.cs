using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHUD : MonoBehaviour
{
    [Header("Hearts")]
    public TextMeshProUGUI heartText;

    [Header("Bombs")]
    public TextMeshProUGUI bombText;

    public void UpdateHearts(int value)
    {
        heartText.text = "x " + value;
    }

    public void UpdateBombs(int value)
    {
        bombText.text = "x " + value;
    }
}
