using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Linq;
using System.Threading.Tasks.Dataflow;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class databess
    {
        public static List<id_log> ID_data = new List<id_log>();
        public static string store = "";
        public static List<string> history = new List<string>();

    }
    
    public class ID_loging
    {
        public static string Id = "";
        public static string password = "";
        public static string name = "";
        public static string tel = "";
        public static List<menu> menu = new List<menu>();
    }

    public class allmenu
    {
        public static string name = "";
        public static string store = "";
        public static List<menu> lismenu = new List<menu>();
    }

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        

        static bool check_log()
        {
            if (ID_loging.name == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool log_on(string id ,string password)
        {
            for (int i = 0; i < databess.ID_data.Count; i++)
            {
                if (id == databess.ID_data[i].Id && password == databess.ID_data[i].password)
                {
                    ID_loging.Id = databess.ID_data[i].Id;
                    ID_loging.password = databess.ID_data[i].password;
                    ID_loging.name = databess.ID_data[i].name;
                    ID_loging.tel = databess.ID_data[i].tel;
                    return true;
                }
            }
            return false;
        }

        static bool add_log(string user,string nam,string passw,string tel)
        {
            for (int i=0; i<databess.ID_data.Count; i++)
            {
                Debug.WriteLine(databess.ID_data[i].Id + " " + databess.ID_data[i].password + " " + databess.ID_data[i].name + " " + databess.ID_data[i].tel);
                if (user == databess.ID_data[i].Id)
                {
                    Debug.WriteLine("false");
                    return false;
                }
            }
            databess.ID_data.Add(new()
            {
                Id = user,
                password = passw,
                name = nam,
                tel = tel
            });
            Debug.WriteLine("true");
            return true;
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Ina(string user, string nam, string passw, string tel)
        {
            if (user != null && nam != null && passw != null && tel != null) 
            {
                if (add_log(user, nam, passw, tel))
                {
                    ViewBag.ou = "Succeed.";
                }
                else
                {
                    ViewBag.ou = "This user is already in use.";
                }
            }
            else
            {
                ViewBag.ou = "Please complete the information.";
            }
            return View("Register");
        }
        public IActionResult Ina2(string user,string password)
        {
            Debug.WriteLine("run");
            if (log_on(user, password))
            {
                ViewBag.name = ID_loging.name;
                ViewBag.bell = databess.history;
                ViewBag.listorder = allmenu.lismenu;
                return View("home");
            }
            else
            {
                return View("index");
            }
        }
        public IActionResult Index()
        {
            return View();  
        }

        public IActionResult close_menu()
        {
            if (check_log())
            {
                ViewBag.idstore = allmenu.store;
                ViewBag.bell = databess.history;
                ViewBag.listorder = allmenu.lismenu;
                ViewBag.name = ID_loging.name;
                return View();
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult add_menu11()
        {
            if (check_log())
            {
                databess.store = "โรงอาหาร A : ร้านที่1";
                ViewBag.bell = databess.history;
                ViewBag.name = ID_loging.name;
                ViewBag.listorder = allmenu.lismenu;
                if (allmenu.store != "")
                {
                    ViewBag.idstore = allmenu.store;
                }
                else
                {
                    ViewBag.idstore = databess.store;
                }
                return View("add_menu");
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult add_menu12()
        {
            if (check_log())
            {
                databess.store = "โรงอาหาร A : ร้านที่2";
                ViewBag.bell = databess.history;
                ViewBag.name = ID_loging.name;
                ViewBag.listorder = allmenu.lismenu;
                if (allmenu.store != "")
                {
                    ViewBag.idstore = allmenu.store;
                }
                else
                {
                    ViewBag.idstore = databess.store;
                }
                return View("add_menu");
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult add_menu13()
        {
            if (check_log())
            {
                databess.store = "โรงอาหาร A : ร้านที่3";
                ViewBag.bell = databess.history;
                ViewBag.name = ID_loging.name;
                ViewBag.listorder = allmenu.lismenu;
                if (allmenu.store != "")
                {
                    ViewBag.idstore = allmenu.store;
                }
                else
                {
                    ViewBag.idstore = databess.store;
                }
                return View("add_menu");
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult add_menu21()
        {
            if (check_log())
            {
                databess.store = "โรงอาหาร C : ร้านที่1";
                ViewBag.bell = databess.history;
                ViewBag.name = ID_loging.name;
                ViewBag.listorder = allmenu.lismenu;
                if (allmenu.store != "")
                {
                    ViewBag.idstore = allmenu.store;
                }
                else
                {
                    ViewBag.idstore = databess.store;
                }
                return View("add_menu");
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult add_menu22()
        {
            if (check_log())
            {
                databess.store = "โรงอาหาร C : ร้านที่2";
                ViewBag.bell = databess.history;
                ViewBag.name = ID_loging.name;
                ViewBag.listorder = allmenu.lismenu;
                if (allmenu.store != "")
                {
                    ViewBag.idstore = allmenu.store;
                }
                else
                {
                    ViewBag.idstore = databess.store;
                }
                return View("add_menu");
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult add_menu23()
        {
            if (check_log())
            {
                databess.store = "โรงอาหาร C : ร้านที่3";
                ViewBag.bell = databess.history;
                ViewBag.name = ID_loging.name;
                ViewBag.listorder = allmenu.lismenu;
                if (allmenu.store != "")
                {
                    ViewBag.idstore = allmenu.store;
                }
                else
                {
                    ViewBag.idstore = databess.store;
                }
                return View("add_menu");
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult add_menu31()
        {
            if (check_log())
            {
                databess.store = "โรงอาหาร J : ร้านที่1";
                ViewBag.bell = databess.history;
                ViewBag.name = ID_loging.name;
                ViewBag.listorder = allmenu.lismenu;
                if (allmenu.store != "")
                {
                    ViewBag.idstore = allmenu.store;
                }
                else
                {
                    ViewBag.idstore = databess.store;
                }
                return View("add_menu");
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult add_menu32()
        {
            if (check_log())
            {
                databess.store = "โรงอาหาร J : ร้านที่2";
                ViewBag.name = ID_loging.name;
                ViewBag.listorder = allmenu.lismenu;
                ViewBag.bell = databess.history;
                if (allmenu.store != "")
                {
                    ViewBag.idstore = allmenu.store;
                }
                else
                {
                    ViewBag.idstore = databess.store;
                }
                return View("add_menu");
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult add_menu33()
        {
            if (check_log())
            {
                databess.store = "โรงอาหาร J : ร้านที่3";
                ViewBag.bell = databess.history;
                ViewBag.name = ID_loging.name;
                ViewBag.listorder = allmenu.lismenu;
                if (allmenu.store != "")
                {
                    ViewBag.idstore = allmenu.store;
                }
                else
                {
                    ViewBag.idstore = databess.store;
                }
                return View("add_menu");
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult add_menu41()
        {
            if (check_log())
            {
                databess.store = "โรงอาหาร พระเทพ : ร้านที่1";
                ViewBag.bell = databess.history;
                ViewBag.name = ID_loging.name;
                ViewBag.listorder = allmenu.lismenu;
                if (allmenu.store != "")
                {
                    ViewBag.idstore = allmenu.store;
                }
                else
                {
                    ViewBag.idstore = databess.store;
                }
                
                return View("add_menu");
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult add_menu42()
        {
            if (check_log())
            {
                databess.store = "โรงอาหาร พระเทพ : ร้านที่2";
                ViewBag.bell = databess.history;
                ViewBag.name = ID_loging.name;
                ViewBag.listorder = allmenu.lismenu;
                if (allmenu.store != "")
                {
                    ViewBag.idstore = allmenu.store;
                }
                else
                {
                    ViewBag.idstore = databess.store;
                }
                return View("add_menu");
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult add_menu43()
        {
            if (check_log())
            {
                databess.store = "โรงอาหาร พระเทพ : ร้านที่3";
                ViewBag.bell = databess.history;
                ViewBag.name = ID_loging.name;
                ViewBag.listorder = allmenu.lismenu;
                if (allmenu.store != "")
                {
                    ViewBag.idstore = allmenu.store;
                }
                else
                {
                    ViewBag.idstore = databess.store;
                }
                return View("add_menu");
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult add_menu51()
        {
            if (check_log())
            {
                databess.store = "โรงอาหารสถาปัตย์ : ร้านที่1";
                ViewBag.bell = databess.history;
                ViewBag.name = ID_loging.name;
                ViewBag.listorder = allmenu.lismenu;
                if (allmenu.store != "")
                {
                    ViewBag.idstore = allmenu.store;
                }
                else
                {
                    ViewBag.idstore = databess.store;
                }
                return View("add_menu");
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult add_menu52()
        {
            if (check_log())
            {
                databess.store = "โรงอาหารสถาปัตย์ : ร้านที่2";
                ViewBag.bell = databess.history;
                ViewBag.name = ID_loging.name;
                ViewBag.listorder = allmenu.lismenu;
                if (allmenu.store != "")
                {
                    ViewBag.idstore = allmenu.store;
                }
                else
                {
                    ViewBag.idstore = databess.store;
                }
                return View("add_menu");
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult add_menu53()
        {
            if (check_log())
            {
                databess.store = "โรงอาหารสถาปัตย์ : ร้านที่3";
                ViewBag.bell = databess.history;
                ViewBag.name = ID_loging.name;
                ViewBag.listorder = allmenu.lismenu;
                if (allmenu.store != "")
                {
                    ViewBag.idstore = allmenu.store;
                }
                else
                {
                    ViewBag.idstore = databess.store;
                }
                return View("add_menu");
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult add_menu61()
        {
            if (check_log())
            {
                databess.store = "โรงอาหารวิทยา : ร้านที่1";
                ViewBag.bell = databess.history;
                ViewBag.name = ID_loging.name;
                ViewBag.listorder = allmenu.lismenu;
                if (allmenu.store != "")
                {
                    ViewBag.idstore = allmenu.store;
                }
                else
                {
                    ViewBag.idstore = databess.store;
                }
                return View("add_menu");
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult add_menu62()
        {
            if (check_log())
            {
                databess.store = "โรงอาหารวิทยา : ร้านที่2";
                ViewBag.bell = databess.history;
                ViewBag.name = ID_loging.name;
                ViewBag.listorder = allmenu.lismenu;
                if (allmenu.store != "")
                {
                    ViewBag.idstore = allmenu.store;
                }
                else
                {
                    ViewBag.idstore = databess.store;
                }
                return View("add_menu");
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult add_menu63()
        {
            if (check_log())
            {
                databess.store = "โรงอาหารวิทยา : ร้านที่3";
                ViewBag.bell = databess.history;
                ViewBag.name = ID_loging.name;
                ViewBag.listorder = allmenu.lismenu;
                if (allmenu.store != "")
                {
                    ViewBag.idstore = allmenu.store;
                }
                else
                {
                    ViewBag.idstore = databess.store;
                }
                return View("add_menu");
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult addmenu(string namemen, int amount, int price, string note)
        {
            Debug.WriteLine(namemen+" "+ amount+" "+ price+" "+note+" "+ ID_loging.name);
            allmenu.store = databess.store;
            allmenu.lismenu.Add(new()
            {
                men = namemen,
                name = ID_loging.name,
                amount = amount,
                price = price,
                note = note,
            });
            ViewBag.bell = databess.history;
            ViewBag.name = ID_loging.name;
            ViewBag.idstore = allmenu.store;
            ViewBag.listorder = allmenu.lismenu;
            return View("add_menu");
        }

        public IActionResult home()
        {
            
            if (check_log())
            {
                ViewBag.bell = databess.history;
                ViewBag.name = ID_loging.name;
                ViewBag.listorder = allmenu.lismenu;
                return View();
            }
            else
            {
                return View("Index");
            }
        }

        public IActionResult total_list()
        {
            List<menu> n = allmenu.lismenu;
            var e = allmenu.store;
            int s = 0;
            for (int i = 0; i < allmenu.lismenu.Count; i++)
            {
                
                s = (int)(s + allmenu.lismenu[i].price);

            }
            allmenu.lismenu = new List<menu>();
            allmenu.store = "";
            databess.history.Add(ID_loging.name + " กำลังไปซื้อข้าวที่ "+e);

            if (check_log())
            {
                ViewBag.bell = databess.history;
                ViewBag.idstore = e;
                ViewBag.name = ID_loging.name;
                ViewBag.listorder = n;
                ViewBag.t = s;
                return View();
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult log_out()
        {
            databess.store = "";
            ID_loging.Id = "";
            ID_loging.password = "";
            ID_loging.name = "";
            ID_loging.tel = "";
            return View("index");
        }

        public IActionResult Register()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}