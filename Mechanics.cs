using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
public class Mechanics : Form
{
	public Button Vel, Acc, FVel, Dis;
	public Mechanics()
	{
		InitializeComponent();
		InitializeVel();
		InitializeAcc();
		InitializeFVel();
		InitializeDis();
	}
	public void InitializeVel()
	{
		Vel = new Button();
		Vel.Size = new Size(80, 30);
		Vel.Location = new Point(30,30);
		Vel.Text = "Velocity.";
		this.Controls.Add(Vel);
	    Vel.Click += new EventHandler(Velocity_Click);	//adds the event to take action when the button is clicked
	}
	public void InitializeAcc()
	{
		Acc = new Button();
		Acc.Size = new Size(80,30);
		Acc.Location = new Point(30,70);
		Acc.Text = "Acceleration";
		this.Controls.Add(Acc);
		Acc.Click += new EventHandler(Acceleration_Click);
	}
	public void InitializeFVel()
	{
		FVel = new Button();
		FVel.Size = new Size(80,30);
		FVel.Location = new Point(30,110);
		FVel.Text = "Final Velocity";
		this.Controls.Add(FVel);
		FVel.Click += new EventHandler(FinalVelocity_Click);
	}
	public void InitializeDis()
	{
		Dis = new Button();
		Dis.Size = new Size(80,30);
		Dis.Location = new Point(30,150);
		Dis.Text = "Displacement\\Distance";
		this.Controls.Add(Dis);
		Dis.Click += new EventHandler(DisplacementDistance_Click);
	}
	public void Velocity_Click(object sender, EventArgs e)
	{
		Velocity input = new Velocity();
		input.act();
	}
	public void Acceleration_Click(object sender, EventArgs e)
	{
		Acceleration input = new Acceleration();
		input.act();
	}
	public void FinalVelocity_Click(object sender, EventArgs e)
	{
		FinalVelocity input = new Final_Velocity();
		input.act();
	}
	public void DisplacementDistance_Click(object sender, EventArgs e)
	{
		DisplacementDistance input = new DisplacementDistance();
		input.act();
	}
	public void act()
	{	
		Show();
	}
	public void InitializeComponent()
	{
		this.Width = 500;
		this.Height = 400;
		this.Text = "Physics Calculaor - Mechanics";
		this.BackColor = Color.LightBlue;
	}
}