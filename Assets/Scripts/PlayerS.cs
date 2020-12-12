using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerS : MonoBehaviour
{
    public static Sprite defaultSprite;
    public Sprite RealDefault;

    SpriteRenderer _player;

    void Start()
    {
        defaultSprite = RealDefault;
        _player = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        _player.sprite = defaultSprite;
    }
}
