using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class HPBar : MonoBehaviour
{
    [SerializeField] private GameObject health;

    public void SetHP(float hpNormalized)
    {
        health.transform.localScale = new Vector3(hpNormalized, 1f);
    }
}