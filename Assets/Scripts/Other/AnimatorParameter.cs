using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 待更改的状态机参数
/// </summary>
public static class AnimatorParameter
{
    //待更改
    //public static readonly int MovementID = Animator.StringToHash("Movement");
    public static readonly int MovementID = Animator.StringToHash("移动速度");
    //public static readonly int HorizontalID = Animator.StringToHash("Horizontal");
    public static readonly int HorizontalID = Animator.StringToHash("水平速度");
    //public static readonly int VerticalID = Animator.StringToHash("Vertical");
    public static readonly int VerticalID = Animator.StringToHash("垂直速度");

    public static readonly int HasInputID = Animator.StringToHash("HasInput");
    public static readonly int LockID = Animator.StringToHash("Lock");
    public static readonly int RunID = Animator.StringToHash("Run");
    public static readonly int DeltaAngleID = Animator.StringToHash("DeltaAngle");
    public static readonly int OnGroundID = Animator.StringToHash("OnGround");
    public static readonly int AnimationSpeedID = Animator.StringToHash("AnimationSpeed");
    public static readonly int DeadID = Animator.StringToHash("Dead");
    public static readonly int ParryID = Animator.StringToHash("Parry");
}
