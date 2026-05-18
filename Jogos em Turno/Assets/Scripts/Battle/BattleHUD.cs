using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    [SerializeField] HPBar hpBar;

    public void SetData()
    {
        hpBar.SetHP((float) 100);
    }
}
