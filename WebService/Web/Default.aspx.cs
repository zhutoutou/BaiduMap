using System;
using System.Web.UI;
using Web.Model;


namespace Web
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var model = BaseDA.QueryForList<ACCEPT_INFO>("SelectAcceptInfo");
            //var a = InfoBll.Instance.QueryForList<ACCEPT_INFO>(1);
            //插入
            //var insertProductId = BaseDA.Insert<Product>("InsertProduct", new Product()
            //{
            //    ProductCompany = "INFOSKY",
            //    ProductName = "iGSA2",
            //    SignDate = DateTime.Now,
            //    UpdateDate = DateTime.Now
            //});

            ////查单条记录
            //var model = BaseDA.Get<Product>("SelectByProductId", insertProductId);
            //ShowProduct(model);

            //Response.Write("<hr/>");

            ////修改记录
            //if (model != null)
            //{
            //    model.ProductName = (new Random().Next(0, 99999999)).ToString().PadLeft(10, '0');
            //    int updateResult = BaseDA.Update<Product>("UpdateProduct", model);
            //    Response.Write("update影响行数:" + updateResult + "<br/><hr/>");
            //}

            ////查列表
            //var products = BaseDA.QueryForList<Product>("SelectAllProduct");

            //foreach (var pro in products)
            //{
            //    ShowProduct(pro);
            //}

            //Response.Write("<hr/>");

            ////删除记录
            //int deleteResult = BaseDA.Delete("DeleteProductById", insertProductId);
            //Response.Write("delete影响行数:" + deleteResult + "<br/><hr/>");

        }

        void ShowProduct(Product pro)
        {
            if (pro == null) return;
            Response.Write(string.Format("{0}&nbsp;,&nbsp;{1}&nbsp;,&nbsp;{2}&nbsp;,&nbsp;{3}&nbsp;,&nbsp;{4}<br/>",
                pro.ProductId, pro.ProductName, pro.ProductCompany, pro.SignDate, pro.UpdateDate));
        }
    }
}