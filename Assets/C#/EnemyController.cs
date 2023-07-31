using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Text _enemyhptext;
    [SerializeField] public int _enemyhp = default(int);
    [SerializeField] int _enemymaxhp = default(int);
    [SerializeField] public int _enemymp = default(int);
    [SerializeField] public int _enemypower = default(int);

    private void Start()
    {
        _enemyhp = _enemymaxhp;

    }

    void Update()
    {
        _enemyhptext.text = "HP:" + _enemyhp;
    }
    public void OnDamage(int _damage)
    {
        _enemyhp -= _damage;
    }
}
