using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public void OnClick() {
#if TEXTMESHPRO_2_1_0_OR_NEWER
        Debug.Log("new tmpro");
#else
        Debug.Log("old tmpro");
#endif
    }
}
