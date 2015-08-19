using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Net;

using Objects.Processes;
using Newtonsoft.Json;
using Objects.Tables;
using RestSharp;
using Options;


namespace MaterialControl.ControlMaterial
{
	public class Materiales
	{
		private tMaterial _dataMaterial = new tMaterial();
		private tCategoria _dataCategoria = new tCategoria();
		private tMarca _dataMarca = new tMarca();

		private string _msgExceptionRegMateriales;

		#region PROPIEDADES

		public string MsERegistrarMaterial
		{
			get { return this._msgExceptionRegMateriales; }
		}

		public tMaterial DataMaterial
		{
			get { return this._dataMaterial; }
			set
			{
				this._dataMaterial = value;
			}
		}
		public tCategoria DataCategoria
		{
			get { return this._dataCategoria; }
			set
			{
				this._dataCategoria = value;
			}
		}
		public tMarca DataMarca
		{
			get { return this._dataMarca; }
			set
			{
				this._dataMarca = value;
			}
		}

		#endregion Propiedadres


		public int Insert()
		{
			Query query = new Query("api/students/insert");

			this._dataMaterial.Category = this._dataCategoria;
			this._dataMaterial.Marca = this._dataMarca;

			query.RequestParameters = this._dataMaterial;

			try
			{
				query.SendRequestPOST();

				if (query.ResponseStatusCode != HttpStatusCode.Created)
					throw new ArgumentNullException(query.MsgExceptionQuery, "ERROR AL REGISTRAR UN MATERIAL");

				return Convert.ToInt32(query.ResponseContent); ;
			}
			catch (Exception e)
			{
				this._msgExceptionRegMateriales = e.Message;
				return 0;
			}
		}

		public DataSet List(DataSet dts)
		{
			Query query = new Query("api/material");

			try
			{
				if (dts.Tables["ListaMaterial"].Rows.Count > 0) dts.Tables["ListaMaterial"].Clear();

				query.SendRequestGET();

				if (query.ResponseStatusCode != HttpStatusCode.OK)
					throw new ArgumentNullException("No se encontraron datos", "Materiales");

				List<lMaterial> MaterialData = JsonConvert.DeserializeObject<List<lMaterial>>(query.ResponseContent);

				foreach (lMaterial Items in MaterialData)
				{
					object[] temp = new object[4] { 

						Items.Codigo, 
						Items.Description + " " + "_" + Items.Marca + " " + "_"  + Items.Model,
						Items.Category,
						Items.ModifiedDate
					};

					dts.Tables["ListaMaterial"].Rows.Add(temp);
				}

				return dts;
			}
			catch (Exception ex)
			{
				this._msgExceptionRegMateriales = ex.Message;
				return null;
			}
		}

		public List<lMaterialOfAula>ListforAula(int codAula)
		{
			Query query = new Query("api/material/aula/" + codAula);

			try
			{
				query.SendRequestGET();

				if (query.ResponseStatusCode != HttpStatusCode.OK)
					throw new ArgumentNullException("No se encontraron datos", "Materiales");

				return JsonConvert.DeserializeObject<List<lMaterialOfAula>>(query.ResponseContent);
			}
			catch (Exception ex)
			{
				this._msgExceptionRegMateriales = ex.Message;
				return null;
			}
		}

		public List<lMaterial> ListforAulaAndCondicion(int codAula,string Condicion)
		{
			Query query = new Query("api/students/parents_show/" + codAula + " /" + Condicion  );

			try
			{
				query.SendRequestGET();

				if (query.ResponseStatusCode != HttpStatusCode.OK)
					throw new ArgumentNullException("No se encontraron datos", "Materiales");

				return JsonConvert.DeserializeObject<List<lMaterial>>(query.ResponseContent);
			}
			catch (Exception ex)
			{
				this._msgExceptionRegMateriales = ex.Message;
				return null;
			}
		}

		public tMaterial Find(int Codigo)
		{
			Query query = new Query("api/students/show/"+ Codigo);

			try
			{
				query.SendRequestGET();

				if (query.ResponseStatusCode != HttpStatusCode.OK)
					throw new ArgumentNullException(query.ResponseContent, "ERROR AL OBTENER INFORMACION DEL MATERIAL");

				return JsonConvert.DeserializeObject<tMaterial>(query.ResponseContent);
			}
			catch (Exception ex)
			{
				this._msgExceptionRegMateriales = ex.Message;
				return null;
			}
		}

		public bool Update(int Codigo)
		{
			Query query = new Query("api/students/update/"+ Codigo);

			query.RequestParameters = this._dataMaterial;

			try
			{
				query.SendRequestPUT();

				if (query.ResponseStatusCode != HttpStatusCode.OK)
					throw new ArgumentNullException(query.MsgExceptionQuery, "HUBO UN ERROR AL INTENTAR MODIFICAR AL APODERADO");

				return Convert.ToBoolean(query.ResponseContent);
			}
			catch (Exception e)
			{
				this._msgExceptionRegMateriales = e.Message;
				return false;
			}
		}


		public bool Delete(int Codigo)
		{
			Query query = new Query("api/students/destroy/" + Codigo);
			try
			{
				query.SendRequestDELETE();

				if (query.ResponseStatusCode != HttpStatusCode.OK)
					throw new ArgumentException(query.MsgExceptionQuery, "ERROR AL ELIMINAR EL MATERIAL");

				return Convert.ToBoolean(query.ResponseContent);
			}
			catch (Exception e)
			{
				this._msgExceptionRegMateriales = e.Message;
				return false;
			}
		}
		
	}
}
