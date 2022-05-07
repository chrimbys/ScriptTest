using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;

    

    
    public void Magic()
    {
        for (int i = 1; i < 12; i++)
        {
            int MP = mp - 5 * i;

            if (MP < 3)
            {
                Debug.Log("MPが足りないため、魔法が使えない。");
            }

            else
            {
                Debug.Log("魔法攻撃をした。残りMPは" + MP);
            }
        }
        
    }

}


public class Test : MonoBehaviour
{

    void Start()
    {
        Boss boss = new Boss();

        boss.Magic();
    }

    // Update is called once per frame
    void Update()
    {

    }
}