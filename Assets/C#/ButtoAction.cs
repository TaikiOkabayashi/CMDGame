using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtoAction : MonoBehaviour
{
    [SerializeField] Button _attackbutton;
    [SerializeField] Button _skillbutton;
    [SerializeField] Button _toolbutton;
    [SerializeField] Button _exitbutton;
    [SerializeField] Canvas _skillui;
    [SerializeField] Canvas _toolui;
    [SerializeField] Canvas _exitui;
    [SerializeField] Canvas _ingameui;
    // Start is called before the first frame update
    void Start()
    {
        _attackbutton.onClick.AddListener(attackcommand);
        _skillbutton.onClick.AddListener(skillcommand);
        _toolbutton.onClick.AddListener(toolcommand);
        _exitbutton.onClick.AddListener(exitcommand);
    }
    void attackcommand()
    {
       Debug.Log("çUåÇÇµÇΩ") ;
    }
    void skillcommand() 
    {
        _skillui.gameObject.SetActive(true);
        _exitui.gameObject.SetActive(true);
        _ingameui.gameObject.SetActive(false);
    }
    void toolcommand() 
    {
        _toolui.gameObject.SetActive(true);
        _exitui.gameObject.SetActive(true);
        _ingameui.gameObject.SetActive(false);
    }
    void exitcommand()
    {
        _ingameui.gameObject.SetActive(true);
        _exitui.gameObject.SetActive(false);
        _skillui.gameObject.SetActive(false);
        _toolui.gameObject.SetActive(false);

    }
}
