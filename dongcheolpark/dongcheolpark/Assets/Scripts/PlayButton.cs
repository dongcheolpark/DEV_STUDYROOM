using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClickPlay() {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
