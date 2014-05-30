using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
public class DisplacementDistance : Form
{
	private Button Submit;
	private TextBox txtDis, txtIniVel, txtTim, txtAcc;
	private Label lblDis, lblIniVel, lblTim, lblAcc, lblInfo, lblAnswer;
	private double d3, vi3, t3, a3;
	private String d4, vi4, t4, a4;
	
	public DisplacementDistance()
	{
		Submit = new Button();

		txtDis = new TextBox();
		txtIniVel = new TextBox();
		txtTim = new TextBox();
		txtAcc = new TextBox();

		lblDis = new Label();
		lblIniVel = new Label();
		lblTim = new Label();
		lblAcc = new Label();
		
		lblInfo = new Label();
		lblAnswer = new Label();

		d3 = -1;
		vi3 = -1;
		t3 = -1; 
		a3 = -1;

		d4 = null;
		vi4 = null; 
		t4 = null;
		a4 = null;

		InitializeButton();
		InitializeTextBox();
		InitializeLabel();	
		
		this.Text = "Displacement / Distance";
		this.BackColor = Color.LightBlue;
	}
	private void InitializeButton()
	{
		Submit.Size = new Size(80,20);
		Submit.Location = new Point(70,200);
		Submit.Text = "Submit";
		this.Controls.Add(Submit);
		Submit.Click += new EventHandler(Submit_Click);
	}
	private void InitializeTextBox()
	{
		txtDis.Size = new Size(80,30);
		txtDis.Location = new Point(150,100);
		this.Controls.Add(txtDis);

		txtIniVel.Size = new Size(80,30);
		txtIniVel.Location = new Point(150,150);
		this.Controls.Add(txtIniVel);

		txtTim.Size = new Size(80,30);
		txtTim.Location = new Point(150,200);
		this.Controls.Add(txtTim);

		txtDis.Size = new Size(80,30);
		txtDis.Location = new Point(150,250);
		this.Controls.Add(txtDis);
	}
	private void InitializeLabel()
	{
		lblDis.Size = new Size(80,30);
		lblDis.Location = new Point(80,100);
		lblDis.Text = "Displacement / Distance";
		this.Controls.Add(lblDis);

		lblIniVel.Size = new Size(80,30);
		lblIniVel.Location = new Point(80,100);
		lblIniVel.Text = "Initial Velocity";
		this.Controls.Add(lblIniVel);

		lblAcc.Size = new Size(80,30);
		lblAcc.Location = new Point(80,100);
		lblAcc.Text = "Acceleration";
		this.Controls.Add(lblAcc);

		lblTim.Size = new Size(80,30);
		lblTim.Location = new Point(80,100);
		lblTim.Text = "Time";
		this.Controls.Add(lblTim);

		lblInfo.Size = new Size(80,30);
		lblInfo.Location = new Point(80,100);
		lblInfo.Text = "Leave the value you're trying to find blank";
		this.Controls.Add(lblInfo);

		lblAnswer.Size = new Size(80,30);
		lblAnswer.Location = new Point(80,100);
		lblAnswer.Text = "Final Velocity";
		this.Controls.Add(lblAnswer);
	}
	public void Submit_Click(object Sender, EventArgs e)
	{
		d4 = txtDis.Text;
		vi4 = txtIniVel.Text; 
		t4 = txtTim.Text;
		a4 = txtAcc.Text;

		d3 = toDouble(d4);
		vi3 = toDouble(vi4); 
		t3 = toDouble(t4);
		a3 = toDouble(a4);
	}
	public void act()
	{
		Show();
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
}