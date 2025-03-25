using CorporatePortalApi.Dtos;
using CorporatePortalApi.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;

namespace CorporatePortalApi.Helper
{
    public class UHelper
    {
        /*public static string CreateJWT(User user, IConfiguration configuration)
        {
            var secretKey = configuration.GetSection("AppSettings:Key").Value;
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

            var claims = new Claim[] {
            new Claim(ClaimTypes.Name,user.UserName),
            new Claim(ClaimTypes.NameIdentifier,user.Id.ToString())
        };

            var signingCredentials = new SigningCredentials(
                    key, SecurityAlgorithms.HmacSha256Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = signingCredentials
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }*/

        public static string ExtractIdentifierFromUrl(string url)
        {
            string filename = Path.GetFileNameWithoutExtension(url);
            return filename;
        }

        public static bool IsUrl(string input)
        {
            if (Uri.TryCreate(input, UriKind.Absolute, out Uri uri))
            {
                return uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps;
            }
            else
            {
                return false;
            }
        }

        public static string ExtractExtensionFromBase64DataUri(string base64DataUri)
        {
            var regex = new Regex(@"data:(?<type>.*?);base64,");
            var match = regex.Match(base64DataUri);
            var type = match.Groups["type"].Value;
            var extension = "";

            switch (type)
            {
                case "image/png":
                    extension = "png";
                    break;
                case "image/jpeg":
                    extension = "jpeg";
                    break;
                case "image/jpg":
                    extension = "jpg";
                    break;
                default:
                    throw new ArgumentException("Unsupported file type");
            }

            return extension;
        }
        /* Generic Methods for Common Properties */
        public static void SoftDelete<T>(T entity) where T : class
		{
			var activeFlagProperty = entity.GetType().GetProperty("Active_Flag");
			var lastUpdatedProperty = entity.GetType().GetProperty("Last_Updated_Date");

			if (activeFlagProperty != null && lastUpdatedProperty != null)
			{
				activeFlagProperty.SetValue(entity, false);
				lastUpdatedProperty.SetValue(entity, DateTime.UtcNow);
			}
		}

		public static void UpdateTimestamp<T>(T entity) where T : BaseDto
		{
			var lastUpdatedProperty = entity.GetType().GetProperty("Last_Updated_Date");

			if (lastUpdatedProperty != null)
			{
				lastUpdatedProperty.SetValue(entity, DateTime.UtcNow);
			}
			
		}

		public static void UpdateActiveStatus<T>(T entity) where T : class
		{
			var entityType = entity.GetType();

			var activeFlagProperty = entityType.GetProperty("Active_Flag");
			var isActiveProperty = entityType.GetProperty("Is_Active");

			if (activeFlagProperty != null)
			{
				activeFlagProperty.SetValue(entity, true);
			}
			else if (isActiveProperty != null)
			{
				isActiveProperty.SetValue(entity, true);
			}
		}
	}
}

