using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 攻撃判定用オブジェクト.
    [SerializeField] GameObject attackHit = null;
    // アニメーター.
    Animator animator = null;
    //! 攻撃アニメーション中フラグ.
    bool isAttack = false;

    // Start is called before the first frame update
    void Start()
    {
        // Animatorを取得し保管.
        animator = GetComponent<Animator>();
        // 攻撃判定用オブジェクトを非表示に.
        attackHit.SetActive( false );
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
        if( isAttack == false )
        {
            // AnimationのisAttackトリガーを起動.
            animator.SetTrigger( "isAttack" );
            // 攻撃開始.
            isAttack = true;
        }
    }

    // ---------------------------------------------------------------------
    /// <summary>
    /// 攻撃アニメーションHitイベントコール.
    /// </summary>
    // ---------------------------------------------------------------------
    void Anim_AttackHit()
    {
        Debug.Log( "Hit" );
        // 攻撃判定用オブジェクトを表示.
        attackHit.SetActive( true );
    }

    // ---------------------------------------------------------------------
    /// <summary>
    /// 攻撃アニメーション終了イベントコール.
    /// </summary>
    // ---------------------------------------------------------------------
    void Anim_AttackEnd()
    {
        Debug.Log( "End" );
        // 攻撃判定用オブジェクトを非表示に.
        attackHit.SetActive( false );
        // 攻撃終了.
        isAttack = false;
    }
}