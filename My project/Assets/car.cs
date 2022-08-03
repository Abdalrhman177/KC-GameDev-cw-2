using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    string heroName = "batman";
    int heroHeight = 22;
    float heroAge = 60.50f;
    string heroSuperPower = "fly";
    string villainName = "joker";
    int vililanHeight = 10;
    float villainAge = 40.25f;
    string villainSuperPower = "speed";

    // Start is called before the first frame update
    void Start()
    {
        print("hero name is ?" + heroName + "heroheight" + heroHeight + "heroAge is ?" + heroAge + "heroSuperPower is ?" + heroSuperPower);
        print("villainName is ?" + villainName + "vililanHeight" + vililanHeight + "villainAge" + villainAge + "villainSuperPower" + villainSuperPower);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
