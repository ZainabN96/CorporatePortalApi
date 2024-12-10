using CorporatePortalApi.Dtos;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace CorporatePortalApi.Extenstions
{
    public static class AppSessionExtensions
    {
        private static IHttpContextAccessor _httpContextAccessor;

        public static void Configure(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public static HttpContext Current => _httpContextAccessor.HttpContext;

        public static AllUserPermissionsDto UserHavePermission(this IHtmlHelper html, string permission) =>
               ActiveUserPermissions.Where(x => x.Name.ToLower() == permission.ToLower()).FirstOrDefault();

        public static List<AllUserPermissionsDto> ActiveUserPermissions //Get Site User
        {
            set
            {

                Session<List<AllUserPermissionsDto>>("Permissions", value);
            }
            get
            {
                return Session<List<AllUserPermissionsDto>>("Permissions", new List<AllUserPermissionsDto>());
            }
        }

        public static T Session<T>(string key, T value)
        {

            if (String.IsNullOrEmpty(Current.Session.GetString(key)))
            {
                string obj = JsonConvert.SerializeObject(value);
                Current.Session.SetString(key, obj);
                return value;
            }
            else
            {
                string obj = Current.Session.GetString(key);
                return JsonConvert.DeserializeObject<T>(obj);
            }
        }

        public static void SetPermissions(this ISession session, List<AllUserPermissionsDto> permissions)
        {
            session.SetString("Permissions", JsonConvert.SerializeObject(permissions));

        }
        public static List<AllUserPermissionsDto> GetPermissions(this ISession session)
        {
            var permissions = session.GetString("Permissions");
            if (!permissions.IsEmpty())
            {
                return JsonConvert.DeserializeObject<List<AllUserPermissionsDto>>(permissions);
            }
            return new List<AllUserPermissionsDto>();

        }
        public static bool HasPermission(string formName)
        {
            var permissions = Current.Session.GetString("Permissions");
            if (!permissions.IsEmpty())
            {
                var currentpermissons = JsonConvert.DeserializeObject<List<AllUserPermissionsDto>>(permissions);
                var a = currentpermissons.Exists(x => x.Name == formName);
                return a;
            }

            return false;
        }
    }
}
