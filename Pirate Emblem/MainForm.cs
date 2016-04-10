/*
 * Created by SharpDevelop.
 * User: Jason
 * Date: 4/8/2016
 * Time: 2:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Engine;

namespace Pirate_Emblem
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
        PEngine GameEngine_;

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

            this.BackColor = Color.Aquamarine;

            GameEngine_ = new PEngine();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        protected override void OnPaint(PaintEventArgs e)
        {
            GameEngine_.Draw(e.Graphics);

            base.OnPaint(e);
        }
    }
}
