using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Petrushyn_program
{
	public class Warframe
	{
		private WarframeSex sex;
		private uint mods_count;
		private string name;
		private WarframeType type;
		private ushort lvl;


		public WarframeSex Sex
		{
			get;
			set;
		}
		public WarframeType Type
		{
			get;
			set;			
		}
		public ushort Lvl 
		{
			get {return lvl;}
			set 
			{
				if (value >= 0 && value <= 30)
					lvl = value;
				else MessageBox.Show("Рівень лежить в межах від 0 до 30");
			} 
		}
		public string Name
		{
			get { return name;}
			set 
			{
				if (value.Length >= 2)
					name = value;
				else MessageBox.Show("Назва складається мінімум з 2 літер");
			}
		}
	
		public uint Mods_count
		{
			get { return mods_count; }
			set
			{
				if (type == WarframeType.Прайм && value >= 0 && value <= 12)
					mods_count = value;
				else if (value >= 0 && value <= 6)
					mods_count = value;
				else MessageBox.Show("У не поляризованого варфрейма максимум 6 модів, у поляризованого 12");
			}
		}

		public string All_char
		{
			get { return "Це " + Name + ", з рівнем: " + Lvl + ", з кількістю модів: "+ Mods_count + ", типу: " + Type + ", статі: " + Sex; }
		}

		public string Ressuract { get; } = "Так";
	};

	public enum WarframeSex
	{
		Чоловіча,
		Жіноча
	};

	public enum WarframeType
	{
		Прайм,
		Звичайний
	};
		
	
}
