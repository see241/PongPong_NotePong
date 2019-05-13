using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
    

    public void DestroyClick()
    {

        Destroy(this.gameObject,2);
        UIManager.UInum += 1;

    }
    
}
