using Godot;
using System;

public class Ball2 : KinematicBody2D
{
    Vector2 velocity = new Vector2(250, 250);
    public override void _Ready()
    {
        
    }

    public override void _PhysicsProcess(float delta)
    {
        base._PhysicsProcess(delta);
        Godot.KinematicCollision2D coll = MoveAndCollide(velocity * delta);
        if(coll != null)
        {
            velocity = velocity.Bounce(coll.Normal);
        }
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
