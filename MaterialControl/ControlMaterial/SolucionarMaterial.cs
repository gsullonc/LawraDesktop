using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objects.Tables;
using Options;
using System.Net;

namespace MaterialControl.ControlMaterial
{
	public class SolucionarMaterial:Connection
	{
		private tSolucionarMaterial _data = new tSolucionarMaterial();

		private string _msgExceptionSolMateriales;


		#region PROPIEDADES

		public string MsESolucionarMaterial
		{
			get { return this._msgExceptionSolMateriales; }
		}

		public tSolucionarMaterial Data
		{
			get { return this._data; }
			set
			{
				this._data = value;
			}
		}

		#endregion Propiedadres

		#region METODOS

		public int Insert()
		{
			Query query = new Query("api/students/insert");

			query.RequestParameters = this._data;

			try
			{
				query.SendRequestPOST();

				if (query.ResponseStatusCode != HttpStatusCode.Created)
					throw new ArgumentNullException(query.MsgExceptionQuery, "ERROR");

				return Convert.ToInt32(query.ResponseContent); ;
			}
			catch (Exception e)
			{
				this._msgExceptionSolMateriales = e.Message;
				return 0;
			}
		}


		#endregion
	}
}
