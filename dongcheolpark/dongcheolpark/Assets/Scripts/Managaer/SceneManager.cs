using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializeField] GameObject Player;
    public Player player;
    // Start is called before the first frame update
    void Awake()
    {
        Player = Instantiate(Resources.Load<GameObject>("Prefabs/Circle"));
        player = Player.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
    }

}
