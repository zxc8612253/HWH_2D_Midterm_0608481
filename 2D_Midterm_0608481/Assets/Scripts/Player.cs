using UnityEngine;

public class Player : MonoBehaviour
{
    // 修飾詞 類型 名稱 (指定 值) ;

    [Header("角色等級")]
    public int lv = 1;
    [Header("移動速度"), Range(0, 300)]
    public float speed = 10.5f;
    public bool isDead = false;
    [Tooltip("這是角色名稱")]
    public string cName = "原始人";
    [Header("虛擬搖桿")]
    public FixedJoystick joystick;
    [Header("變形元件")]
    public Transform tra;
    [Header("動畫元件")]
    public Animator ani;

    private void Move()
    {
        float h = joystick.Horizontal;
        ani.SetBool("等待", h != 0);

        //if (Input.) ani.SetBool("等待", true);
        //if (Input.) ani.SetBool("等待", false);
    }

    private void Attack()
    {

    }

    private void Hit()
    {

    }

    private void Dead()
    {

    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
}
