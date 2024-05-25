/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/25/2024
 * Time: 8:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace meniuSelector
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
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		public class meniu
		{
			public List<string>meniustrip = new List<string>();
			public List<string>meniubar1 = new List<string>();
		}
		public void drawMenuStrip()
		{
			for(int i = 0 ; i < m.meniustrip.Count;i++)
			{
				this.Controls.Add(new Label());
				int c = this.Controls.Count-1;
				this.Controls[c].Left = (i+1)*70;
				this.Controls[c].Top = 2;
				this.Controls[c].Width = 60;
				this.Controls[c].Text = m.meniustrip[i];
				this.Controls[c].Visible = true;
				this.Controls[c].Click  += new System.EventHandler(meniuStripPressed);
				this.Refresh();
			}
		}
		
		public int firstBarControl = 0;
		public int lastBarControl = 0;
		
		public void drawMenuBar1()
		{
			for(int i = 0 ; i < m.meniubar1.Count;i++)
			{
			
				this.Controls.Add(new Label());
				int c = this.Controls.Count-1;
				if(i==0){firstBarControl = c;}
				if(i==m.meniubar1.Count-1){lastBarControl = c;}
				this.Controls[c].Left = 70;
				this.Controls[c].Top = (i+1)*30;
				this.Controls[c].Width = 60;
				this.Controls[c].Height = 30;
				this.Controls[c].Text = m.meniubar1[i];
				this.Controls[c].Visible = true;
				this.Controls[c].Click  += new System.EventHandler(meniuStripPressed);
				this.Refresh();
			}
		}
		public void drawMenuBar2()
		{
			for(int i = 0 ; i < m.meniubar1.Count;i++)
			{
			
				this.Controls.Add(new Label());
				int c = this.Controls.Count-1;
				if(i==0){firstBarControl = c;}
				if(i==m.meniubar1.Count-1){lastBarControl = c;}
				this.Controls[c].Left = 70*2;
				this.Controls[c].Top = (i+1)*30;
				this.Controls[c].Width = 60;
				this.Controls[c].Height = 30;
				this.Controls[c].Text = m.meniubar1[i];
				this.Controls[c].Visible = true;
				this.Controls[c].Click  += new System.EventHandler(meniuStripPressed);
				this.Refresh();
			}
		}
		public void drawMenuBar3()
		{
			for(int i = 0 ; i < m.meniubar1.Count;i++)
			{
			
				this.Controls.Add(new Label());
				int c = this.Controls.Count-1;
				if(i==0){firstBarControl = c;}
				if(i==m.meniubar1.Count-1){lastBarControl = c;}
				this.Controls[c].Left = 70*3;
				this.Controls[c].Top = (i+1)*30;
				this.Controls[c].Width = 60;
				this.Controls[c].Height = 30;
				this.Controls[c].Text = m.meniubar1[i];
				this.Controls[c].Visible = true;
				this.Controls[c].Click  += new System.EventHandler(meniuStripPressed);
				this.Refresh();
			}
		}
		
		public void drawMenuBar4()
		{
			for(int i = 0 ; i < m.meniubar1.Count;i++)
			{
			
				this.Controls.Add(new Label());
				int c = this.Controls.Count-1;
				if(i==0){firstBarControl = c;}
				if(i==m.meniubar1.Count-1){lastBarControl = c;}
				this.Controls[c].Left = 70*4;
				this.Controls[c].Top = (i+1)*30;
				this.Controls[c].Width = 60;
				this.Controls[c].Height = 30;
				this.Controls[c].Text = m.meniubar1[i];
				this.Controls[c].Visible = true;
				this.Controls[c].Click  += new System.EventHandler(meniuStripPressed);
				this.Refresh();
			}
		}
		public void drawMenuBar5()
		{
			for(int i = 0 ; i < m.meniubar1.Count;i++)
			{
			
				this.Controls.Add(new Label());
				int c = this.Controls.Count-1;
				if(i==0){firstBarControl = c;}
				if(i==m.meniubar1.Count-1){lastBarControl = c;}
				this.Controls[c].Left = 70*5;
				this.Controls[c].Top = (i+1)*30;
				this.Controls[c].Width = 60;
				this.Controls[c].Height = 30;
				this.Controls[c].Text = m.meniubar1[i];
				this.Controls[c].Visible = true;
				this.Controls[c].Click  += new System.EventHandler(meniuStripPressed);
				this.Refresh();
			}
		}
		public void drawMenuBar6()
		{
			for(int i = 0 ; i < m.meniubar1.Count;i++)
			{
			
				this.Controls.Add(new Label());
				int c = this.Controls.Count-1;
				if(i==0){firstBarControl = c;}
				if(i==m.meniubar1.Count-1){lastBarControl = c;}
				this.Controls[c].Left = 70*6;
				this.Controls[c].Top = (i+1)*30;
				this.Controls[c].Width = 60;
				this.Controls[c].Height = 30;
				this.Controls[c].Text = m.meniubar1[i];
				this.Controls[c].Visible = true;
				this.Controls[c].Click  += new System.EventHandler(meniuStripPressed);
				this.Refresh();
			}
		}
		public void drawMenuBar7()
		{
			for(int i = 0 ; i < m.meniubar1.Count;i++)
			{
			
				this.Controls.Add(new Label());
				int c = this.Controls.Count-1;
				if(i==0){firstBarControl = c;}
				if(i==m.meniubar1.Count-1){lastBarControl = c;}
				this.Controls[c].Left = 70*7;
				this.Controls[c].Top = (i+1)*30;
				this.Controls[c].Width = 60;
				this.Controls[c].Height = 30;
				this.Controls[c].Text = m.meniubar1[i];
				this.Controls[c].Visible = true;
				this.Controls[c].Click  += new System.EventHandler(meniuStripPressed);
				this.Refresh();
			}
		}
		
		public meniu m = new meniu();
		string s = "System.Windows.Forms.Label, Text: ";
		
		protected void meniuStripPressed(object sender, EventArgs e)
		{
			string t = sender.ToString();
			int k = t.Length - s.Length;
			string ms = t.Substring(t.Length-k,k);
			textBox1.Text = ms;
			Text = t;
			string mms = m.meniustrip[0];
			
			//delete all ex bar menius
			int c = this.Controls.Count-1;
			if(lastBarControl >0 && firstBarControl >0){
			for(int i = lastBarControl ; i >= firstBarControl;i--)
			{
				c = this.Controls.Count-1;
				this.Controls.Remove(this.Controls[i]);
				Refresh();
			}
			lastBarControl = 0;
			firstBarControl = 0;
			}
			//
			
			if( ms == mms)
			{
				this.button1.BackColor = Color.Green;
				drawMenuBar1();
			}
			else if(ms ==m.meniustrip[1])
			{
				this.button1.BackColor = Color.Green;
				drawMenuBar2();
			}
			else if(ms ==m.meniustrip[2])
			{
				this.button1.BackColor = Color.Green;
				drawMenuBar3();
			}
			else if(ms ==m.meniustrip[3])
			{
				this.button1.BackColor = Color.Green;
				drawMenuBar4();
			}
			else if(ms ==m.meniustrip[4])
			{
				this.button1.BackColor = Color.Green;
				drawMenuBar5();
			}
			else if(ms ==m.meniustrip[5])
			{
				this.button1.BackColor = Color.Green;
				drawMenuBar6();
			}
			else if(ms ==m.meniustrip[6])
			{
				this.button1.BackColor = Color.Green;
				drawMenuBar7();
			}
		}
		public void addStripStrings()
		{
			m.meniustrip.Add("File");
			m.meniustrip.Add("Edit");
			m.meniustrip.Add("View");
			m.meniustrip.Add("Search");
			m.meniustrip.Add("Tools");
			m.meniustrip.Add("Window");
			m.meniustrip.Add("Help");
		}
		public void addBar1Strings()
		{
			m.meniubar1.Add("New");
			m.meniubar1.Add("Open");
			m.meniubar1.Add("Close");
			m.meniubar1.Add("Print");
			m.meniubar1.Add("Tools");
			m.meniubar1.Add("SaveAS");
			m.meniubar1.Add("Exit");
		}
		void Button1Click(object sender, EventArgs e)
		{
			addStripStrings();
			drawMenuStrip();
			addBar1Strings();
		}
	}
}
