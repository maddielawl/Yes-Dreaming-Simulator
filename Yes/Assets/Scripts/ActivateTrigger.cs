﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTrigger : MonoBehaviour
{
    public GameObject monster;

    private void OnTriggerEnter(Collider other)
    {
        monster.SetActive(true);
    }
}
