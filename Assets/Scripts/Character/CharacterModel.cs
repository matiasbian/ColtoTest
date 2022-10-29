using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterModel
{
    public float speed;
    public enum Direction {Top, Left, Down, Right}
    public Direction direction = Direction.Top;
    Animator animator;
    public CharacterModel (float speed, Animator animator) {
        this.speed = speed;
        this.animator = animator;
    }

    public void UpdateCurrentDirection (float x, float y) {
        bool isMoving = x != 0 || y != 0;
        animator.SetBool("Walking", isMoving);
        if (!isMoving) return;
        if (x==1) {
            direction = Direction.Right;
        } else if (x==-1){
            direction = Direction.Left;
        } else if (y==1) {
            direction = Direction.Top;
        }else {
            direction = Direction.Down;
        }
    }
}
