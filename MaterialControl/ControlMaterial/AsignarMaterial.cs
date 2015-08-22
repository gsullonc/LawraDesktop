using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objects.Tables;
using Options;
using System.Net;
using Newtonsoft.Json;
using System.Collections;

namespace MaterialControl.ControlMaterial
{
	public class AsignarMaterial
	{
		private tMaterialSalon _data = new tMaterialSalon();

		private string _msgException;


		#region PROPIEDADES

		public string MsgExeption
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

		public tMaterial Find(int Codigo , int codigoMaterial)
		{
			Query query = new Query("api/students/show/" + Codigo);

			try
			{
				query.SendRequestGET();

				if (query.ResponseStatusCode != HttpStatusCode.OK)
					throw new ArgumentNullException(query.ResponseContent, "ERROR AL OBTENER INFORMACION DEL MATERIAL ");

				return JsonConvert.DeserializeObject<tMaterial>(query.ResponseContent);
			}
			catch (Exception ex)
			{
				this._msgException = ex.Message;
				return null;
			}
		}

		public bool Update(int Codigo , int codigoAula)
		{
			Query query = new Query("api/students/update/" + Codigo);

			query.RequestParameters = this._data;

			try
			{
				query.SendRequestPUT();

				if (query.ResponseStatusCode != HttpStatusCode.OK)
					throw new ArgumentNullException(query.MsgExceptionQuery, "HUBO UN ERROR AL INTENTAR MODIFICAR AL APODERADO");

				return Convert.ToBoolean(query.ResponseContent);
			}
			catch (Exception e)
			{
				this._msgException = e.Message;
				return false;
			}
		}

		public bool Delete(int CodigoMaterialSalon)
		{
			Query query = new Query("api/students/destroy/" + CodigoMaterialSalon);
			try
			{
				query.SendRequestDELETE();

				if (query.ResponseStatusCode != HttpStatusCode.OK)
					throw new ArgumentException(query.MsgExceptionQuery, "ERROR AL ELIMINAR EL MATERIAL");

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
