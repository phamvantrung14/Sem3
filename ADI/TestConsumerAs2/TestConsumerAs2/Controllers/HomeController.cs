using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestConsumerAs2.Models;

namespace TestConsumerAs2.Controllers
{
    public class HomeController : Controller
    {
        BlogClient dataBl;
        TypeBlogClient dataTP;
        UserClient dataUs;
        CommentClient dataCm;
        CustomerClient dataCus;
        public HomeController()
        {
            dataBl = new BlogClient();
            dataTP = new TypeBlogClient();
            dataUs = new UserClient();
            dataCm = new CommentClient();
            dataCus = new CustomerClient();
        }
        public ActionResult Index(int? page)
        {
            int _page = page ?? 1;
            int _pageSize = 12;

            ViewBag.dataTypeBlogs = dataTP.GetAllTypeBlog();
            ViewBag.dataUser = dataUs.getAllUser();

            //du lieu tin tuc trang chu
            /*ViewBag.dataBlogs = dataBl.GetAllBlog();*/
            var data = dataBl.GetAllBlog();

            return View(data.OrderByDescending(x => x.Created).ToPagedList(_page, _pageSize));
        }
        public ActionResult DetailBlog(int id, int? page)
        {
            int _page = page ?? 1;
            int _pageSize = 5;
            Blog blogNew = dataBl.GetBlogByID(id);
            var view = blogNew.views + 1;
            blogNew.views = view;
            dataBl.UpdateBlog(blogNew);

            ViewBag.DetailBlog = dataBl.GetBlogByID(id);
            var data = dataTP.GetTypeBlogById1(ViewBag.DetailBlog.TypeBlogID);
            ViewBag.TypeBlog = data.TypeName;
            var dataUser = dataUs.GetUserById(ViewBag.DetailBlog.UserID);
            ViewBag.UserBlog = dataUser.UserName;

            //comment
            var dataComent = dataCm.GetCommentByBlog(id);
            //
            ViewBag.DataCommentParent = dataCm.GetCommentPrentId(id);

            ViewBag.dataTypeBlogs = dataTP.GetAllTypeBlog();
            ViewBag.dataUser = dataCus.GetAllCustomer();

           

            ViewBag.ThoiGian = DateTime.Now.ToString();
            return View(dataComent.OrderByDescending(x=>x.Created).Where(x => x.ParentId==0).ToPagedList(_page, _pageSize));
        }
        [HttpPost]
        public ActionResult DetailBlog(int blogId,int parentId,int rate,string message)
        {
            if (Session["loginCustomer"] == null)
            {
                return RedirectToAction("LoginSession");
            }
            var dataCustomer = dataCus.CheckEmail(Session["loginCustomer"].ToString());
            string email = dataCustomer.Email;
            string pwd = dataCustomer.Password;
            int idCus = dataCustomer.ID;
            Comment cm = new Comment();
            cm.CustomerID = dataCustomer.ID;
            cm.BlogID = blogId;
            cm.ParentId = parentId;
            cm.Created = DateTime.Parse(DateTime.Now.ToString());
            cm.Rate = rate;
            cm.Content = message;

            //phan trang

            dataCm.StoreComment(cm, email, pwd, blogId);

            return RedirectToAction("DetailBlog",new { id = blogId});
        }

        public ActionResult ListBlogType(int id)
        {
            ViewBag.dataTypeBlogs = dataTP.GetAllTypeBlog();
            ViewBag.dataBlogs = dataBl.GetListBlogByType(id);
            ViewBag.dataUser = dataUs.getAllUser();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult LoginSession()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginSession(string email, string pwd)
        {
            var data = dataCus.GetAllCustomer();
            foreach(var item in data)
            {
                if(item.Email == email && item.Password == pwd)
                {
                    Session["loginCustomer"] = email;
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public ActionResult LogoutSession()
        {
            Session.Remove("loginCustomer");
            return RedirectToAction("Index");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Customer c)
        {
            c.Created = DateTime.Parse(DateTime.Now.ToString());
            c.Status = 1;
            if(c!=null)
            {
                dataCus.StoreCustomer(c);
                ViewBag.message = "Them Tai khoan Thanh Cong";
                return RedirectToAction("LoginSession");
            }

            return View();
        }
    }
}