using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [System.Web.Http.RoutePrefix("todo")]
    [EnableCors("*", "*", "GET,POST,PUT,DELETE,PATCH")]
    public class ProductController : ApiController
    {
        // GET: Product

        [System.Web.Http.Route("")]
        public IEnumerable<Product> Get()
        {
            var db = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            var items = db.Query<Product>("SELECT *FROM Products");

            // var items = new List<TodoItem>();
            //items.Add(new TodoItem()
            //{
            //    Id = 1, Title = "demo1", Description = "demo1", CreateDate =DateTime.Now
            //});
            //items.Add(new TodoItem());
            return items;

        }

        //[Route("")]
        //public void Post([FromBody] TodoItem item)
        //{
        //    var db = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        //    db.Execute("INSERT INTO TodoItems" +
        //        "(Title, Description, CreateDate)" +
        //        "VALUES (@Title, @desc, GETDATE())",
        //        new { Title = item.Title, desc = item.Description });
        //}

        //[Route("{id}")]
        //public void Put(int id, [FromBody] TodoItem item)
        //{
        //    var db = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        //    db.Execute(
        //        "UPDATE TodoItems " +
        //        "SET Title=@title,Description=@desc " +
        //        "WHERE Id=@id", new
        //        {
        //            id = id,
        //            title = item.Title,
        //            desc = item.Description
        //        });
        //}
        //[Route("{id}/title")] //修改title
        //[HttpPatch]
        //public void UpdateTodoTitle(int id, [FromBody] TodoItem item)
        //{
        //    var db = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        //    db.Execute(
        //        "UPDATE TodoItems SET Title=@title WHERE Id=@id", new
        //        {
        //            id,
        //            title = item.Title,
        //        });
        //}

        //[Route("{id}/Description")] //修改title
        //[HttpPatch]
        //public void UpdateTodoDescription(int id, [FromBody] TodoItem item)
        //{
        //    var db = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        //    db.Execute(
        //        "UPDATE TodoItems SET Description=@desc  WHERE Id=@id", new
        //        {
        //            id,
        //            desc = item.Description
        //        });
        //}

        //[Route("upload")] //上傳檔案
        //[HttpPost]
        ////public async Task<HttpRequestMessage> UploadFile(HttpRequestMessage request)//1
        //public async Task<IHttpActionResult> UploadFile(HttpRequestMessage request)
        //{
        //    var UploadFilePath = HostingEnvironment.MapPath("/uploadFiles");
        //    var provider = new MultipartFileStreamProvider(UploadFilePath);
        //    provider = await request.Content.ReadAsMultipartAsync(provider);
        //    foreach (MultipartFileData file in provider.FileData)
        //    {
        //        var fileSrc = new FileInfo(Path.Combine(UploadFilePath, file.LocalFileName));
        //        fileSrc.MoveTo(Path.Combine(UploadFilePath, file.Headers.ContentDisposition.FileName.Replace("\"", "")));

        //    }
        //    //return request.CreateResponse(HttpStatusCode.Accepted);//1
        //    return Content(HttpStatusCode.Accepted, "");
        //}




        //[Route("{id}")]
        //public void Delete(int id)
        //{
        //    var db = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        //    db.Execute(
        //        "DELETE FROM TodoItems " +
        //        "WHERE Id=@id", new
        //        {
        //            id = id
        //        });
        //}
        //[Route("{id}")]
        //public IHttpActionResult Get(int id)//TodoItem Get(int id)
        //{
        //    var db = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        //    var items = db.Query<TodoItem>
        //         ("SELECT* FROM TodoItems WHERE Id=@id", new
        //         {
        //             id
        //         });
        //    var item = items.FirstOrDefault();
        //    if (item == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        return Content(HttpStatusCode.OK, item);
        //    }

        //}

    }
}
