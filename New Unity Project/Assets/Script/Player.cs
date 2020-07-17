using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("攻擊"), Range(0, 1000)]
    public int ATK;
    [Header("防禦"), Range(0, 1000)]
    public int DEX;
    [Header("血量"), Range(0, 1000)]
    public float HP;
    [Header("魔力"), Range(0, 1000)]
    public float MP;
    [Header("技能一")]
    public string skill1;
    [Header("技能一耗魔量"), Range(0, 1000)]
    public float S1MP;
    [Header("技能二")]
    public string skill2;
    [Header("技能二耗魔量"), Range(0, 1000)]
    public float S2MP;
    [Header("死亡")]
    public bool Dead;
    [Header("速度"), Range(0, 1000)]
    public float Speed;

    /// <summary>
    /// 移動
    /// </summary>
    public void MOVE()
    {
        
    }
    /// <summary>
    /// 技能1
    /// </summary>
    public void S1()
    {

    }
    public void S2()
    {


    }
    /// <summary>
    /// 受傷
    /// </summary>
    public void Hurt()
    {

    }
    /// <summary>
    /// 死亡
    /// </summary>
    public void DEAD()
    {

    }
    /// <summary>
    /// 攻擊
    /// </summary>
    public void Attack()
    {

    }

}

