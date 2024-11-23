using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class Entity : MonoBehaviour
{
    public Animator anim { get; private set; }
    public Rigidbody2D rb { get; private set; }
    public SpriteRenderer sr { get; private set; }
    public CapsuleCollider2D cd { get; private set; }

    bool facingRight = true;
    public int facingDir { get; private set; } = 1;
    

    protected virtual void Awake()
    {

    }
    protected virtual void Start()
    {
        anim = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        cd = GetComponent<CapsuleCollider2D>();
        
    }

    protected virtual void Update()
    {

    }

    //角色速度设置
    #region Velocity
    public void SetZeroVelocity()
    {
        rb.velocity = new Vector2(0, 0);
    }
    public void SetVelocity(float _xVelocity, float _yVelocity)
    {

        rb.velocity = new Vector2(_xVelocity, _yVelocity);
        FlipController(_xVelocity);
    }
    #endregion

    //角色翻转功能
    #region Flip
    protected virtual void Flip()
    {
        facingDir = facingDir * -1;
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }
    protected virtual void FlipController(float _x)
    {
        if(_x>0 && !facingRight)
        {
            Flip();
        }
        else if(_x<0 && facingRight)
        {
            Flip();
        }
    }
    #endregion

    #region Collision
    //public virtual bool IsWallDetected() => Physics2D.Raycast(wallCheck.position, Vector2.right * facingDir, wallCheckDistance, whatIsGround);
    //protected virtual void OnDrawGizmos()
    //{
    //    Gizmos.DrawLine(wallCheck.position, new Vector3(wallCheck.position.x + wallCheckDistance, wallCheck.position.y));ius);
    //}
    #endregion

    public virtual void Die()
    {

    }


}
