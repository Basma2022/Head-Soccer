using Godot;
using System;

public class Ball : RigidBody2D
{
    Vector2 goal1 = new Vector2 (-320f , 150f);
    Vector2 goal2 = new Vector2(380f, 150f);
    public static bool ismoving = true;
    bool insideGoal1 = false, insideGoal2 = false;
    public override void _Ready()
    {
        
    }

  

    public override void _Process(float delta)
    {
        //  GD.Print(this.Position.y + "  "+ this.Position.x);
        if (ismoving)
        {
            if (this.Position.x < goal1.x && this.Position.y > goal1.y)
            {
                if (insideGoal1 == false)
                {
                    GameManager.Score(2);
                  
                    insideGoal1 = true;
                //  SetGlobalPosition(new Vector2(0, 0));
                //  SetPosition( new Vector2(0 , 0));
                }
            }
            else if (this.Position.x > goal2.x && this.Position.y > goal2.y)
            {
                if (insideGoal2 == false)
                {
                    GameManager.Score(1);
                    insideGoal2 = true;
                  //  SetGlobalPosition(new Vector2(0, 0));
                  //  SetPosition(new Vector2(0, 0));
                }
            }
            else
            {
                insideGoal1 = false;
                insideGoal2 = false;
            }

        }
       
    }
    public override void _IntegrateForces(Physics2DDirectBodyState state)
    {
        //  base._IntegrateForces(state);
        Transform2D pos = state.GetTransform();
        if (insideGoal1 || insideGoal2)
        {
            pos.origin.x = 478;
            pos.origin.y = 138;
            state.SetTransform(pos);
            //  SetSleeping(true);
            state.LinearVelocity = new Vector2(0,0);
            state.AngularVelocity = 0;
        }
        
        

    }

}
