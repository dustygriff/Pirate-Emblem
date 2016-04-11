/*
 * Created by SharpDevelop.
 * User: Jason
 * Date: 4/8/2016
 * Time: 2:40 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Engine
{
	/// <summary>
	/// Game Engine
	/// </summary>
	public class PEngine
	{
        Unit unit;

		public PEngine()
        {
            unit = new Unit(1, 1, 1, 1, 1, 1, 1, 1, 1, "Images/test2.png");
        }

        public void Draw(BufferedGraphics buff, int count)
        {
            unit.Draw(20, 20, 32, 32, buff, count);
        }
	}
}