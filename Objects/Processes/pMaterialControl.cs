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


	public class  lkeys
	{
		public string Keys { get; set;}
	}
	public class lMaterial
	{
		public int Codigo			{ get; set; }
		public string Description	{ get; set; }
		public string Category		{ get; set; }
		public string Marca			{ get; set; }
		public string Model			{ get; set; }
		public string ModifiedDate	{ get; set; } 
	}
	public class lMaterialOfAula
	{
		public int CodigoMaterialSalon { get; set; }
		public int Codigo { get; set; }
		public string Key { get; set; }
		public string Description { get; set; }
		public string Category { get; set; }
		public string Marca { get; set; }
		public string Model { get; set; }
		public string Condicion { get; set; }
		public string ModifiedDate { get; set; }
	}

	public class lSalon
	{
		public int Codigo			{ get; set; }
		public string Description	{ get; set; }
		public string ModifiedDate	{ get; set; }

	}

	public class lIngresos
	{
		public int Codigo			 { get; set; }
		public string Key			 { get; set; }
		public int CodigoMaterial	 { get; set; }
		public int Quantity			 { get; set; }
	}
	public class lDetalleIngresosOfMaterial
	{
		public int Codigo			 { get; set; }
		public string Key			 { get; set; }
		public int CodigoMaterial	 { get; set; }
		public string Type			 { get; set; }
		public string EntryDate		 { get; set; }
		public int Quantity			 { get; set; }
		public string DocumentNumber { get; set; }
		public int Price			 { get; set; }
	}

	public class lReportEspecifico 
	{
		public string Aula						 { get; set; }
		public string UltInventario				 { get; set; }
		public lMaterialOfAula  Materiales       { get; set; }
		public lConteroPorCondicion Conteo       { get; set; }
		public lGastos Gastos				     { get; set; }
	}

	public class lConteroPorCondicion 
	{
		public string Condicion					{ get; set; }
		public int Cantidad						{ get; set; }
	}
	public class lGastos 
	{
		public string Condicion					{ get; set; }
		public int Monto						{ get; set; }
	}
}
