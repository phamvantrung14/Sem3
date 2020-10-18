using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI2.Models.DataModels;
using WebAPI2.Models.Repositories;

namespace WebAPI2.Controllers
{
    /* [RoutePrefix("T1907/departments")] */
    public class DepartmentsController : ApiController
    {
        IRepository<Department> deparments;
        public DepartmentsController()
        {
            deparments = new Repository<Department>();

        }
        /*[Route("getAll")]*/
        [HttpGet]
        public IEnumerable<Department> Get()
        {
            return deparments.Get();
        }
        [HttpGet]
        public Department Get(string id)
        {
            return deparments.Get(id);
        }

        [HttpPost]
        public IHttpActionResult Post(Department dp)
        {
            if(deparments.Get(x => x.Id == dp.Id).Count()>0)
            {
                ModelState.AddModelError("Id","Ma da ton tai!");
            }
            if (deparments.Get(x => x.Name == dp.Name).Count() > 0)
            {
                ModelState.AddModelError("Name", "Ten da ton tai!");
            }
            if(ModelState.IsValid)
            {
                deparments.Add(dp);
                return Content(HttpStatusCode.OK, new
                {
                    StatusCode = 200,
                    Message = "Thanh cong!",
                    Data = dp
                });

            }
            Dictionary<string, string> error = new Dictionary<string, string>();
            //doc loi trong modelstate
            foreach(var key in ModelState.Keys)
            {
                foreach(var item in ModelState[key].Errors)
                {
                    error.Add(key, item.ErrorMessage);
                }
            }
            return Content(HttpStatusCode.OK, new
            {
                StatusCode = 200,
                Message = "du lieu khong hop le!",
                Data = error
            });
        }

        [HttpPut]
        public Department Put(Department dp)
        {
            deparments.Add(dp);
            return dp;
        }

        [HttpDelete]
        public Department Delete(string id)
        {
            var deparment = deparments.Get(id);
            deparments.Remove(id);
            return deparment;
        }


    }
}
