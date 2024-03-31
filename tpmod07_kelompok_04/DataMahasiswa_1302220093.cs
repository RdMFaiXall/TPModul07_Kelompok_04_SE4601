using System;

public class DataMahasiswa_1302220093
{
	// class
	public DataMahasiswa_1302220093()
	{
		public string nama { get; set; }
		public int nim { get; set;}
		public string fakultas { get; set; }

		public DataMahasiswa_1302220093(string nama, int nim, string fakultas)
		{
			this.nama = nama;
			this.nim = nim;
			this.fakultas = fakultas;
		}
	}
	
	// Method ReadJSON
	public void ReadJSON()
	{
		DataMahasiswa_1302220093 mhs = new DataMahasiswa_1302220093();
	}
}
