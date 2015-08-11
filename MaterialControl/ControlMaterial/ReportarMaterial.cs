using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objects.Tables;
using System.Net;
using Options;

namespace MaterialControl.ControlMaterial
{
	public class ReportarMaterial
	{
		private tMaterialSalon _data = new tMaterialSalon();

		private string _msgException;


		#region PROPIEDADES

		public string MsExecpcion
		{
			get { return this._msgException; }
		}

		public tMaterialSalon Data
		{
			get { return this._data; }
			set
			{
				this._data = value;
			}
		}

		#endregion Propiedadres

		#region METODOS

		public bool Update(int CodigoMaterial, int CodigoSalon)
		{
			Query query = new Query("api/students/update/"+ CodigoMaterial);

			query.RequestParameters = this._data;

			try
			{
				query.SendRequestPUT();

				if (query.ResponseStatusCode != HttpStatusCode.OK)
					throw new ArgumentNullException(query.MsgExceptionQuery, "ERROR");

				return Convert.ToBoolean(query.ResponseContent);

			}
			catch (Exception e)
			{
				this._msgException = e.Message;
				return false;
			}
		}


		#endregion
	}
}
