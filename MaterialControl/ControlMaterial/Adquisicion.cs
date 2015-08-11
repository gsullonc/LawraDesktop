using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using RestSharp;
using Objects.Processes;
using Objects.Tables;
using Options;

using Newtonsoft.Json;


namespace MaterialControl.ControlMaterial
{
	public class Adquisicion
	{
		private tKardex _data = new tKardex();

		private string _msgException;


		#region PROPIEDADES

		public string MsExecpcion
		{
			get { return this._msgException; }
			set { this.MsExecpcion = value; }
		}

		public tKardex Data
		{
			get { return this._data; }
			set
			{
				this._data = value;
			}
		}

		#endregion Propiedadres
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
				this._msgException = e.Message;
				return 0;
			}
		}

		public List<lIngresos> ListDetalleOfIngresosForMaterial(int codMaterial)
		{
			Query query = new Query("api/material/entry/" + codMaterial);

			try
			{
				query.SendRequestGET();

				if (query.ResponseStatusCode != HttpStatusCode.OK)
					throw new ArgumentNullException("No se encontro ninguna Informacion", "Informacion de Ingresos");

				return JsonConvert.DeserializeObject<List<lIngresos>>(query.ResponseContent);
			}
			catch (Exception ex)
			{
				this._msgException = ex.Message;
				return null;
			}
		}

		public bool UpdateQuantityIngresosOfMaterial(int CodigoMaterial, int CodigoIngreso)
		{
			Query query = new Query("api/material/" + CodigoMaterial + "/entry/" + CodigoIngreso);

			query.RequestParameters = this._data;

			try
			{
				query.SendRequestPUT();

				if (query.ResponseStatusCode != HttpStatusCode.OK)
					throw new ArgumentNullException(query.MsgExceptionQuery, "Error al modificar la cantidad del Ingreso");

				return Convert.ToBoolean(query.ResponseContent);
			}
			catch (Exception e)
			{
				this._msgException = e.Message;
				return false;
			}
		}

		public tKardex Find(int CodigoMaterial, int CodigoIngreso)
		{
			Query query = new Query("api/material/"+ CodigoMaterial + "/entry/" + CodigoIngreso);

			try
			{
				query.SendRequestGET();

				if (query.ResponseStatusCode != HttpStatusCode.OK)
					throw new ArgumentNullException("Docoumentos no encontrados", "No se encontro ningun Detalle");

				tKardex result = JsonConvert.DeserializeObject<tKardex>(query.ResponseContent);
				return result;
			}
			catch (Exception ex)
			{
				this.MsExecpcion = ex.Message;
				return null;
			}
		}
	}
}
