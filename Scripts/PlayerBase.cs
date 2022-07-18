using Godot;
using System;

public class PlayerBase : KinematicBody2D
{
   protected float speed = 180;
   protected int gravity = 15;
   protected int jumpPower = -350;
   protected Vector2 floor = new Vector2(0, -1);
   protected Vector2 velocity = new Vector2();
   protected bool onGround = false;
  //  protected public static bool ismoving = true;
   protected AnimatedSprite sprite;

}
