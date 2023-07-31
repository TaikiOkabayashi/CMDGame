using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class BattleMainSystem : MonoBehaviour
{
    [SerializeField] Canvas _win;
    [SerializeField] Canvas _lose;
    [SerializeField] Canvas _inGameUI;
    public PlayerController player;
    public EnemyController enemy;
    public Tool tool;
    bool IsPlayerTrun;
    float second = 0f;
    int count = 0;
    void Start()
    {
        IsPlayerTrun = true;
    }

    void Update()
    {

        if(enemy._enemyhp<0)
        {
            _win.gameObject.SetActive(true);
            _inGameUI.gameObject.SetActive(false);
        }
        else if(player._playerhp <0) 
        {
            _lose.gameObject.SetActive(true);
            _inGameUI.gameObject.SetActive(false);
        }

        if(!IsPlayerTrun)
        {
            second += Time.deltaTime;
            if(second >= 1f)
            {
                if (count > 0)
                {
                    count--;
                    int random = Random.Range(1, 11);
                    if (random >= 9)
                    {
                        second = 0f;
                        enemy.OnDamage(enemy._enemypower);
                        IsPlayerTrun = true;
                        UnityEngine.Debug.Log("�U���𒵂˕Ԃ���");
                    }
                    else
                    {
                        second = 0f;
                        IsPlayerTrun = true;
                        player.OnDamage(enemy._enemypower);
                        UnityEngine.Debug.Log("�v���C���[��" + enemy._enemypower + "�_���[�W���󂯂�");
                        UnityEngine.Debug.Log(count);
                    }
                }
                else
                {
                    second = 0f;
                    IsPlayerTrun = true;
                    player.OnDamage(enemy._enemypower);
                    UnityEngine.Debug.Log("�v���C���[��" + enemy._enemypower + "�_���[�W���󂯂�");
                }
            }
        }
        
    }

    public void PushAttackButton()
    {
        enemy.OnDamage(player._playerpower);
        IsPlayerTrun = false;
    }
    public void ReflectionButton()
    {
        if (count == 0)
        {
            count += 3;
            player._playermp -= 5;
            if (player._playermp < 5)
            {
                UnityEngine.Debug.Log("MP������Ȃ��I�I");
            }
            UnityEngine.Debug.Log("�X�L�����g�p�����I�I");
            IsPlayerTrun = false;
        }
        else
        {
            UnityEngine.Debug.Log("���ɉ����N����Ȃ������I�I");
        }
    }
    public void MedicinalHerbsButton()
    {
        if (tool._yakusou > 0)
        {
            player._playerhp += 20;
            if (player._playerhp >= player._playermaxhp)
            {
                player._playerhp = player._playermaxhp;
            }
            tool._yakusou--;
            IsPlayerTrun = false;
            UnityEngine.Debug.Log("HP��20�񕜂����I�I");
        }
        else
        {
            UnityEngine.Debug.Log("�򑐐؂ꂾ�I�I");
        }
    }
    public void HighMedicinalHerbsButton()
    {
        if (tool._jouyakusou > 0)
        {
            player._playerhp += 50;
            if (player._playerhp >= player._playermaxhp)
            {
                player._playerhp = player._playermaxhp;
            }
            tool._jouyakusou--;
            IsPlayerTrun = false;
            UnityEngine.Debug.Log("HP��50�񕜂����I�I");
        }
        else
        {
            UnityEngine.Debug.Log("��򑐐؂ꂾ�I�I");
        }

    }
}