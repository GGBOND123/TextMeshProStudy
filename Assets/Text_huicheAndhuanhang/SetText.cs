using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetText : MonoBehaviour
{
    public TMP_InputField inputField;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            inputField.text = "asdasddd\r\nddddddddddddddddd";
        }
    }
}
