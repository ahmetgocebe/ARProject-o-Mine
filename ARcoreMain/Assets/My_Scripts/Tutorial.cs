using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Tutorial : MonoBehaviour
{
    public GameObject canvas;
     public Text text;
        private void Update()
    {
        if(canvas==null)
        {
            text.text = "Then press the start button ";
        }
    }
}
