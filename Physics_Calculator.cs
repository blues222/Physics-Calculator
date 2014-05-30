using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
public class Physics_CalculatorV2 : Form
{
	public Button Mech;
	
	public Physics_CalculatorV2()
	{
		InitializeComponent();
		InitializeMech();
		
	}
	public void InitializeMech()
	{
		Mech = new Button();
		Mech.Size = new Size(80,30);
		Mech.Location = new Point(30,50);
		Mech.Text = "Mechanics";
		this.Controls.Add(Mech);
		Mech.Click += new EventHandler(Mechanics_Click);
	}
	public void Mechanics_Click(object sender, EventArgs e)
	{
		Mechanics win = new Mechanics();
		win.act();
	}
	public static void Main()
	{
		Application.EnableVisualStyles();
		Application.Run(new Physics_CalculatorV2());
	}
	private void InitializeComponent()
	{
		this.Width = 500;
		this.Height = 400;
		this.Text = "Physics Calculator";
		this.BackColor = Color.LightBlue;
	}
}
	