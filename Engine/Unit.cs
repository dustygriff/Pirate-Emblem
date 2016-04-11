/*
 * Created by SharpDevelop.
 * User: Jason
 * Date: 4/8/2016
 * Time: 3:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace Engine
{
	/// <summary>
	/// Unit class contains all necessary information about crewmember pertaining to combat as well as functionality to draw the sprite.
	/// </summary>
	public class Unit
	{
        public AnimatedSprite Sprite_;
		
		#region General Stats
		public UInt16 Constitution_;
		public UInt16 Defense_;
		public UInt16 Health_;
		public UInt16 Level_; //Is an Accumulating number i.e 456 = Level 4 with 56/100 experience
		public UInt16 Luck_;
		public UInt16 Movement_;
		public UInt16 Speed_;
		public UInt16 Skill_;
		public UInt16 Strength_;
		#endregion
		
		#region Weapon Stats
		public UInt16 AxeLvl_;
		public UInt16 BowLvl_;
		public UInt16 GunLvl_;
		public UInt16 PikeLvl_;
		public UInt16 SwordLvl_;
		#endregion
		
		
		//Test comment
		public Unit(
			UInt16 con,
			UInt16 def,
			UInt16 hp,
			UInt16 lvl,
			UInt16 lck,
			UInt16 mov,
			UInt16 spd,
			UInt16 skl,
			UInt16 str, 
            String filepath)
		{
			Constitution_ = con; 
			Defense_ = def;
			Health_ = hp;
			Level_ = lvl;
			Luck_ = lck;
			Movement_ = mov;
			Speed_ = spd;
			Skill_ = skl;
			Strength_ = str;

            Sprite_ = new AnimatedSprite(filepath);
		}

        public void Draw(int x, int y, int w, int l, BufferedGraphics buff, int count)
        {
            Sprite_.Draw(x, y, w, l, buff, count);
        }
		
		#region Setters
		public void SetConstitution(UInt16 con)
		{
			Constitution_ = con;
		}
		
		public void SetDefense(UInt16 def)
		{
			Defense_ = def;
		}
		
		public void SetHealth(UInt16 hp)
		{
			Health_ = hp;
		}
		
		public void SetLevel(UInt16 lvl)
		{
			Level_ = lvl;
		}
		
		public void SetLuck(UInt16 lck)
		{
			Luck_ = lck;
		}
		
		public void SetMovement(UInt16 mov)
		{
			Movement_ = mov;
		}
		
		public void SetSpeed(UInt16 spd)
		{
			Speed_ = spd;
		}
		
		public void SetSkill(UInt16 skl)
		{
			Skill_ = skl;
		}
		
		public void SetStrength(UInt16 str)
		{
			Strength_ = str;
		}
		#endregion
	}
}
