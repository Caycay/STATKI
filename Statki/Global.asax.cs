using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using Battle.Models;
using Battle.ViewModel;

namespace Battle
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Mapper.CreateMap<Player, PlayerViewModel>();
            Mapper.CreateMap<PlayerViewModel, Player>();
            Mapper.CreateMap<Field, FieldViewModel>();
            Mapper.CreateMap<FieldViewModel, Field>();
        }
    }
}
