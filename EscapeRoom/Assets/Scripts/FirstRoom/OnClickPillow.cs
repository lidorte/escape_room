﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickPillow : MonoBehaviour, ClickAction
{
    [SerializeField] GameObject [] toActive;
    public void doAction()
    {
        this.gameObject.SetActive(false);

        foreach(GameObject active in toActive){
            active.gameObject.SetActive(true);
        }
    }
}
