using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �����ĵ�״̬������
/// </summary>
public static class AnimatorParameter
{
    //������
    //public static readonly int MovementID = Animator.StringToHash("Movement");
    public static readonly int MovementID = Animator.StringToHash("�ƶ��ٶ�");
    //public static readonly int HorizontalID = Animator.StringToHash("Horizontal");
    public static readonly int HorizontalID = Animator.StringToHash("ˮƽ�ٶ�");
    //public static readonly int VerticalID = Animator.StringToHash("Vertical");
    public static readonly int VerticalID = Animator.StringToHash("��ֱ�ٶ�");

    public static readonly int HasInputID = Animator.StringToHash("HasInput");
    public static readonly int LockID = Animator.StringToHash("Lock");
    public static readonly int RunID = Animator.StringToHash("Run");
    public static readonly int DeltaAngleID = Animator.StringToHash("DeltaAngle");
    public static readonly int OnGroundID = Animator.StringToHash("OnGround");
    public static readonly int AnimationSpeedID = Animator.StringToHash("AnimationSpeed");
    public static readonly int DeadID = Animator.StringToHash("Dead");
    public static readonly int ParryID = Animator.StringToHash("Parry");
}
