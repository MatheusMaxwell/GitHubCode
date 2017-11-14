using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;


namespace WebApplicationConsumindoWebService
{
    public partial class _Default : Page
    {
        HttpClient client;
        Uri instituicaoUri;

        public _Default()
        {
            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("http://turmadobem.azurewebsites.net/api/instituicao");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }
        }
    protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getAll();
            }

        }

        private void getAll()
        {
            
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://turmadobem.azurewebsites.net/api/instituicao").Result;

            if (response.IsSuccessStatusCode)
            {
                instituicaoUri = response.Headers.Location;

                var instituicoes = response.Content.ReadAsAsync<IEnumerable<Instituicao>>().Result;

                GridView1.DataSource = instituicoes;
                GridView1.DataBind();
            }

            Response.Write(response.StatusCode.ToString() + " - " + response.ReasonPhrase);
        }
    }
}