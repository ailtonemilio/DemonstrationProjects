using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HWebTS.Models;

namespace HWebTS.Budget
{
    public partial class EstimateTransfer : System.Web.UI.Page
    {
        #region Variables
        int identify = 0;
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGrid();
            }
        }

        protected void LoadGrid()
        {
            using (var ctx = new atripservicesEntities())
            {
                //Seleciono o objeto cliente e crio um novo tipo
                //Observe que o tipo anônimo criado tem as propriedades
                //com o mesmo nome do campodatafield do gridview
                //e depois atribuo a lista ao data source do grid
                gvBudget.DataSource = (from c in ctx.TransferEstimate
                                       select new
                                       {
                                           IdTransEst = c.IdTransEst,
                                           FlightNumber = c.FlightNumber,
                                           DateFligh = c.DateFligh,
                                           TimeFligh = c.TimeFligh,
                                           TimePiDo = c.TimePiDo,
                                           QtyPassanger = c.QtyPassenger,
                                           QtyMalaGr = c.QtyMalaGr,
                                           QtyMalaPq = c.QtyMalaPq,
                                           CityFromId = c.CityFromId,
                                           CityToId = c.CityToId,
                                           TransferAmount = c.TransferAmount,
                                           DateTransEst = c.DateTransEst,
                                           DateAprove = c.DateAprove,
                                           NamePassenger = c.NamePassenger,
                                           Phone = c.Phone,
                                           Phone2 = c.Phone2,
                                           Email = c.Email,
                                           Note = c.Note,
                                           Destination = c.Destination.Name,
                                           SalesContact = c.SalesContact.Contact,
                                           TypeTransfer = c.TypeTransfer.DescType,
                                           TypePayment = c.TypePayment.DescTypePayment,
                                           DescStatusPayment = c.StatusPayment.DescStatusPayment
                                       }).ToList();
                gvBudget.DataBind();
            }
        }
        protected void loadDelete()
        {
            int count = gvBudget.Rows.Count;

            for (int i = 0; i < count; i++)
            {
                ((LinkButton)gvBudget.Rows[i].FindControl("lbDelete")).Attributes.Add("onclick", "return deletealert(this, event);;");
            }
        }

        #region GridView Actions
        protected void gvBudget_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = ((HiddenField)gvBudget.Rows[gvBudget.SelectedRow.RowIndex].FindControl("hdfIdTransEst")).Value.ToString();

            switch (identify)
            {
                //Case 1 Edit, 2 Delete
                case 1:
                    Session.Add("IdTransEst", ID);
                    Response.Redirect("~/Budget/CRUDTransfeEstimate.aspx");
                    break;
                case 2:
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalDelete", "$('#ModalDelete').modal();", true);
                    break;
            }


        }
        #endregion

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            Session.Add("IdTransEst", "0");
            Response.Redirect("~/Budget/CRUDTransfeEstimate.aspx");
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            identify = 2;
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            identify = 1;
        }
    }
}