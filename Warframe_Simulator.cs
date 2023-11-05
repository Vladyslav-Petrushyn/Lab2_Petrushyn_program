using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Lab1_Petrushyn_program
{
	public partial class MainForm : Form
	{
		public short WarfMaxCount;
		public int Credits;
		public int Reputation;
		public int Iterator = 0;
		private uint WarfCount = 0;
		List<Warframe> Collection = new List<Warframe>();
		

		public MainForm()
		{
			InitializeComponent();
			Sex_cb.Items.Add(WarframeSex.Чоловіча);
			Sex_cb.Items.Add(WarframeSex.Жіноча);
			Type_cb.Items.Add(WarframeType.Звичайний);
			Type_cb.Items.Add(WarframeType.Прайм);
			Ready_btn.Focus();
		}

		private Warframe Founder ()
		{
			// записуємо текст виділеного об'єкту в змінну
			string searching_name = Warframes_lb.SelectedItem.ToString(); 
			//шукаємо в коллекції об'єктів, об'єкт за властивістю name
			Warframe foundWarframe = Collection.FirstOrDefault(warframe_in => warframe_in.Name == searching_name);

			return foundWarframe;
		}

		private void Start_btn_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Введіть кількість ваших ворфреймів та натисніть кнопку 'Готово'", "Увага!");
			Count_tb.Enabled = true;
			Credits_tb.Enabled = true;
			Ready_btn.Enabled = true;
		}		

		private void Ready_btn_Click(object sender, EventArgs e)
		{

			try
			{
				// Запис кількості ворфреймів та кількості кредитів
				WarfMaxCount = short.Parse(Count_tb.Text);
				if (WarfMaxCount <= 0) 
					throw new Exception("Кількість ворфреймів має бути більше 0");

				Credits = int.Parse(Credits_tb.Text);
				if (Credits < 15000)
					throw new Exception("Мінімальний розмір бюджету 15000");

				Count_tb.Enabled = false;
				Credits_tb.Enabled = false;
				Ready_btn.Enabled = false;

				DoSmth_menu_btn.Enabled = true;
			}
			catch (OverflowException)
			{
				MessageBox.Show("Значення завелике або замаленьке", "Увага!");
			}
			catch (FormatException)
			{
				MessageBox.Show("Неправильний формат даних", "Увага!");
			}
			catch (Exception ex) 
			{
				MessageBox.Show(ex.ToString(), "Увага!");			
			}
		}
		
		private void buy_wm_btn_Click(object sender, EventArgs e)
		{
			

			//Списування грошей за купівлю варфрейму
			if (Credits < 15000)
			{
				MessageBox.Show("Недостатньо грошей, для купівлі ворфрейма треба 15000", "Увага!");
			}
			else if(WarfCount >= WarfMaxCount)
			{
				MessageBox.Show("Досягнуто ліміт кількості ворфреймів", "Увага!");
			}
			else
			{
				Iterator++;
				//Створення об'єкту класу варфрейм та надання йому дефолтних характеристик
				Warframe warframe = new Warframe();
				
				warframe.Name = "Warframe " + Iterator;				
				warframe.Lvl = 0;
				warframe.Mods_count = 0;
				warframe.Type = WarframeType.Звичайний;
				warframe.Sex = WarframeSex.Чоловіча;
				

				//Списання грошей
				Credits -= 15000;
				Credits_tb.Text = Credits.ToString();

				//додавання в коллекцію нового об'єкту
				Collection.Add(warframe);
				//додавання в ліст бокс нового елементу
				Warframes_lb.Items.Add(warframe.Name);
				Warframes_lb.Enabled = true;

				WarfCount++;
			}			
		}

		private void Warframes_lb_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			Name_tb.Enabled = true;
			lvl_tb.Enabled = true;
			Type_cb.Enabled = true;
			Mods_count_tb.Enabled = true;
			Sex_cb.Enabled = true;
			Change_btn.Enabled = true;
			All_char.Enabled = true;

			Warframe foundWarframe = Founder();

			Name_tb.Text = foundWarframe.Name;
			lvl_tb.Text = foundWarframe.Lvl.ToString();
			Type_cb.Text = foundWarframe.Type.ToString();
			Mods_count_tb.Text = foundWarframe.Mods_count.ToString();
			Sex_cb.Text = foundWarframe.Sex.ToString();
			Ressuract_tb.Text = foundWarframe.Ressuract;
		}

		private void Change_btn_Click(object sender, EventArgs e)
		{
			try
			{
				Warframe foundWarframe = Founder();
				int index = Collection.IndexOf(foundWarframe);				
				
				foundWarframe.Mods_count = uint.Parse(Mods_count_tb.Text); 
				
				foundWarframe.Lvl = ushort.Parse(lvl_tb.Text);
				
				
				foundWarframe.Type = (WarframeType) Type_cb.SelectedItem;
				foundWarframe.Sex = (WarframeSex) Sex_cb.SelectedItem;

				
				foundWarframe.Name = Name_tb.Text;

				Warframes_lb.Items[Warframes_lb.SelectedIndex] = foundWarframe.Name;
			}
			catch (OverflowException)
			{
				MessageBox.Show("Значення завелике або замаленьке", "Увага!");
			}
			catch (FormatException)
			{
				MessageBox.Show("Неправильний формат даних", "Увага!");
			}
		}

		private void Sold_wm_btn_Click(object sender, EventArgs e)
		{
			
			if (Warframes_lb.SelectedIndex == -1)
			{
				MessageBox.Show("Оберіть ворфрейма якого хочете продати", "Увага!");
			}
			else
			{
				Credits += 10000;
				Credits_tb.Text = Credits.ToString();

				Warframe foundWarframe = Founder();
				int index = Collection.IndexOf(foundWarframe);

				// Видалення елемента за індексом
				Collection.RemoveAt(index);
				Warframes_lb.Items.RemoveAt(Warframes_lb.SelectedIndex);

				Name_tb.Text = null;
				lvl_tb.Text = null;
				Type_cb.Text = null;
				Mods_count_tb.Text = null;
				Sex_cb.Text = null;

				WarfCount--;
			}
		}

		private void exchange_btn_Click(object sender, EventArgs e)
		{
			if (Warframes_lb.SelectedIndex == -1)
			{
				MessageBox.Show("Оберіть ворфрейма якого хочете обміняти", "Увага!");
			}
			else
			{
				Warframe foundWarframe = Founder();
				int index = Collection.IndexOf(foundWarframe);

				// Видалення елемента за індексом
				Collection.RemoveAt(index);
				Warframes_lb.Items.RemoveAt(Warframes_lb.SelectedIndex);

				Reputation += 10000;
				Reputation_lbl.Text = "Репутація: " + Reputation;

				WarfCount--;
			}
		}

		private void polar_btn_Click(object sender, EventArgs e)
		{
			if (Warframes_lb.SelectedIndex == -1)
			{
				MessageBox.Show("Оберіть ворфрейма якого хочете поляризувати", "Увага!");
			}
			else
			{
				Warframe foundWarframe = Founder();

				foundWarframe.Lvl = 0;
				foundWarframe.Mods_count = 12;
			}
		}

		private void All_char_Click(object sender, EventArgs e)
		{
			Warframe foundWarframe = Founder();
			MessageBox.Show(foundWarframe.All_char);
		}
	}
}
