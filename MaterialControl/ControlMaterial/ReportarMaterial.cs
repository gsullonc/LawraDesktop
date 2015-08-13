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
		private tReportarMaterial _reportar = new tReportarMaterial();
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

		public int InsertReporteIndividual(int codigoMaterial, int codigoAula)
		{
			Query query = new Query("api/material/"+ codigoMaterial+ "/aula/"+ codigoAula + "/report");

			query.RequestParameters = this._reportar;
			 
			try
			{
				query.SendRequestPOST();

				if (query.ResponseStatusCode != HttpStatusCode.Created)
					throw new ArgumentNullException(query.MsgExceptionQuery, "ERROR");

				return Convert.ToInt32(query.ResponseContent); ;
			}
			catch (Exception e)
			{
				this._msgException = e.Message;
				return 0;
			}
		}

		#endregion
	}
}
