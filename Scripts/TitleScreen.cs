using Godot;


public class TitleScreen : Node2D
{
	public override void _Ready()
	{
		
	}

	public override void _PhysicsProcess(float delta)
	{
		base._PhysicsProcess(delta);
	 }
	public void on_Button_pressed()
	{
		// Replace with function body.
	//	 GD.Print("555");
	    GetTree().ChangeScene("res://StageOne.tscn");
		Player.ismoving =Player2.ismoving =true;

	}

	public void on_Button2_pressed()
    {
		GetTree().Quit();
    }

}
