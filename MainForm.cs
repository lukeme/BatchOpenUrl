/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2016/8/2
 * Time: 8:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BatchOpenUrl
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			string[] tempArray = new string[textBox1.Lines.Length];
            tempArray = textBox1.Lines;
			for(int i=0;i<textBox1.Lines.Length;i++){
            	string url = tempArray[i];
            	//MessageBox.Show(url,"第"+(i+1)+"行url:");
            	System.Diagnostics.Process.Start("IEXPLORE.EXE", url);
			}
             
		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
		}
	}
}
