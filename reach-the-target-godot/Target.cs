
using Godot;

public partial class Target : Area2D
{
	private Label message;

	public override void _Ready()
	{
		message = GetNode<Label>("../Message");
	}

	private void _on_body_entered(Node2D body)
	{
		if (body.Name == "Player")
		{
			GD.Print("TARGET REACHED!");
			message.Text = "TARGET REACHED!";
		}
	}
}
