using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objects.Tables;

namespace Objects.Processes
{
	public class pMaterialControl
	{
		public tMaterial Material { get; set; }
	}

	public class lMaterial
	{
		public int Codigo { get; set; }
		public string Description { get; set; }
		public string Category { get; set; }
		public string Marca { get; set; }
		public string Model { get; set; }
		public string Condicion {get;set;}
		public string ModifiedDate { get; set; } 
	}
}
