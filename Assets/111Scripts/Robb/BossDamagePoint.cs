﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HEXLIBRIUM
{
    public class BossDamagePoint : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                BossController.instance.DamageBoss();
            }
        }
    }
}