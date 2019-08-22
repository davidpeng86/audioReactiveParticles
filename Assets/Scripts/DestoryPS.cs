using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryPS : MonoBehaviour
{

    public ParticleSystem ps;

    void Update()
    {
        if (ps.IsAlive() == false)
        {//判斷粒子是否存活
            Destroy(this.gameObject);
        }
    }
}
