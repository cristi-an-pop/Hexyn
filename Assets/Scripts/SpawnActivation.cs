using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnActivation : MonoBehaviour
{
    public GameObject SpawnerA;

    public void ClickTheButton()
    {
        SpawnerA.SetActive(true);
    }
}
