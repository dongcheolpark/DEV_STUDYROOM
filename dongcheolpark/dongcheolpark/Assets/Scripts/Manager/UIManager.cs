using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public GameObject AppleCount;

    public void changeAppleCount(int count) {
        AppleCount.GetComponent<TextMeshProUGUI>().text = count.ToString();
    }
}
