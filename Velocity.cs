using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
public class Velocity : Form 
{
	private Button Submit;
	private TextBox txtVel, txtDis, txtTim;
	private Label lblVel, lblDis, lblTim, lblInfo, lblAnswer, lblInfoV, lblInfoD, lblInfoT; 
	private double v3, d3, t3;
	private String v4, d4, t4;
	
	public Velocity()
	{
		Submit = new Button();
		
		txtVel = new TextBox();
		txtDis = new TextBox();
		txtTim = new TextBox();
		
		lblVel = new Label();
		lblDis = new Label();
		lblTim = new Label();
		
		lblInfoV = new Label();
		lblInfoD = new Label();
		lblInfoT = new Label();
		
		lblInfo = new Label();
		lblAnswer = new Label();
		
		InitializeTextBox();
		InitializeLabel();
		InitializeButton();
	
		
		v3 = -1;
		d3 = -1;
		t3 = -1;
	
		v4 = null;
		d4 = null;
		t4 = null;
		
		this.Text = "Velocity";
		this.BackColor = Color.LightBlue;
	}
	public void InitializeTextBox()
	{
		txtVel.Size = new Size(80,30);
		txtVel.Location = new Point(150,50);
		this.Controls.Add(txtVel);	//code that displays the textbox(works in conjunction with Show() )and above code initializes values
		
		txtDis.Size = new Size(80,30);
		txtDis.Location = new Point(150,100);
		this.Controls.Add(txtDis);
		
		txtTim.Size = new Size(80,60);
		txtTim.Location = new Point(150,150);
		this.Controls.Add(txtTim);
	}
	public void InitializeLabel()
	{
		lblTim.Size = new Size(80,30);
		lblTim.Location = new Point(80,50);
		lblTim.Text = "Velocity";
		this.Controls.Add(lblTim);
	
		lblDis.Size = new Size(80,30);
		lblDis.Location = new Point(80,100);
		lblDis.Text = "Distance";
		this.Controls.Add(lblDis);
		
		lblTim.Size = new Size(80,30);
		lblTim.Location = new Point(80,150);
		lblTim.Text = "Time";
		this.Controls.Add(lblTim);
	
		lblInfoV.Size = new Size(80,30);
		lblInfoV.Location = new Point(200,50);
		lblInfoV.Text = "m/s";
		this.Controls.Add(lblInfoV);
		
		lblInfoD.Size = new Size(480,30);
		lblInfoD.Location = new Point(200,100);
		lblInfoD.Text = "m";
		this.Controls.Add(lblInfoD);
		
		lblInfoT.Size = new Size(80,30);
		lblInfoT.Location = new Point(200,150);
		lblInfoT.Text = "t";
		this.Controls.Add(lblInfoT);
		
		lblInfo.Size = new Size(150,30);
		lblInfo.Location = new Point(80, 15);
		lblInfo.Text = "Leave the value you're trying to find blank. V = d/t";
		this.Controls.Add(lblInfo);
	
		lblAnswer.Size = new Size(80,20);
		lblAnswer.Location = new Point(150,200);
		lblAnswer.Text = "";
		this.Controls.Add(lblAnswer);
	
	}
	public void InitializeButton()
	{
		Submit.Size = new Size(80, 20);
		Submit.Location = new Point(70,200);
		Submit.Text = "Submit";
		this.Controls.Add(Submit);
		Submit.Click += new EventHandler(Submit_Click);	
	
	}
		public void act()
	{
		Show();
	}
	public void Submit_Click(object sender, EventArgs e)
	{
		
		v4 = txtVel.Text;
		d4 = txtDis.Text;
		t4 = txtTim.Text;
		

		if(v4 == "")
			CalculateV(d4,t4);
		else if(d4 == "")
			CalculateD(v4,t4);
		else if(t4 == "")
			CalculateT(v4,d4);
		
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
			MessageBox.Show("2 or more values have either been left blank/filled in\nor invalid values have been entered. Given lblAnswer has been replaced with \"1\" ", "Error");
		}
		return 1.0;
	}
	public void CalculateV(string d, string t)
	{	
		d3 = toDouble(d);
		t3 = toDouble(t);
		if(t3 == 0)
			MessageBox.Show("Cannot divide by zero", "Error");
	
		double v = d3/t3;
		lblAnswer.Text = Convert.ToString(v) + "m/s";	
		
				
		
	}
	public void CalculateD(string v, string t)
	{
			v3 = toDouble(v);
			t3 = toDouble(t);
		
			double d = v3 * t3;
			lblAnswer.Text = Convert.ToString(d) + "m";
	}
	public void CalculateT(string v, string d)
	{	
		d3 = toDouble(d);
		v3 = toDouble(v);
		if(v3 == 0)
		{
			MessageBox.Show("Cannot divide by zero", "Error");	
		}

		double t = d3/v3;
		lblAnswer.Text = Convert.ToString(t) + "s";

	}
}	