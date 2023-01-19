using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;
using csis265proj08.models;

namespace csis265proj08
{
    public partial class Calcs : System.Web.UI.Page
    {
        RectangleManager rectangleManager;
        private static readonly log4net.ILog logger = LogManager.GetLogger("MyLogger");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                logger.Debug("Page is being reloaded");
            }
            else
            {
                logger.Debug("Page loaded for the first time");

                rectangleManager = new RectangleManager();
                Session["rectanglemanager"] = rectangleManager;
            }
        }

        protected void btnAddRectangle_Click(object sender, EventArgs e)
        {
            lblOutputDisplay.Text = string.Empty;

            try
            {
                rectangleManager = (RectangleManager)Session["rectanglemanager"];
                rectangleManager.AddRectangle(Convert.ToDouble(txtRectangleLength.Text), Convert.ToDouble(txtRectangleWidth.Text));
                Session["rectanglemanager"] = rectangleManager;

                logger.Debug("User entered valid data, rectangle has been added");
                logger.Debug($"Length -- {txtRectangleLength.Text}");
                logger.Debug($"Width -- {txtRectangleWidth.Text}");
            }
            catch (Exception ex)
            {
                lblOutputDisplay.Text = "Please enter valid data";

                logger.Debug("Exception: Invalid entry by user");
            }

            txtRectangleLength.Text = string.Empty;
            txtRectangleWidth.Text = string.Empty;
        }

        protected void btnDisplayOutput_Click(object sender, EventArgs e)
        {
            rectangleManager = (RectangleManager)Session["rectanglemanager"];

            lblOutputDisplay.Text = $"TTL perm: {rectangleManager.GetTotalPerimeter()} TTL area: {rectangleManager.GetTotalArea()} " +
                                    $"AVG perm: {rectangleManager.GetAveragePerimeter()} AVG area: {rectangleManager.GetAverageArea()}";

            logger.Debug($"Message Displayed: TTL perm: {rectangleManager.GetTotalPerimeter()} TTL area: {rectangleManager.GetTotalArea()} " +
                         $"AVG perm: {rectangleManager.GetAveragePerimeter()} AVG area: {rectangleManager.GetAverageArea()}");

            txtRectangleLength.Text = string.Empty;
            txtRectangleWidth.Text = string.Empty;
        }
    }
}