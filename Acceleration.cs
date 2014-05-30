using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
public class Acceleration : Form
{
	private Button Submit;
	private TextBox v1, a1, t1;
	private Label v2, a2, t2, info, answer; 
	private double v3, a3, t3;
	private String v4, a4, t4;
	
	public Acceleration()
	{
		
		Submit = new Button();
		
		v1 = new TextBox();
		a1 = new TextBox();
		t1 = new TextBox();
		
		v2 = new Label();
		a2 = new Label();
		t2 = new Label();
		
		info = new Label();
		answer = new Label();
		
		InitializeTextBox();
		InitializeLabel();
		InitializeButton();
	
		
		v3 = -1;
		a3 = -1;
		t3 = -1;
	
		v4 = null;
		a4 = null;
		t4 = null;
	
		this.Text = "Acceleration";
		this.BackColor = Color.LightBlue;
	}
	public void InitializeTextBox()
	{
		a1.Size = new Size(80,30);
		a1.Location = new Point(170,50);
		this.Controls.Add(a1);
		
		v1.Size = new Size(80,30);
		v1.Location = new Point(170,100);
		this.Controls.Add(v1);
		
		t1.Size = new Size(80,30);
		t1.Location = new Point(170,150);
		this.Controls.Add(t1);
	}
	public void InitializeLabel()
	{
		a2.Size = new Size(80,30);
		a2.Location = new Point(80,50);
		a2.Text = "Acceleration";
		this.Controls.Add(a2);
		
		v2.Size = new Size(80,30);
		v2.Location = new Point(80,100);
		v2.Text = "Velocity";
		this.Controls.Add(v2);
		
		t2.Size = new Size(80,30);
		t2.Location = new Point(80,150);
		t2.Text = "Time";
		this.Controls.Add(t2);
	
		info.Size = new Size(150,30);
		info.Location = new Point(80, 15);
		info.Text = "Leave the value you're trying to find blank. A = v/t";
		this.Controls.Add(info);
	
		answer.Size = new Size(80,20);
		answer.Location = new Point(150,200);
		answer.Text = "";
		this.Controls.Add(answer);
	
	}
	public void act()
	{
		Show();
	}
	public void InitializeButton()
	{
		Submit.Size = new Size(80, 20);
		Submit.Location = new Point(70,200);
		Submit.Text = "Submit";
		this.Controls.Add(Submit);
		Submit.Click += new EventHandler(Submit_Click);	
	
	}
	public void Submit_Click(object sender, EventArgs e)
	{
		
		v4 = v1.Text;
		a4 = a1.Text;
		t4 = t1.Text;
		
		if(v4 == "")
			CalculateV(a4,t4);
		else if(a4 == "")
			CalculateA(v4,t4);
		else if(t4 == "")
			CalculateT(v4,a4);
		
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
	public void CalculateV(string a, string t)
	{
		a3 = toDouble(a);
		t3 = toDouble(t);

		double v = a3 * t3;
		answer.Text = Convert.ToString(v) + "m/s";
	}
	public void CalculateA(string v, string t)
	{
		v3 = toDouble(v);
		t3 = toDouble(t);
		if(t3 == 0)
			MessageBox.Show("Cannot divide by zero", "Error");
		
		double a = v3 / t3;
		answer.Text = Convert.ToString(a) + "m/s\xB2"; // The \xB2 creates a superscript with the number 2 as the superscript
	}
	public void CalculateT(string v, string a)
	{
		a3 = toDouble(a);
		v3 = toDouble(v);
		if(a3 == 0)
			MessageBox.Show("Cannot divide by zero", "Error");

		double t = v3/a3;
		answer.Text = Convert.ToString(t) + "s";
	}
}	