using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tool : MonoBehaviour
{
    [SerializeField] public int _yakusou;
    [SerializeField] public int _jouyakusou;
    [SerializeField] Text _yakusoutext;
    [SerializeField] Text _jouyakusoutext;
    private void Update()
        {
            _yakusoutext.text = "–ò‘:" + _yakusou + "ŒÂ";
            _jouyakusoutext.text = "ã–ò‘:" + _jouyakusou + "ŒÂ";
    }
}
