using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    [SerializeField] Text _playertext;
    [SerializeField] public int _playerhp;
    [SerializeField] public int _playermaxhp;
    [SerializeField] public int _playermp;
    [SerializeField] public int _playerpower;

    private void Start()
    {
        _playerhp = _playermaxhp;

    }
    private void Update()
    {
        _playertext.text = "HP:" + _playerhp;
    }

    public void OnDamage(int _damage)
    {
        _playerhp -= _damage;
    }
}

