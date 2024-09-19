using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    GameObject player;
    Renderer rend;
    float playerstartpos;
    public float speed = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        rend = GetComponent<Renderer>();
        playerstartpos = (player.transform.position.x) * speed;
    }

    // Update is called once per frame
    void Update()
    {
        float offset = ( player.transform.position.x -  playerstartpos );  
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0f));
    }
}
