﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace проект2
{
	internal class Zayavka
	{
		public int ID { get; set; }
		private string passportn, passports, rabota, name, data;
		public string Passportn
		{
			get { return passportn; }
			set { passportn = value; }
		}
		public string Passports
		{
			get { return passports; }
			set { passports = value; }
		}
		public string Rabota
		{
			get { return rabota; }
			set { rabota = value; }
		}
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public string Data
		{
			get { return data; }
			set { data = value; }
		}
		public Zayavka() { }
		public Zayavka(string passports, string passportn, string rabota, string name, string data)
		{
			this.passportn = passportn;
			this.passports = passports;
			this.name = name;
			this.rabota = rabota;
			this.data = data;
		}
	}
}
