using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
public class FinalVelocity : Form
{
	private Button Submit;
	private TextBox vf1, vi1, a1, t1;
	private Label vf2, vi2, a2, t2, info, answer; 
	private double vf3, vi3, a3, t3;
	private String vf4, vi4, a4, t4;
	
	public FinalVelocity()
	{
		
		Submit = new Button();
		
		vf1 = new TextBox();
		vi1 = new TextBox();
		a1 = new TextBox();
		t1 = new TextBox();
		
		vf2 = new Label();
		vi2 = new Label();
		a2 = new Label();
		t2 = new Label();
		
		info = new Label();
		answer = new Label();
		
		InitializeButton();
		InitializeLabel();
		InitializeTextBox();
	
		
		vf3 = -1;
		vi3 = -1;
		a3 = -1;
		t3 = -1;
	
		vf4 = null;
		vi4 = null;
		a4 = null;
		t4 = null;
	
		this.Text = "Final Velocity";
		this.Height = 380;
		this.Width = 400;
		this.BackColor = Color.LightBlue;
	}
	public void InitializeButton()
	{
		Submit.Size = new Size(80, 20);
		Submit.Location = new Point(70,300);
		Submit.Text = "Submit";
		this.Controls.Add(Submit);
		Submit.Click += new EventHandler(Submit_Click);	
	
	}
	public void InitializeLabel()
	{
		vf2.Size = new Size(80,30);
		vf2.Location = new Point(80,100);
		vf2.Text = "Final Velocity";
		this.Controls.Add(vf2);
		
		vi2.Size = new Size(80,30);
		vi2.Location = new Point(80,150);
		vi2.Text = "Initial Velocity";
		this.Controls.Add(vi2);
		
		a2.Size = new Size(80,30);
		a2.Location = new Point(80,200);
		a2.Text = "Acceleration";
		this.Controls.Add(a2);
	
		t2.Size = new Size(80,30);
		t2.Location = new Point(80,250);
		t2.Text = "Time";
		this.Controls.Add(t2);
		
		info.Size = new Size(200,50);
		info.Location = new Point(55, 15);
		info.Font = new Font(info.Font.FontFamily, 10);
		info.Text = "Leave the value you're trying to find blank. Vf = Vi + 2at";
		this.Controls.Add(info);
	
		answer.Size = new Size(80,20);
		answer.Location = new Point(150,300);
		answer.Text = "";
		this.Controls.Add(answer);
	}
	public void InitializeTextBox()
	{
		vf1.Size = new Size(80,30);
		vf1.Location = new Point(170,100);
		this.Controls.Add(vf1);
		
		vi1.Size = new Size(80,30);
		vi1.Location = new Point(170,150);
		this.Controls.Add(vi1);
		
		a1.Size = new Size(80,30);
		a1.Location = new Point(170,200);
		this.Controls.Add(a1);
		
		t1.Size = new Size(80,30);
		t1.Location = new Point(170,250);
		this.Controls.Add(t1);
	}
	public void act()
	{
		Show();
	}
	public void Submit_Click(object sender, EventArgs e)
	{
		
		vf4 = vf1.Text;
		vi4 = vi1.Text;
		a4 = a1.Text;
		t4 = t1.Text;
		
		if(vf4 == "")
			CalculateVf(vi4,a4,t4);
		else if(vi4 == "")
			CalculateVi(vf4,a4,t4);
		else if(a4 == "")
			CalculateA(vf4,vi4,t4);
		else if(t4 == "")
			CalculateT(vf4,vi4,a4);
		
	}
	public double toDouble(string value)
	{
		try
		{
			double c = Double.Parse(value);
			return c;
		}
		catch
		{
			MessageBox.Show("2 or more values have either been left blank/filled in\nor invalid values have been entered. Given answer has been replaced with \"1\" ", "Error");
		}
		return 1.0;
	}
	public void CalculateVf(string vi, string a, string t)
	{
		vi3 = toDouble(vi);
		a3 = toDouble(a);
		t3 = toDouble(t);

		double vf = vi3 + a3 * t3;
		answer.Text = Convert.ToString(vf) + "m/s";
	}
	public void CalculateVi(string vf, string a, string t)
	{
		vf3 = toDouble(vf);
		a3 = toDouble(a);
		t3 = toDouble(t);
		double vi = (vf3) - (a3 * t3);
		answer.Text = Convert.ToString(vi) + "m/s";
	}
	public void CalculateT(string vf, string vi, string a)
	{
		a3 = toDouble(a);
		vi3 = toDouble(vi);
		vf3 = toDouble(vf);
		if(a3 == 0)
			MessageBox.Show("Cannot divide by zero", "Error");

		double t = (vf3 - vi3)/a3;
		answer.Text = Convert.ToString(t) + "s";
	}
	public void CalculateA(string vf, string vi, string t)
	{
		vf3 = toDouble(vf);
		vi3 = toDouble(vi);
		t3 = toDouble(t);
		if(t3 == 0)
			MessageBox.Show("Cannot divide by zero", "Error");

		double a = (vf3 - vi3)/t3;
		answer.Text = Convert.ToString(a) + "m/s squared";
	}
}	