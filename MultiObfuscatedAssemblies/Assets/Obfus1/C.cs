using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPInfo_Obfus1
{
    public int x;

    // Start is called before the first frame update
    public void Run(BPInfo_NonObfus1 a)
    {
        x = a.x + 1;
    }
}
