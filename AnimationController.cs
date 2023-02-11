using System;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public enum AnimList { IDLE, WALK, RUN, ATTACK }
    AnimList animNowSelect = AnimList.IDLE;
    public void PlayAnim(AnimList animName)
    {
        if (animNowSelect == animName)
            return;

        foreach (AnimList item in (AnimList[])Enum.GetValues(typeof(AnimList)))
            animator.SetBool(item.ToString(), item == animName);

        animNowSelect = animName;
    }

}
