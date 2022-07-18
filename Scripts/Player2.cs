using Godot;
using System;

public class Player2 : PlayerBase
{
    public static bool ismoving = true;
    public static int Player2Score = 0 ;

    public override void _Ready()
    {
        sprite = (AnimatedSprite)GetNode("AnimatedSprite");
    }

    public override void _PhysicsProcess(float delta)
    {
        //     base._PhysicsProcess(delta);
        if (ismoving)
        {
            if (Input.IsActionPressed("ui_right"))
            {
                velocity.x = speed;
                sprite.Play("Walk");
                sprite.FlipH = false;
            }
            else if (Input.IsActionPressed("ui_left"))
            {
                velocity.x = -speed;
                sprite.Play("Walk");
                sprite.FlipH = true;
            }
            else
            {
                velocity.x = 0;
                if (onGround)
                    sprite.Play("Idle");
            }

            if (Input.IsActionPressed("ui_up") && onGround)
            {
                velocity.y = jumpPower;
                onGround = false;
            }
            if (Input.IsActionPressed("Kick2"))
            {
                sprite.Play("Kick");
            }

            velocity.y += gravity;

            if (IsOnFloor())
                onGround = true;
            else
            {
                onGround = false;
                if (velocity.y < 0)
                    sprite.Play("Jump");
                else
                    sprite.Play("Fall");
            }

            velocity = MoveAndSlide(velocity, floor);
        }
    }
}


