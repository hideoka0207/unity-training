using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // アニメーター.
    Animator animator = null;

    // Start is called before the first frame update
    void Start()
    {
        // アニメーターを取得.
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ---------------------------------------------------------------------
    /// <summary>
    /// 攻撃ボタンクリックコールバック.
    /// </summary>
    // ---------------------------------------------------------------------
    public void OnAttackButtonClicked()
    {
        // アニメーターのisAttackをトリガー.
        animator.SetTrigger( "isAttack" );
        Debug.Log( "攻撃!!" );
    }
}
