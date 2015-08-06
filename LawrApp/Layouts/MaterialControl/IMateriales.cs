using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LawrApp.Layouts.MaterialControl
{
	public interface IMateriales
	{
		void AddMaterial(int Codigo,string Description,string Categoria,string Marca, string Modelo);
	}
}
