 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
	public abstract class RobotSpy
	{
		private string model;
		private DateTime creationDate;
		private double batteryStatus; 

		//1. עדכנו את הפעולה הבונה כך שתקבל פרמטרים בהתאם לתכונות
		public RobotSpy(string model, DateTime creationDate, double batteryStatus)
		{
			this.model = model;
			this.creationDate = creationDate;
			this.batteryStatus = batteryStatus;
		}
		public string GetModel() { 	return this.model; }

		public double GetBatteryStatus() { return this.batteryStatus; }
		public void SetBatteryStatus(double batteryStatus)
		{
			this.batteryStatus = batteryStatus;
		}

		public abstract void MoveForward();
		public abstract void MoveBackward();
		public abstract void TurnLeft();
		public abstract void TurnRight();

		public void TakePicture() 
		{
			if(batteryStatus < 5)
			{
				Console.WriteLine("charge first!");
			}
			else
			{
				Console.WriteLine("taking pic...");
				batteryStatus -= 5;
			}
		} 
		public void ChargeBattery()
		{
			Console.WriteLine("charging....");
            System.Threading.Thread.Sleep(5000);
        }   
	}
}
